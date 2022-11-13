using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installation
{
    public partial class Install : Form
    {

        // Requires https://github.com/UweKeim/dot-net-transitions
        // And Siticone.UI 
        // Should come with :)
        public Install()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new DownloadPaths().Downloads = true;
        }

        private void bunifuCheckBox2_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox2.Checked)
            {
                new DownloadPaths().Documents = false;
                bunifuShadowPanel2.BorderColor = System.Drawing.Color.FromArgb(58, 113, 193);
                bunifuShadowPanel2.ForeColor = System.Drawing.Color.FromArgb(58, 113, 193);
                bunifuShadowPanel2.PanelColor = System.Drawing.Color.FromArgb(58, 113, 193);
                bunifuShadowPanel2.PanelColor2 = System.Drawing.Color.FromArgb(58, 113, 193);
            } else
            {
                new DownloadPaths().Documents = true;
                bunifuShadowPanel2.BorderColor = System.Drawing.Color.FromArgb(16, 17, 22);
                bunifuShadowPanel2.ForeColor = System.Drawing.Color.FromArgb(16, 17, 22);
                bunifuShadowPanel2.PanelColor = System.Drawing.Color.FromArgb(16, 17, 22);
                bunifuShadowPanel2.PanelColor2 = System.Drawing.Color.FromArgb(16, 17, 22);
            }
        }

        private void bunifuCheckBox3_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox3.Checked)
            {
                new DownloadPaths().Desktop = false;
                bunifuShadowPanel3.BorderColor = System.Drawing.Color.FromArgb(58, 113, 193);
                bunifuShadowPanel3.ForeColor = System.Drawing.Color.FromArgb(58, 113, 193);
                bunifuShadowPanel3.PanelColor = System.Drawing.Color.FromArgb(58, 113, 193);
                bunifuShadowPanel3.PanelColor2 = System.Drawing.Color.FromArgb(58, 113, 193);
            }                    
            else                 
            {
                new DownloadPaths().Desktop = true;
                bunifuShadowPanel3.BorderColor = System.Drawing.Color.FromArgb(16, 17, 22);
                bunifuShadowPanel3.ForeColor = System.Drawing.Color.FromArgb(16, 17, 22);
                bunifuShadowPanel3.PanelColor = System.Drawing.Color.FromArgb(16, 17, 22);
                bunifuShadowPanel3.PanelColor2 = System.Drawing.Color.FromArgb(16, 17, 22);
            }
        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox1.Checked)
            {
                new DownloadPaths().Downloads = false;
                bunifuShadowPanel1.BorderColor = System.Drawing.Color.FromArgb(58, 113, 193);
                bunifuShadowPanel1.ForeColor = System.Drawing.Color.FromArgb(58, 113, 193);
                bunifuShadowPanel1.PanelColor = System.Drawing.Color.FromArgb(58, 113, 193);
                bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.FromArgb(58, 113, 193);
            }                    
            else                 
            {
                new DownloadPaths().Downloads = true;
                bunifuShadowPanel1.BorderColor = System.Drawing.Color.FromArgb(16, 17, 22);
                bunifuShadowPanel1.ForeColor = System.Drawing.Color.FromArgb(16, 17, 22);
                bunifuShadowPanel1.PanelColor = System.Drawing.Color.FromArgb(16, 17, 22);
                bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.FromArgb(16, 17, 22);
            }
        }

        private void siticoneCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void siticoneButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/minihood");
        }

        private void bunifuPictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/minihood");
        }
    }
}
