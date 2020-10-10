using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWFPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Shockwave Flash File (*.swf)|*.swf";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Movie = ofd.FileName;
            axShockwaveFlash1.Play();
            button3.Enabled = true;
            button2.Enabled = false;
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Rewind();
            axShockwaveFlash1.Stop();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
        }
    }
}
