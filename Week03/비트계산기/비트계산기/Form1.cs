using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 비트계산기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SetCheckBox(int gB)
        {
            //checkBox0.Checked = (gB & 0x01) != 0;
            //checkBox1.Checked = (gB & 0x02) != 0;
            //checkBox2.Checked = (gB & 0x04) != 0;
            //checkBox3.Checked = (gB & 0x08) != 0;
            //checkBox4.Checked = (gB & 0x10) != 0; //16진수로
            //checkBox5.Checked = (gB & 0x20) != 0;
            //checkBox6.Checked = (gB & 0x40) != 0;
            //checkBox7.Checked = (gB & 0x80) != 0;

            checkBox0.Checked = (gB & 0x01 << 0) != 0;
            checkBox1.Checked = (gB & 0x01 << 1) != 0;
            checkBox2.Checked = (gB & 0x01 << 2) != 0;
            checkBox3.Checked = (gB & 0x01 << 3) != 0;
            checkBox4.Checked = (gB & 0x01 << 4) != 0;
            checkBox5.Checked = (gB & 0x01 << 5) != 0;
            checkBox6.Checked = (gB & 0x01 << 6) != 0;
            checkBox7.Checked = (gB & 0x01 << 7) != 0;
        }
        private void GetCheckBox(int gB)
        {
            if (checkBox0.Checked) gB |= 0x01; // gB = gB | 0x01
            if (checkBox1.Checked) gB |= 0x02;
            if (checkBox2.Checked) gB |= 0x04;
            if (checkBox3.Checked) gB |= 0x08;
            if (checkBox4.Checked) gB |= 0x10;
            if (checkBox5.Checked) gB |= 0x20;
            if (checkBox6.Checked) gB |= 0x40;
            if (checkBox7.Checked) gB |= 0x80;
            textBox_Number.Text = Convert.ToString(gB);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gB = Convert.ToInt32(textBox_Number.Text);
            SetCheckBox(gB);
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int gB = 0;
            GetCheckBox(gB);
        }

        private void button_On_Click(object sender, EventArgs e)
        {
            int gB = Convert.ToInt32(textBox_Number.Text);
            int index = Convert.ToInt32(textbox_Index.Text);
            checkBox0.Checked = ((gB & 0x01 << 0) != 0) || (index == 0);
            checkBox1.Checked = ((gB & 0x01 << 1) != 0) || (index == 1);
            checkBox2.Checked = ((gB & 0x01 << 2) != 0) || (index == 2);
            checkBox3.Checked = ((gB & 0x01 << 3) != 0) || (index == 3);
            checkBox4.Checked = ((gB & 0x01 << 4) != 0) || (index == 4);
            checkBox5.Checked = ((gB & 0x01 << 5) != 0) || (index == 5);
            checkBox6.Checked = ((gB & 0x01 << 6) != 0) || (index == 6);
            checkBox7.Checked = ((gB & 0x01 << 7) != 0) || (index == 7);

            int gB0 = 0;
            GetCheckBox(gB0);

        }

        private void button_Off_Click(object sender, EventArgs e)
        {
            int gB = Convert.ToInt32(textBox_Number.Text);
            int index = Convert.ToInt32(textbox_Index.Text);
            checkBox0.Checked = ((gB & 0x01 << 0) != 0) && (index != 0);
            checkBox1.Checked = ((gB & 0x01 << 1) != 0) && (index != 1);
            checkBox2.Checked = ((gB & 0x01 << 2) != 0) && (index != 2);
            checkBox3.Checked = ((gB & 0x01 << 3) != 0) && (index != 3);
            checkBox4.Checked = ((gB & 0x01 << 4) != 0) && (index != 4);
            checkBox5.Checked = ((gB & 0x01 << 5) != 0) && (index != 5);
            checkBox6.Checked = ((gB & 0x01 << 6) != 0) && (index != 6);
            checkBox7.Checked = ((gB & 0x01 << 7) != 0) && (index != 7);

            int gB0 = 0;
            GetCheckBox(gB0);
        }

        private void button_Toggle_Click(object sender, EventArgs e)
        {
            int gB = Convert.ToInt32(textBox_Number.Text);
            int index = Convert.ToInt32(textbox_Index.Text);
            checkBox0.Checked = !(((gB & 0x01 << 0) != 0) == (index == 0));
            checkBox1.Checked = !(((gB & 0x01 << 1) != 0) == (index == 1));
            checkBox2.Checked = !(((gB & 0x01 << 2) != 0) == (index == 2));
            checkBox3.Checked = !(((gB & 0x01 << 3) != 0) == (index == 3));
            checkBox4.Checked = !(((gB & 0x01 << 4) != 0) == (index == 4));
            checkBox5.Checked = !(((gB & 0x01 << 5) != 0) == (index == 5));
            checkBox6.Checked = !(((gB & 0x01 << 6) != 0) == (index == 6));
            checkBox7.Checked = !(((gB & 0x01 << 7) != 0) == (index == 7));

            int gB0 = 0;
            GetCheckBox(gB0);
        }

        private void button_ShiftUp_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(textbox_Index.Text);
            int gB = index << 1;
            textbox_Index.Text = Convert.ToString(gB);
            SetCheckBox(gB);
        }

        private void button_ShiftDown_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(textbox_Index.Text);
            int gB = index >> 1;
            textbox_Index.Text = Convert.ToString(gB);
            SetCheckBox(gB);
        }
    }
}
