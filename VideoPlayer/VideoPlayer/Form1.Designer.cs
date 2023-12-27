namespace VideoPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.wmpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPlay = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.btnStop = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.btnPause = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.btnUpload = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.trackBar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.barStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.barStatus);
            this.panel1.Controls.Add(this.trackBar);
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 591);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 70);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1061, 33);
            this.panel2.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Turquoise;
            this.lblTitle.Location = new System.Drawing.Point(12, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(50, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.wmpVideo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1061, 558);
            this.panel3.TabIndex = 2;
            // 
            // wmpVideo
            // 
            this.wmpVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpVideo.Enabled = true;
            this.wmpVideo.Location = new System.Drawing.Point(0, 0);
            this.wmpVideo.Name = "wmpVideo";
            this.wmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideo.OcxState")));
            this.wmpVideo.Size = new System.Drawing.Size(1061, 558);
            this.wmpVideo.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.BorderRadius = 10;
            this.btnPlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlay.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlay.FillColor2 = System.Drawing.Color.Aquamarine;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(7, 11);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(135, 49);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "PLAY";
            // 
            // btnStop
            // 
            this.btnStop.BorderRadius = 10;
            this.btnStop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStop.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStop.FillColor2 = System.Drawing.Color.Aquamarine;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(148, 11);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(135, 49);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "STOP";
            // 
            // btnPause
            // 
            this.btnPause.BorderRadius = 10;
            this.btnPause.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPause.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPause.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPause.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPause.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPause.FillColor2 = System.Drawing.Color.Aquamarine;
            this.btnPause.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(289, 10);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(135, 49);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "PAUSE";
            // 
            // btnUpload
            // 
            this.btnUpload.BorderRadius = 10;
            this.btnUpload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpload.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpload.FillColor2 = System.Drawing.Color.Aquamarine;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(866, 11);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(183, 49);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "OPEN VIDEO";
            // 
            // trackBar
            // 
            this.trackBar.FillColor = System.Drawing.Color.LightSeaGreen;
            this.trackBar.Location = new System.Drawing.Point(449, 22);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(370, 23);
            this.trackBar.TabIndex = 7;
            this.trackBar.ThumbColor = System.Drawing.Color.Turquoise;
            this.trackBar.Value = 25;
            this.trackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.siticoneTrackBar1_Scroll);
            // 
            // barStatus
            // 
            this.barStatus.AutoSize = true;
            this.barStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barStatus.ForeColor = System.Drawing.Color.Turquoise;
            this.barStatus.Location = new System.Drawing.Point(444, 33);
            this.barStatus.Name = "barStatus";
            this.barStatus.Size = new System.Drawing.Size(77, 24);
            this.barStatus.TabIndex = 8;
            this.barStatus.Text = "Volume";
            this.barStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.barStatus.Click += new System.EventHandler(this.barStatus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
        private AxWMPLib.AxWindowsMediaPlayer wmpVideo;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnPause;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnStop;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnPlay;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnUpload;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar trackBar;
        private System.Windows.Forms.Label barStatus;
    }
}

