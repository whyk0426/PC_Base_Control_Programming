using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcul.Divide(10, 3, out int q, out int _);
            Console.WriteLine(q);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 2, y =4;
            calcul.Swap(ref x, ref y);
        }
    }
}
