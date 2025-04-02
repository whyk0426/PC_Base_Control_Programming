using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte
{
    public partial class Form1 : Form
    {
        const int nPoint = 50000;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {

            // 실제 비율 얻기
            int width = picArea.ClientSize.Width;
            int height = picArea.ClientSize.Height;
            int area = width * height;

            label_RatioReal.Text = Convert.ToString((100.0 * 100.0) / (double)area);

            // 랜덤점 발생
            Graphics grp = picArea.CreateGraphics();
            int nIn = 0, nOut = 0;
            for (int i = 0; i < nPoint; i++)
            {
                int xp = rnd.Next(width);  // 0 ~ (width - 1) 중에 발생
                int yp = rnd.Next(height); // 0 ~ (height - 1) 중에 발생

                // 내부, 외부 판단
                if (InRect(100, 100, 199, 199, xp, yp))
                {
                    nIn++;
                    grp.DrawEllipse(new Pen(Color.Black), xp, yp, 1, 1);
                }
                else
                {
                    nOut++;
                    grp.DrawEllipse(new Pen(Color.Silver), xp, yp, 1, 1);
                }
            }

            // 결과 비율 출력
            label_RatioMonte.Text = Convert.ToString((double)nIn / (double)nPoint);

        }
        bool InRect( int xmin, int ymin, int xmax, int ymax, int xp, int yp)
        {
            if (xp < xmin) return false;
            if (xp > xmax) return false;
            if (yp < ymin) return false;
            if (yp > ymax) return false;
            return true;
        }
    }
}
