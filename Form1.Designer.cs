namespace leap_sample0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fps_label = new System.Windows.Forms.Label();
            this.sensitivity_track = new System.Windows.Forms.TrackBar();
            this.sensitivity_text = new System.Windows.Forms.Label();
            this.sensitivity = new System.Windows.Forms.Label();
            this.intersect_radio = new System.Windows.Forms.RadioButton();
            this.project_radio = new System.Windows.Forms.RadioButton();
            this.yoffset_track = new System.Windows.Forms.TrackBar();
            this.yoffset_text = new System.Windows.Forms.Label();
            this.yoffset_label = new System.Windows.Forms.Label();
            this.connectbutton = new System.Windows.Forms.Button();
            this.ws_track = new System.Windows.Forms.TrackBar();
            this.ws_text = new System.Windows.Forms.Label();
            this.ad_text = new System.Windows.Forms.Label();
            this.ad_track = new System.Windows.Forms.TrackBar();
            this.ws = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.Label();
            this.wasd_check = new System.Windows.Forms.CheckBox();
            this.debug_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivity_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoffset_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ws_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ad_track)).BeginInit();
            this.SuspendLayout();
            // 
            // fps_label
            // 
            this.fps_label.AutoSize = true;
            this.fps_label.Location = new System.Drawing.Point(12, 9);
            this.fps_label.Name = "fps_label";
            this.fps_label.Size = new System.Drawing.Size(71, 13);
            this.fps_label.TabIndex = 0;
            this.fps_label.Text = "disconnected";
            // 
            // sensitivity_track
            // 
            this.sensitivity_track.Location = new System.Drawing.Point(12, 57);
            this.sensitivity_track.Maximum = 10000;
            this.sensitivity_track.MaximumSize = new System.Drawing.Size(1000, 20);
            this.sensitivity_track.Name = "sensitivity_track";
            this.sensitivity_track.Size = new System.Drawing.Size(183, 45);
            this.sensitivity_track.TabIndex = 1;
            this.sensitivity_track.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sensitivity_track.Value = 3500;
            this.sensitivity_track.Scroll += new System.EventHandler(this.sensitivity_track_Scroll);
            // 
            // sensitivity_text
            // 
            this.sensitivity_text.AutoSize = true;
            this.sensitivity_text.Location = new System.Drawing.Point(12, 41);
            this.sensitivity_text.Name = "sensitivity_text";
            this.sensitivity_text.Size = new System.Drawing.Size(54, 13);
            this.sensitivity_text.TabIndex = 2;
            this.sensitivity_text.Text = "Sensitivity";
            // 
            // sensitivity
            // 
            this.sensitivity.AutoSize = true;
            this.sensitivity.Location = new System.Drawing.Point(201, 57);
            this.sensitivity.Name = "sensitivity";
            this.sensitivity.Size = new System.Drawing.Size(22, 13);
            this.sensitivity.TabIndex = 3;
            this.sensitivity.Text = "3.5";
            // 
            // intersect_radio
            // 
            this.intersect_radio.AutoSize = true;
            this.intersect_radio.Location = new System.Drawing.Point(15, 145);
            this.intersect_radio.Name = "intersect_radio";
            this.intersect_radio.Size = new System.Drawing.Size(65, 17);
            this.intersect_radio.TabIndex = 4;
            this.intersect_radio.Text = "intersect";
            this.intersect_radio.UseVisualStyleBackColor = true;
            this.intersect_radio.CheckedChanged += new System.EventHandler(this.intersect_radio_CheckedChanged);
            // 
            // project_radio
            // 
            this.project_radio.AutoSize = true;
            this.project_radio.Checked = true;
            this.project_radio.Location = new System.Drawing.Point(15, 168);
            this.project_radio.Name = "project_radio";
            this.project_radio.Size = new System.Drawing.Size(57, 17);
            this.project_radio.TabIndex = 5;
            this.project_radio.TabStop = true;
            this.project_radio.Text = "project";
            this.project_radio.UseVisualStyleBackColor = true;
            this.project_radio.CheckedChanged += new System.EventHandler(this.project_radio_CheckedChanged);
            // 
            // yoffset_track
            // 
            this.yoffset_track.Location = new System.Drawing.Point(15, 101);
            this.yoffset_track.Maximum = 1000;
            this.yoffset_track.MaximumSize = new System.Drawing.Size(1000, 35);
            this.yoffset_track.MinimumSize = new System.Drawing.Size(100, 0);
            this.yoffset_track.Name = "yoffset_track";
            this.yoffset_track.Size = new System.Drawing.Size(180, 45);
            this.yoffset_track.TabIndex = 6;
            this.yoffset_track.TickStyle = System.Windows.Forms.TickStyle.None;
            this.yoffset_track.Value = 500;
            this.yoffset_track.Scroll += new System.EventHandler(this.yoffset_track_Scroll);
            // 
            // yoffset_text
            // 
            this.yoffset_text.AutoSize = true;
            this.yoffset_text.Location = new System.Drawing.Point(12, 85);
            this.yoffset_text.Name = "yoffset_text";
            this.yoffset_text.Size = new System.Drawing.Size(42, 13);
            this.yoffset_text.TabIndex = 7;
            this.yoffset_text.Text = "YOffset";
            // 
            // yoffset_label
            // 
            this.yoffset_label.AutoSize = true;
            this.yoffset_label.Location = new System.Drawing.Point(201, 101);
            this.yoffset_label.Name = "yoffset_label";
            this.yoffset_label.Size = new System.Drawing.Size(13, 13);
            this.yoffset_label.TabIndex = 8;
            this.yoffset_label.Text = "0";
            // 
            // connectbutton
            // 
            this.connectbutton.Location = new System.Drawing.Point(392, 164);
            this.connectbutton.Name = "connectbutton";
            this.connectbutton.Size = new System.Drawing.Size(75, 23);
            this.connectbutton.TabIndex = 9;
            this.connectbutton.Text = "Connect";
            this.connectbutton.UseVisualStyleBackColor = true;
            this.connectbutton.Click += new System.EventHandler(this.connectbutton_Click);
            // 
            // ws_track
            // 
            this.ws_track.Location = new System.Drawing.Point(256, 57);
            this.ws_track.Maximum = 1000;
            this.ws_track.MaximumSize = new System.Drawing.Size(1000, 45);
            this.ws_track.Name = "ws_track";
            this.ws_track.Size = new System.Drawing.Size(183, 45);
            this.ws_track.TabIndex = 10;
            this.ws_track.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ws_track.Value = 200;
            this.ws_track.Scroll += new System.EventHandler(this.ws_track_Scroll);
            // 
            // ws_text
            // 
            this.ws_text.AutoSize = true;
            this.ws_text.Location = new System.Drawing.Point(253, 41);
            this.ws_text.Name = "ws_text";
            this.ws_text.Size = new System.Drawing.Size(25, 13);
            this.ws_text.TabIndex = 11;
            this.ws_text.Text = "WS";
            // 
            // ad_text
            // 
            this.ad_text.AutoSize = true;
            this.ad_text.Location = new System.Drawing.Point(253, 85);
            this.ad_text.Name = "ad_text";
            this.ad_text.Size = new System.Drawing.Size(22, 13);
            this.ad_text.TabIndex = 13;
            this.ad_text.Text = "AD";
            // 
            // ad_track
            // 
            this.ad_track.Location = new System.Drawing.Point(256, 101);
            this.ad_track.Maximum = 1000;
            this.ad_track.MaximumSize = new System.Drawing.Size(1000, 45);
            this.ad_track.Name = "ad_track";
            this.ad_track.Size = new System.Drawing.Size(183, 45);
            this.ad_track.TabIndex = 12;
            this.ad_track.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ad_track.Value = 500;
            this.ad_track.Scroll += new System.EventHandler(this.ad_track_Scroll);
            // 
            // ws
            // 
            this.ws.AutoSize = true;
            this.ws.Location = new System.Drawing.Point(445, 57);
            this.ws.Name = "ws";
            this.ws.Size = new System.Drawing.Size(22, 13);
            this.ws.TabIndex = 14;
            this.ws.Text = "0.1";
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Location = new System.Drawing.Point(445, 101);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(22, 13);
            this.ad.TabIndex = 15;
            this.ad.Text = "0.2";
            // 
            // wasd_check
            // 
            this.wasd_check.AutoSize = true;
            this.wasd_check.Location = new System.Drawing.Point(256, 142);
            this.wasd_check.Name = "wasd_check";
            this.wasd_check.Size = new System.Drawing.Size(59, 17);
            this.wasd_check.TabIndex = 16;
            this.wasd_check.Text = "WASD";
            this.wasd_check.UseVisualStyleBackColor = true;
            // 
            // debug_label
            // 
            this.debug_label.AutoSize = true;
            this.debug_label.Location = new System.Drawing.Point(253, 172);
            this.debug_label.Name = "debug_label";
            this.debug_label.Size = new System.Drawing.Size(37, 13);
            this.debug_label.TabIndex = 17;
            this.debug_label.Text = "debug";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 201);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.debug_label);
            this.Controls.Add(this.wasd_check);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.ws);
            this.Controls.Add(this.ad_text);
            this.Controls.Add(this.ad_track);
            this.Controls.Add(this.ws_text);
            this.Controls.Add(this.ws_track);
            this.Controls.Add(this.connectbutton);
            this.Controls.Add(this.yoffset_label);
            this.Controls.Add(this.yoffset_text);
            this.Controls.Add(this.yoffset_track);
            this.Controls.Add(this.project_radio);
            this.Controls.Add(this.intersect_radio);
            this.Controls.Add(this.sensitivity);
            this.Controls.Add(this.sensitivity_text);
            this.Controls.Add(this.sensitivity_track);
            this.Controls.Add(this.fps_label);
            this.Name = "Form1";
            this.Text = "LeapInput";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sensitivity_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoffset_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ws_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ad_track)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label fps_label;
        private System.Windows.Forms.TrackBar sensitivity_track;
        private System.Windows.Forms.Label sensitivity_text;
        private System.Windows.Forms.Label sensitivity;
        private System.Windows.Forms.RadioButton intersect_radio;
        private System.Windows.Forms.RadioButton project_radio;
        private System.Windows.Forms.TrackBar yoffset_track;
        private System.Windows.Forms.Label yoffset_text;
        private System.Windows.Forms.Label yoffset_label;
        private System.Windows.Forms.Button connectbutton;
        private System.Windows.Forms.TrackBar ws_track;
        private System.Windows.Forms.Label ws_text;
        private System.Windows.Forms.Label ad_text;
        private System.Windows.Forms.TrackBar ad_track;
        private System.Windows.Forms.Label ws;
        private System.Windows.Forms.Label ad;
        public System.Windows.Forms.CheckBox wasd_check;
        public System.Windows.Forms.Label debug_label;
        private System.Windows.Forms.TextBox textBox1;

    }
}

