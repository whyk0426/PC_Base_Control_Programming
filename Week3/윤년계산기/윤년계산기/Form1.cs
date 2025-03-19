using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 윤년계산기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //4로 나누어 떨어지면 윤년
        //그런데 100으로 나눠지면 아님
        //400으로 나눠지면 윤년
        private void button1_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(textYear.Text);
            bool isLeapYear = (((year % 4) == 0) && ((year % 100) != 0) || ((year % 400) == 0));

            labelOut.Text = isLeapYear ? "윤년입니다" : "윤년이 아닙니다";
        }
    }
}
