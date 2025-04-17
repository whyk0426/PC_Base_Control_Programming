﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteTri
{
    public partial class Form1 : Form
    {
        const int nPoint = 50000;
        double x1 = 160, y1 = 70;
        double x2 = 50, y2 = 410;
        double x3 = 340, y3 = 290;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle(x1, y1, x2, y2, x3, y3);

            btnStart.Enabled = false;
            Random rnd = new Random();

            // real ratio
            int wd = picDraw.ClientSize.Width;
            int ht = picDraw.ClientSize.Height;
            double area_rect = wd * ht;
            double area_tri = triangle.AreaSigned();
            double ratio_real = Math.Abs(area_tri) / area_rect;

            lblRatioReal.Text = Convert.ToString(ratio_real);

            // Monte Carlo simulation
            int nIN = 0, nOUT = 0;
            for (int i = 0; i < nPoint; i++)
            {
                int xp = rnd.Next(wd);
                int yp = rnd.Next(ht);

                Color col;
                if (triangle.IsPointInside(xp, yp))
                {
                    nIN++;
                    col = Color.Black;
                }
                else
                {
                    nOUT++;
                    col = Color.FromArgb(0xC0, 0xC0, 0xC0);
                }

                triangle.Draw(picDraw, col, xp, yp);
                

                lblNIn.Text = Convert.ToString(nIN);
                lblNTotal.Text = Convert.ToString(nIN + nOUT);
                double ratio_monte = (double)nIN / (double)(nIN + nOUT);
                lblRatioMonte.Text = Convert.ToString(ratio_monte);

                Application.DoEvents();

            }

            btnStart.Enabled = true;
        }
    }
}
