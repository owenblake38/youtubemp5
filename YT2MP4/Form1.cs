using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace YT2MP4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void formSkin1_Click(object sender, EventArgs e)
        {

        }


        private void bConvert_Click(object sender, EventArgs e)
        {
            string link = tURL.Text;
            System.Threading.Thread.Sleep(1000);
            tURL.Text = "";

            SaveVideoToDisk(link);
        }

        private void tURL_Enter(object sender, EventArgs e)
        {
            tURL.Text = "";
        }

        void SaveVideoToDisk(string link)
        {
            int n = 0;
            string path = @"C:\YT2MP4\";
            tResults.Text = "Initiating..." + Environment.NewLine;

            var youTube = YouTube.Default;
            var video = youTube.GetVideo(link);
            tResults.Text += "Video Fetched" + Environment.NewLine;
            while (n < 20)
            {
                progressBar.Value = n;
                n++;
            }
            string title = video.Title;
            int resolution = video.Resolution;
            tResults.Text += $"Creating stream of {title} at {resolution}" + Environment.NewLine;
            while (n < 40)
            {
                progressBar.Value = n;
                n++;
            }

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            tResults.Text += "Checking (or creating) directory at " + path + Environment.NewLine;
            while (n < 60)
            {
                progressBar.Value = n;
                n++;
            }

            string pathToSave = Path.Combine(path, video.Title + ".mp4");
            tResults.Text += "Saving file to " + path + Environment.NewLine;
            while (n < 80)
            {
                progressBar.Value = n;
                n++;
            }

            File.WriteAllBytes(pathToSave, video.GetBytes());
            tResults.Text += "Success!";
            while (n <= 100)
            {
                progressBar.Value = n;
                n++;
            }
        }
    }
}
