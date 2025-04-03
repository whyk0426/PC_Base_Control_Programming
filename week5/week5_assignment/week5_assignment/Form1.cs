using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week5_assignment
{
    public partial class Form1: Form
    {
        const int nPoint = 50000;
        Random rnd = new Random();


        public Form1()
        {
            InitializeComponent();
        }
        private double area_calculator(int[] p1, int[] p2, int[] p3)
        {
            double area = 0.5 * ((p1[0] * p2[1] + p2[0] * p3[1] + p3[0] * p1[1]) - (p1[0] * p3[1] + p3[0] * p2[1] + p2[0] * p1[1]));
            return area;
        }
        private bool INorOUT(int[] p0, int[] p1, int[] p2, int[] p3)
        {
            double s1 = area_calculator(p0, p1, p2);
            double s2 = area_calculator(p0, p2, p3);
            double s3 = area_calculator(p0, p3, p1);

            if (((s1 > 0) && (s2 > 0) && (s3 > 0)) || ((s1 < 0) && (s2 < 0) && (s3 < 0)))
                return true;
            else
                return false;
        }
        private void button_start_Click(object sender, EventArgs e)
        {
            int[] p1 = new int[2] {160, 70};
            int[] p2 = new int[2] {50, 410};
            int[] p3 = new int[2] {340, 290};

            // 실제 비율 얻기
            int width = pictureBox.ClientSize.Width;
            int height = pictureBox.ClientSize.Height;
            double area_full = width * height;

            double area_triangle = area_calculator(p1, p2, p3);

            // 랜덤점 발생
            Graphics grp = pictureBox.CreateGraphics();
            int nIn = 0, nOut = 0;
            for (int i =0; i < nPoint; i++)
            {
                int[] p0 = new int[2] { rnd.Next(width), rnd.Next(height) };

                if (INorOUT(p0, p1, p2, p3))
                {
                    nIn++;
                    grp.DrawEllipse(new Pen(Color.Black), p0[0], p0[1], 1, 1);
                }
                else
                {
                    nOut++;
                    grp.DrawEllipse(new Pen(Color.Silver), p0[0], p0[1], 1, 1);
                }
            }
            // 결과 출력
            label_RealRatio.Text = Convert.ToString(area_triangle / area_full);
            label_IN.Text = Convert.ToString(nIn);
            label_OUT.Text = Convert.ToString(nOut);
            label_MonteRatio.Text = Convert.ToString((double)nIn / (double)nPoint);
        }
    }
}
