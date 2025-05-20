using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Homework_LeastSquare
{
    public partial class Form1: Form
    {
        double x_min = -2, x_max = 7;
        double y_min = -5, y_max = 70;   

        private float x_pixel(double xw)
        {
            double w = pictureBox1.ClientSize.Width;
            return (float)(w * (xw - x_min) / (x_max - x_min));
        }

        private float y_pixel(double yw)
        {
            double h = pictureBox1.ClientSize.Height;
            return (float)(h * (1 - (yw - y_min) / (y_max - y_min)));
        }
        private double[] A_calculator(int n, double[] x, double[] y)
        {
            double X = 0, XX = 0, XXX = 0, XXXX = 0, Y = 0, XY = 0, XXY = 0;
            for (int i = 0; i < n; i++)
            {
                X += x[i];
                XX += x[i] * x[i];
                XXX += x[i] * x[i] * x[i];
                XXXX += x[i] * x[i] * x[i] * x[i];
                Y += y[i];
                XY += x[i] * y[i];
                XXY += x[i] * x[i] * y[i];
            }
            double det = n * ((XX * XXXX) - (XXX * XXX)) - X * ((X * XXXX) - (XX * XXX)) + XX * ((X * XXX) - (XX * XX));
            double det0 = Y * ((XX * XXXX) - (XXX * XXX)) - X * ((XY * XXXX) - (XXY * XXX)) + XX * ((XY * XXX) - (XXY * XX));
            double det1 = n * ((XY * XXXX) - (XXY * XXX)) - Y * ((X * XXXX) - (XX * XXX)) + XX * ((X * XXY) - (XX * XY));
            double det2 = n * ((XX * XXY) - (XXX * XY)) - X * ((X * XXY) - (XX * XY)) + Y * ((X * XXX) - (XX * XX));

            //Console.WriteLine("det = " + det);
            //Console.WriteLine("det1 = " + det0);
            //Console.WriteLine("det2 = " + det1);
            //Console.WriteLine("det3 = " + det2);

            double[] a = new double[3];
            a[0] = det0 / det;
            a[1] = det1 / det;
            a[2] = det2 / det;

            return a;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //data setting
            const int ndata = 6;
            double[] xw = new double[ndata] { 1, 2, 3, 4, 5, 6 };
            double[] yw = new double[ndata] { 2.1, 7.7, 13.6, 27.2, 40.9, 61.1 };

            //좌표계 그리기
            Graphics grp = pictureBox1.CreateGraphics();
            grp.DrawLine(new Pen(Color.Black), x_pixel(x_min), y_pixel(0), x_pixel(x_max), y_pixel(0));
            grp.DrawLine(new Pen(Color.Black), x_pixel(0), y_pixel(y_min), x_pixel(0), y_pixel(y_max));

            //데이터 그리기
            for(int i =0; i<ndata; i++)
            {
                grp.DrawEllipse(new Pen(Color.Red), x_pixel(xw[i]), y_pixel(yw[i]), 2, 2);
            }

            double a0 = A_calculator(ndata, xw, yw)[0];
            double a1 = A_calculator(ndata, xw, yw)[1];
            double a2 = A_calculator(ndata, xw, yw)[2];

            double n = 90;
            double resolution = (x_max - x_min) / n;

            for (int i=0; i < n; i++)
            {
                double x0 = x_min + (resolution * i); 
                double x1 = x_min + (resolution * (i+1));
                double y0 = a0 + a1 * x0 + a2 * x0 * x0;
                double y1 = a0 + a1 * x1 + a2 * x1 * x1;
                grp.DrawLine(new Pen(Color.Blue), x_pixel(x0), y_pixel(y0), x_pixel(x1), y_pixel(y1));
            }
        }
    }
}
