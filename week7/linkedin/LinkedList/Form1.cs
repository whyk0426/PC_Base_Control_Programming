using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList
{
    public partial class Form1 : Form
    {
        SimpleList simplelist = new SimpleList();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Node n;
            n = new Node(0); simplelist.Append(n);
            n = new Node(1); simplelist.Append(n);
            n = new Node(2); simplelist.Append(n);

            txtPrint.Text = simplelist.Print();
        }

        private void btnMake20_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                //n = new Node(i); simplelist.Append(n);
                new Node(i, simplelist);
            }

            txtPrint.Text = simplelist.Print();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int inp = int.Parse(txtRemoveData.Text);
            Node n = simplelist.FindNodeOfData(inp);
            simplelist.Remove(n);

            txtPrint.Text = simplelist.Print();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            simplelist = simplelist.Reverse();
            txtPrint.Text = simplelist.Print();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            simplelist.Clear();
            txtPrint.Text = simplelist.Print();
        }
    }
}
