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
using Leap;

namespace leap_sample0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SampleListener listener;
        Controller controller;
        bool connected = false;

        public double sens = 3.5,
            yoffset = 0.0,
            wsval=0.2,
            adval=0.2;
        public bool intersect = false;

        public void connect()
        {
            if (connected)
            {
                // Remove the listener
                controller.RemoveListener(listener);
                controller.Dispose();
                connected = false;
                connectbutton.Text = "Connect";
                fps_label.Text = "disconnected";
            }
            else
            {
                // Create listener and controller
                listener = new SampleListener();
                listener.form = this;
                controller = new Controller();

                if (controller.IsConnected)
                {
                    controller.AddListener(listener);
                    connectbutton.Text = "Disconnect";
                    connected = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connected)
            {
                controller.RemoveListener(listener);
                controller.Dispose();
            }
        }

        private void sensitivity_track_Scroll(object sender, EventArgs e)
        {
            sens = sensitivity_track.Value/1000.0;
            sensitivity.Text = Convert.ToString(Math.Round(sens,2));
        }

        private void intersect_radio_CheckedChanged(object sender, EventArgs e)
        {
            intersect = intersect_radio.Checked;
        }

        private void project_radio_CheckedChanged(object sender, EventArgs e)
        {
            intersect = intersect_radio.Checked;
        }

        private void yoffset_track_Scroll(object sender, EventArgs e)
        {
            yoffset = yoffset_track.Value / 500.0 - 1;
            yoffset_label.Text = Convert.ToString(Math.Round(yoffset, 2));
        }

        private void connectbutton_Click(object sender, EventArgs e)
        {
            connect();   
        }

        private void ws_track_Scroll(object sender, EventArgs e)
        {
            wsval = ws_track.Value / 1000.0;
            ws.Text = Convert.ToString(Math.Round(wsval, 2));
        }

        private void ad_track_Scroll(object sender, EventArgs e)
        {
            adval = ad_track.Value / 1000.0;
            ad.Text = Convert.ToString(Math.Round(adval, 2));
        }
    }

}
