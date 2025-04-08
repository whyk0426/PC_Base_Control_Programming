using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace constructer
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_catMaker_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat("nero", "black");

        }

        private void button_catN_Click(object sender, EventArgs e)
        {
            GC.Collect();
            label1.Text = Cat.Ncat.ToString();
        }
    }
}
