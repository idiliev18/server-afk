using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace server_afk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            label3.Text = "Current Status: Start";
            timer1.Interval = 5000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i<20; i++)
            {
                SendKeys.Send("{W}");
            }

            for (int i = 0; i < 20; i++)
            {
                SendKeys.Send("{S}");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label3.Text = "Current Status: False";

        }
    }
}