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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void refresh(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(refresh);
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
