using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime t = DateTime.Now; //now는 속성, 함수는 ()가 붙어야
            lblTime.Text = t.ToString();
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            string st = txtIN1.Text;
            int len = st.Trim().Length;
            txtOUT.Text = len.ToString();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            try
            {
                string st = txtIN1.Text;
                int len = int.Parse(txtIN2.Text);
                txtOUT.Text = st.Substring(0, len);
            }
            catch
            {
                MessageBox.Show("오류가 있습니다");
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            try
            {
                string st = txtIN1.Text;
                int len = int.Parse(txtIN2.Text);
                txtOUT.Text = st.Substring(st.Length - len, len);
            }
            catch
            {
                MessageBox.Show("오류가 있습니다");
            }
        }

        private void btnMid_Click(object sender, EventArgs e)
        {
            string st = txtIN1.Text;
            txtOUT.Text = st.Substring(1, 3);
        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            string st = txtIN1.Text;
            txtOUT.Text = st.ToUpper();
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            string st = txtIN1.Text;
            txtOUT.Text = st.ToLower();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string st1 = txtIN1.Text;
            string st2 = txtIN2.Text;

            //if (st1 == st2)
            //    txtOUT.Text = "같다";
            //else
            //    txtOUT.Text = "다르다";  // 마이크로소프트의 사기. 참조는 같을 수가 없음. -> 쓰더라도 알고 쓰자

            if (st1.CompareTo(st2) == 0)
                txtOUT.Text = "같다";
            else
                txtOUT.Text = "다르다";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string st1 = txtIN1.Text;
            string st2 = txtIN2.Text;

            int idx = st1.IndexOf(st2);
            txtOUT.Text = idx.ToString();
        }

        private void btnPadLeft_Click(object sender, EventArgs e)
        {
            string st = txtIN1.Text;
            int len = int.Parse(txtIN2.Text);
            txtOUT.Text = st.PadLeft(len);
        }

        private void btnPadRight_Click(object sender, EventArgs e)
        {
            string st = txtIN1.Text;
            int len = int.Parse(txtIN2.Text);
            txtOUT.Text = st.PadRight(len); // 클래스(빵틀) <= static, 빵 <= non-static
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            string st = lblTime.Text;
            string[] word = st.Split(new char[] { '-', ' ', ':' });
            txtOUT.Text = word[4] + "시 입니다";
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string st = lblTime.Text;
            txtOUT.Text = st.Replace(" ", "");
        }
    }
}
