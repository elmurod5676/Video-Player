using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoPlayer
{
    public partial class Form1 : Form
    {
        string videoPath, VideoTitle;
        public Form1()
        {
            InitializeComponent();
            wmpVideo.uiMode = "none";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.stop();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.pause();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            wmpVideo.settings.volume = trackBar.Value;
        }

        private void barStatus_Click(object sender, EventArgs e)
        {
            barStatus.Text = trackBar.Value.ToString();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog() { Multiselect = true,Filter="MP4 File | *.mp4" };
            if(openfiledialog.ShowDialog() == DialogResult.OK)
            {
                videoPath = openfiledialog.FileName;
                VideoTitle = openfiledialog.SafeFileName;
                wmpVideo.URL = videoPath;
                lblTitle.Text = VideoTitle;
            }
        }
    }
}
