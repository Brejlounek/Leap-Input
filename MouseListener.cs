using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using Leap;

namespace leap_sample0
{
    class SampleListener : Listener
    {
        private Object thisLock = new Object();

        Stopwatch stopWatch;
        long lasttime = 0;
        double timeaccum = 0;
        long framesaccum = 0;

        private double lx = double.MinValue,
                        ly = double.MinValue;
        bool pW = false, pA = false, pS = false, pD = false;
        double phase = 0,freq=30;
        int par = 1;

        ScreenList screens;

        public Form1 form;

        struct INPUT
        {
            public UInt32 type;
            public ushort wVk;
            public ushort wScan;
            public UInt32 dwFlags;
            public UInt32 time;
            public UIntPtr dwExtraInfo;
            public UInt32 uMsg;
            public ushort wParamL;
            public ushort wParamH;

        }

        enum SendInputFlags
        {
            KEYEVENTF_EXTENDEDKEY = 0x0001,
            KEYEVENTF_KEYUP = 0x0002,
            KEYEVENTF_UNICODE = 0x0004,
            KEYEVENTF_SCANCODE = 0x0008,
        }

        [DllImport("user32.dll")]
        static extern UInt32 SendInput(UInt32 nInputs,
          [MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] INPUT[] pInputs,
          Int32 cbSize);

        //press key
        public static void Stroke(ushort ScanCode)
        {
            INPUT[] InputData = new INPUT[1];
            InputData[0].type = 1;
            InputData[0].wScan = (ushort)ScanCode;
            InputData[0].dwFlags = (uint)SendInputFlags.KEYEVENTF_SCANCODE;
            SendInput(1, InputData, Marshal.SizeOf(InputData[0]));
        }

        //release key
        public static void Release(ushort ScanCode)
        {
            INPUT[] InputData = new INPUT[1];
            InputData[0].type = 1;
            InputData[0].wScan = (ushort)ScanCode;
            InputData[0].dwFlags = (uint)(SendInputFlags.KEYEVENTF_SCANCODE | SendInputFlags.KEYEVENTF_KEYUP);
            SendInput(1, InputData, Marshal.SizeOf(InputData[0]));
        }

        private void SafeWriteLine(String line)
        {
            lock (thisLock)
            {
                Console.WriteLine(line);
            }
        }

        public override void OnInit(Controller controller)
        {
            SafeWriteLine("Initialized");
            stopWatch = new Stopwatch();
            stopWatch.Start();
            controller.SetPolicyFlags(Controller.PolicyFlag.POLICYBACKGROUNDFRAMES);
        }

        //changing label thread-safe
        private void UpdateText(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                label.Invoke((Action)(() => UpdateText(label, text)));
                return;
            }
            label.Text = text;
        }

        public override void OnFrame(Controller controller)
        {
            //get screens
            screens = controller.CalibratedScreens;

            //calculate fps
            double fps = 1.0 * Stopwatch.Frequency / (stopWatch.ElapsedTicks - lasttime);
            lasttime = stopWatch.ElapsedTicks;

            timeaccum += 1.0 / fps;
            framesaccum++;
            if (timeaccum >= 0.5)
            {
                UpdateText(form.fps_label, "fps: " + Convert.ToString((int)(1.0 * framesaccum / timeaccum)));
                timeaccum -= 0.5;
                framesaccum = 0;
            }

            bool wasd = false;
            float scale, yoffset,ws,ad;
            bool intersect;
            lock (thisLock) //get access to input data
            {
                scale = (float)form.sens;
                yoffset = (float)form.yoffset;
                ws = (float)form.wsval;
                ad = (float)form.adval;
                intersect = form.intersect;
                wasd = form.wasd_check.Checked;
            }

            //move phase for keyboard simulation
            phase += par / fps * freq;
            if (phase > 1)
            {
                par = -1;
                phase = 1;
            }
            if (phase < 0)
            {
                par = 1;
                phase = 0;
            }

            Pointable point1 = null;
            bool point1_ok = false;

            // Get the most recent frame
            Frame frame = controller.Frame();

            if (!frame.Tools.Empty)
            {
                //get the nearest tool
                int nearest = 0;
                double nearestval = double.MaxValue;
                ToolList tools = frame.Tools;
                for (int i = 0; i < tools.Count(); i++)
                {
                    if (tools[i].TipPosition.z < nearestval)
                    {
                        nearest = i;
                        nearestval = tools[i].TipPosition.z;
                    }
                }
                point1 = tools[nearest];
                point1_ok = true;
            }
            else if (!frame.Hands.Empty)
            {
                // Get the first hand
                Hand hand = frame.Hands[0];

                // Check if the hand has any fingers
                FingerList fingers = hand.Fingers;
                if (!fingers.Empty)
                {

                    //get the finger closest to the screen (smallest z)
                    int nearest = 0;
                    double nearestval = double.MaxValue;
                    for (int i = 0; i < fingers.Count(); i++)
                    {
                        if (fingers[i].TipPosition.z < nearestval)
                        {
                            nearest = i;
                            nearestval = fingers[i].TipPosition.z;
                        }
                    }
                    point1 = fingers[nearest];
                    point1_ok = true;

                }

            }

            if (point1_ok) //there is finger or tool
            {
                PointConverter pc = new PointConverter();
                Point pt = new Point();

                //wasd not checked
                if (!wasd)
                {
                    //interset/project on screen
                    Vector intersection;
                    if (intersect)
                        intersection = screens[0].Intersect(point1, true, 4.0f / scale);
                    else
                        intersection = screens[0].Project(point1.TipPosition, true, 4.0f / scale);

                    //scale and offset screen position
                    double scx = (intersection.x - 0.5) * scale + 0.5;
                    double scy = (1 - intersection.y - 0.5) * scale + 0.5 + yoffset;
                    pt.X = (int)(scx * screens[0].WidthPixels);
                    pt.Y = (int)(scy * screens[0].HeightPixels);

                    Cursor.Position = pt;
                }
                //if wasd is checked
                else
                {
                    string str = "";

                    float x = point1.TipPosition.x;
                    float y = point1.TipPosition.y;
                    float z = point1.TipPosition.z;

                    var hWnd = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
                    Hand hand = frame.Hands[0];

                    double xph = -hand.PalmNormal.Roll*ad*8; //steering using roll
                    double zph = (Math.Abs(hand.PalmPosition.z-100) - ws * 200.0) / (200.0 * ws); //acceleration using z

                    //stroke or release given keys
                    
                    if (xph > 0 && Math.Abs(xph) > phase)
                    {
                        str += "D";
                        if (!pD || Math.Abs(xph) > 1)
                            Stroke(0x20);
                        pD = true;
                    }
                    else
                    {
                        if (pD)
                            Release(0x20);
                        pD = false;
                    }

                    if (z > 0 && zph > phase)
                    {
                        str += "S";
                        if (!pS || zph > 1)
                            Stroke(0x1F);
                        pS = true;
                    }
                    else
                    {
                        if (pS)
                            Release(0x1F);
                        pS = false;
                    }
                    if (z < 0 && zph > phase)
                    {
                        str += "W";
                        if (!pW || zph > 1)
                            Stroke(0x11);
                        pW = true;
                    }
                    else
                    {
                        if (pW)
                            Release(0x11);
                        pW = false;
                    }

                    UpdateText(form.debug_label, Convert.ToString(str));
                }
            }
            else
            {
                if (pW)
                    Release(0x11);
                if (pA)
                    Release(0x1E);
                if (pS)
                    Release(0x1F);
                if (pD)
                    Release(0x20);
                pW = false;
                pA = false;
                pS = false;
                pD = false;
            }

        }
    }
}
