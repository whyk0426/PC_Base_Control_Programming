using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {
        int dx = 1;
        int dy = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Slow_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 20;
        }

        private void Fast_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (((Ball.Left + Ball.Size.Width) == ClientSize.Width) || (Ball.Left == 0)) dx = -dx;
            Ball.Left += dx;
        }
    }
}
