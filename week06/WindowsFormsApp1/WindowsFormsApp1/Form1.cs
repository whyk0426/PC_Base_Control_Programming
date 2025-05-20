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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] vec = new double[] { 1, 7, 3 };
            double[] uvec = new double[3];
            Tmath.Normalize(vec, uvec);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double[] vec = new double[] { 1, 7, 3 };
            //double[] uvec; // = new double[3];
            //Tmath.Normalize(vec, out uvec);
            Tmath.Normalize(vec, out double[] uvec);
        }
    }
}
