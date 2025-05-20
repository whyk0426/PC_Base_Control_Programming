using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(textYear.Text);
            int month = Convert.ToInt32(textMonth.Text);
            int day = Convert.ToInt32(textDay.Text);

            if (month == 1 || month == 2)
            {
                year--;
                month += 12;
            }
            int s = year + (year / 4) - (year / 100) + (year / 400) + (int)(2.6 * month + 1.6) + day; // Convert 하면 반올림돼서 (Int)로
            int r = s % 7;
            //if (r == 0) labelOut.Text = "일요일 입니다!";
            //if (r == 1) labelOut.Text = "월요일 입니다!";
            //if (r == 2) labelOut.Text = "화요일 입니다!";
            //if (r == 3) labelOut.Text = "수요일 입니다!";
            //if (r == 4) labelOut.Text = "목요일 입니다!";
            //if (r == 5) labelOut.Text = "금요일 입니다!";
            //if (r == 6) labelOut.Text = "토요일 입니다!";

            String[] st = new string[7] {"일", "월", "화", "수", "목", "금", "토"};
            labelOut.Text = st[r] + "요일 입니다!";
        }
    }
}
