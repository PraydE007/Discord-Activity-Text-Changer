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

        private int x = 0;
        private int y = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1;
        }

        // Exit Button
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Apply New Text
        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
        }

        // Hide Window
        private void button2_Click(object sender, EventArgs e)
        {
            pos = this.Location;
            this.Location = new Point(-500, -300);
            notifyIcon1.Visible = true;
        }

        private void notifyIcon1_Click_1(object sender, EventArgs e)
        {
            this.Location = pos;
            notifyIcon1.Visible = false;
        }

        // Start Moving
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = MousePosition.X - this.Location.X;
                y = MousePosition.Y - this.Location.Y;
                timer1.Enabled = true;
            }
        }

        // Stop Moving
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
        }

        // Window Moving Func
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(MousePosition.X - x, MousePosition.Y - y);
        }
    }
}
