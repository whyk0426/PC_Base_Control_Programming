using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;   //File 클래스를 사용하려면

namespace Korea
{
    public partial class Form1 : Form
    {
        double xmin = 0;
        double xmax = 350;
        double ymin = 350;
        double ymax = 0;

        private float xpixel(double xw)
        {
            return (float)(picDraw.ClientSize.Width *
                              (xw - xmin) / (xmax - xmin));
        }

        private float ypixel(double yw)
        {
            return (float)(picDraw.ClientSize.Height *
                              (1 - (yw - ymin) / (ymax - ymin)));
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            //파일 이름 얻기
            DialogResult rtn = openFileDialog1.ShowDialog(); //F9 -> F10
            if (rtn != DialogResult.OK) 
                return;
            string fname = openFileDialog1.FileName;
            lblFileName.Text = fname;

            // 파일 읽어 내용 배열에 담기
            try
            {
                string[] stAll = File.ReadAllLines(fname);
                int cnt = int.Parse(stAll[0]);

                int[] xp = new int[cnt];
                int[] yp = new int[cnt];

                for (int i=0;i<cnt; i++)
                {
                    string[] word = stAll[i + 1].Split(',');
                    xp[i] = int.Parse(word[0].Trim());
                    yp[i] = int.Parse(word[1].Trim());
                }

                //그리기
                Graphics grp = picDraw.CreateGraphics();
                for (int i=0; i<cnt; i++)
                {
                    grp.DrawLine(new Pen(Color.Black), xpixel(xp[i - 1]), ypixel(yp[i - 1]), xpixel(xp[i]), ypixel(yp[i]));
                }
            }
            catch
            {
                return;
            }
        }
    }
}
