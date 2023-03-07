using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pierwszyproj2
{
    public partial class Form2 : Form
    {
        TimeSpan timePassed = TimeSpan.Zero;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "00:00:00";
            timer1.Interval = 1000;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = timePassed.ToString();
            timePassed = timePassed.Add(new TimeSpan(0,0,1));
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "00:00:00";
            timePassed = TimeSpan.Zero;
        }
    }
}
