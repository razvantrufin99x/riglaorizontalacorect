using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace riglaorizontala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ismd = 0;

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = 0;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd ==1)
            {
                Left += e.X;
                Top += e.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = 1;
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = 0;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd == 1)
            {
                Left += e.X;
                Top += e.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = 1;
        }
    }
}
