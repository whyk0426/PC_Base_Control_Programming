using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalSec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_TotalSec_Click(object sender, EventArgs e)
        {
            int hour = Convert.ToInt32(textBox_Hour.Text);
            int minute = Convert.ToInt32(textBox_Min.Text);
            int sec = Convert.ToInt32(textBox_Sec.Text);

            int TotalSec = hour * 60 * 60 + minute * 60 + sec;
            textBox_TotalSec.Text = TotalSec.ToString();
        }

        private void button_HMN_Click(object sender, EventArgs e)
        {
            int TotalSec = Convert.ToInt32(textBox_TotalSec.Text);
            int TotalMin = TotalSec / 60;

            textBox_Hour.Text = Convert.ToString(TotalMin / 60);
            textBox_Min.Text = Convert.ToString(TotalMin % 60);
            textBox_Sec.Text = Convert.ToString(TotalSec % 60);
        }
    }
}
