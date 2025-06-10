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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToBit_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumber.Text);

            chk0.Checked = (num & 0x01 << 0) != 0;
            chk1.Checked = (num & 0x01 << 1) != 0;
            chk2.Checked = (num & 0x01 << 2) != 0;
            chk3.Checked = (num & 0x01 << 3) != 0;
            chk4.Checked = (num & 0x01 << 4) != 0;
            chk5.Checked = (num & 0x01 << 5) != 0;
            chk6.Checked = (num & 0x01 << 6) != 0;
            chk7.Checked = (num & 0x01 << 7) != 0;
        }

        private void btnFromBit_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (chk0.Checked) num = num | 0x01 << 0;
            if (chk1.Checked) num = num | 0x01 << 1;
            if (chk2.Checked) num = num | 0x01 << 2;
            if (chk3.Checked) num = num | 0x01 << 3;
            if (chk4.Checked) num = num | 0x01 << 4;
            if (chk5.Checked) num = num | 0x01 << 5;
            if (chk6.Checked) num = num | 0x01 << 6;
            if (chk7.Checked) num = num | 0x01 << 7;

            txtNumber.Text = Convert.ToString(num);
        }

        private void btnON_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(txtIndex.Text);

            int num = 0;
            if (chk0.Checked) num = num | 0x01 << 0;
            if (chk1.Checked) num = num | 0x01 << 1;
            if (chk2.Checked) num = num | 0x01 << 2;
            if (chk3.Checked) num = num | 0x01 << 3;
            if (chk4.Checked) num = num | 0x01 << 4;
            if (chk5.Checked) num = num | 0x01 << 5;
            if (chk6.Checked) num = num | 0x01 << 6;
            if (chk7.Checked) num = num | 0x01 << 7;

            chk0.Checked = ((num & 0x01 << 0) != 0) || (index == 0);
            chk1.Checked = ((num & 0x01 << 1) != 0) || (index == 1);
            chk2.Checked = ((num & 0x01 << 2) != 0) || (index == 2);
            chk3.Checked = ((num & 0x01 << 3) != 0) || (index == 3);
            chk4.Checked = ((num & 0x01 << 4) != 0) || (index == 4);
            chk5.Checked = ((num & 0x01 << 5) != 0) || (index == 5);
            chk6.Checked = ((num & 0x01 << 6) != 0) || (index == 6);
            chk7.Checked = ((num & 0x01 << 7) != 0) || (index == 7);
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(txtIndex.Text);

            int num = 0;
            if (chk0.Checked) num = num | 0x01 << 0;
            if (chk1.Checked) num = num | 0x01 << 1;
            if (chk2.Checked) num = num | 0x01 << 2;
            if (chk3.Checked) num = num | 0x01 << 3;
            if (chk4.Checked) num = num | 0x01 << 4;
            if (chk5.Checked) num = num | 0x01 << 5;
            if (chk6.Checked) num = num | 0x01 << 6;
            if (chk7.Checked) num = num | 0x01 << 7;

            chk0.Checked = ((num & 0x01 << 0) != 0) && (index != 0);
            chk1.Checked = ((num & 0x01 << 1) != 0) && (index != 1);
            chk2.Checked = ((num & 0x01 << 2) != 0) && (index != 2);
            chk3.Checked = ((num & 0x01 << 3) != 0) && (index != 3);
            chk4.Checked = ((num & 0x01 << 4) != 0) && (index != 4);
            chk5.Checked = ((num & 0x01 << 5) != 0) && (index != 5);
            chk6.Checked = ((num & 0x01 << 6) != 0) && (index != 6);
            chk7.Checked = ((num & 0x01 << 7) != 0) && (index != 7);
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(txtIndex.Text);

            int num = 0;
            if (chk0.Checked) num = num | 0x01 << 0;
            if (chk1.Checked) num = num | 0x01 << 1;
            if (chk2.Checked) num = num | 0x01 << 2;
            if (chk3.Checked) num = num | 0x01 << 3;
            if (chk4.Checked) num = num | 0x01 << 4;
            if (chk5.Checked) num = num | 0x01 << 5;
            if (chk6.Checked) num = num | 0x01 << 6;
            if (chk7.Checked) num = num | 0x01 << 7;

            chk0.Checked = !(((num & 0x01 << 0) != 0) == (index == 0));
            chk1.Checked = !(((num & 0x01 << 1) != 0) == (index == 1));
            chk2.Checked = !(((num & 0x01 << 2) != 0) == (index == 2));
            chk3.Checked = !(((num & 0x01 << 3) != 0) == (index == 3));
            chk4.Checked = !(((num & 0x01 << 4) != 0) == (index == 4));
            chk5.Checked = !(((num & 0x01 << 5) != 0) == (index == 5));
            chk6.Checked = !(((num & 0x01 << 6) != 0) == (index == 6));
            chk7.Checked = !(((num & 0x01 << 7) != 0) == (index == 7));
        }

        private void btnShiftUp_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumber.Text);
            int shifted_num = num << 1;
            txtNumber.Text = Convert.ToString(shifted_num);
        }

        private void btnShiftDown_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumber.Text);
            int shifted_num = num >> 1;
            txtNumber.Text = Convert.ToString(shifted_num);
        }
    }
}
