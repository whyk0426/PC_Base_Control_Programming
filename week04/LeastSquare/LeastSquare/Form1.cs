using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LeastSquare
{
    public partial class Form1 : Form
    {
        double x_min = -5, x_max = 20;
        double y_min = -5, y_max = 20;

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
        public Form1()
        {
            InitializeComponent();
        }
        private double[] A_calculator(int n, double[] x, double[] y)
        {
            double sumXY = 0, sumX = 0, sumY = 0, sumXX = 0;
            for (int i = 0; i < n; i++)
            {
                sumXY += x[i] * y[i];
                sumX += x[i];
                sumY += y[i];
                sumXX += x[i] * x[i];

            }
            double a = (n * sumXY - sumX * sumY) / (n * sumXX - sumX * sumX);
            double b = (sumY - a * sumX) / n;

            double[] ab = new double[2];
            ab[0] = a;
            ab[1] = b;
            return ab;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //data setting
            //const int ndata = 10;
            //double[] xw = new double[ndata] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //double[] yw = new double[ndata] { 1.3, 3.5, 4.2, 5.0, 7.0, 8.8, 10.1, 12.5, 13.0, 15.6 };

            //좌표계 그리기
            Graphics grp = pictureBox1.CreateGraphics();
            grp.DrawLine(new Pen(Color.Black), x_pixel(x_min), y_pixel(0), x_pixel(x_max), y_pixel(0));
            grp.DrawLine(new Pen(Color.Black), x_pixel(0), y_pixel(y_min), x_pixel(0), y_pixel(y_max));

            const int ndata = 10;
            //데이터 그리기
            double[] xw = new double[ndata] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] yw = new double[ndata] { 1.3, 3.5, 4.2, 5.0, 7.0, 8.8, 10.1, 12.5, 13.0, 15.6 };

            
            for (int i=0; i < ndata; i++)
            {
                grp.DrawEllipse(new Pen(Color.Red), x_pixel(xw[i]), y_pixel(yw[i]), 2, 2);
            }

            //y = a*x + n : a, b 구하기
            //double sumXY = 0, sumX = 0, sumY = 0, sumXX = 0;
            //for(int i =0; i< ndata; i++)
            //{
            //    sumXY += xw[i] * yw[i];
            //    sumX += xw[i];
            //    sumY += yw[i];
            //    sumXX += xw[i] * xw[i];

            //}
            //double a = (ndata * sumXY - sumX * sumY) / (ndata * sumXX - sumX * sumX);
            //double b = (sumY - a * sumX) / ndata;
            double a = A_calculator(ndata, xw, yw)[0];
            double b = A_calculator(ndata, xw, yw)[1];
           

            //직선 그리기
            grp.DrawLine(new Pen(Color.Blue), x_pixel(x_min), y_pixel((a * x_min) + b), x_pixel(x_max), y_pixel(a * x_max + b));
        }
    }
}
