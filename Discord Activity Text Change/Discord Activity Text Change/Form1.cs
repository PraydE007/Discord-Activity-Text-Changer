using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord_Activity_Text_Change
{
    public partial class Form1 : Form
    {

        private Point pos;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pos = this.Location;
            this.Location = new Point(-500, -200);
            //this.WindowState = FormWindowState.Minimized;
            notifyIcon1.Visible = true;
        }

        private void notifyIcon1_Click_1(object sender, EventArgs e)
        {
            this.Location = pos;
            //this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }
    }
}
