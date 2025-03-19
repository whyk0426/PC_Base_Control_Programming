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
            checkBox0.Checked = (gB & 0x01) != 0;
            checkBox1.Checked = (gB & 0x02) != 0;
            checkBox2.Checked = (gB & 0x04) != 0;
            checkBox3.Checked = (gB & 0x08) != 0;
            checkBox4.Checked = (gB & 0x10) != 0; //16진수로
            checkBox5.Checked = (gB & 0x20) != 0;
            checkBox6.Checked = (gB & 0x40) != 0;
            checkBox7.Checked = (gB & 0x80) != 0;

            //checkBox0.Checked = (gB & 0x01 << 0) != 0;
            //checkBox1.Checked = (gB & 0x02 << 1) != 0;
            //checkBox2.Checked = (gB & 0x04 << 2) != 0;
            //checkBox3.Checked = (gB & 0x08 << 3) != 0;
            //checkBox4.Checked = (gB & 0x10 << 4) != 0; 
            //checkBox5.Checked = (gB & 0x20 << 5) != 0;
            //checkBox6.Checked = (gB & 0x40 << 6) != 0;
            //checkBox7.Checked = (gB & 0x80 << 7) != 0;
        }
        private void GetCheckBox(int gB)
        {
            if (checkBox0.Checked) gB |= 0x01;
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
            
        }
    }
}
