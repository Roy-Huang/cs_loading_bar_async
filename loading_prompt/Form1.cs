using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loading_prompt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;

            button1.Enabled = false;
            await Task.Run(() => LoadToDo());
            
            button1.Enabled = true;
            progressBar1.Visible = false;
        }

        private void LoadToDo()
        {
            Thread.Sleep(5000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar2.Visible = true;
          //  progressBar2.Style = ProgressBarStyle.Marquee;
            progressBar2.Minimum = 1;
            progressBar2.Maximum = 30;
            progressBar2.Value = 1;
            progressBar2.Step = 1;
            button2.Enabled = false;

            for (int i = 0; i < 30; i++)
            {
                progressBar2.PerformStep();
                Thread.Sleep(100);
            }

            button2.Enabled = true;
            progressBar2.Visible = false;
        }
    }
}
