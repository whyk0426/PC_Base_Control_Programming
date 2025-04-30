﻿using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public class TCanvas
    {
        private PictureBox picbox = null;
        private Bitmap bitmap = null;
        private Graphics graphics = null;

        private double xmin, xmax, ymin, ymax;  // 논리좌표 최소,최대

        // 논리좌표를 pixel좌표로
        public float xpixelpos(double xpos)
        {
            return Convert.ToSingle(picbox.ClientSize.Width / (xmax - xmin) * (xpos - xmin));
        }
        public float ypixelpos(double ypos)
        {
            return Convert.ToSingle(-picbox.ClientSize.Height / (ymax - ymin) * (ypos - ymin) + picbox.ClientSize.Height);
        }
        public float xpixelsize(double xsize)
        {
            return Convert.ToSingle(picbox.ClientSize.Width * xsize / (xmax - xmin));
        }
        public float ypixelsize(double ysize)
        {
            return Convert.ToSingle(picbox.ClientSize.Height * ysize / (ymax - ymin));
        }

        // pixel좌표를 논리좌표로
        public double xposD(float xpixel)
        {
            return Convert.ToDouble((xmax - xmin) / picbox.ClientSize.Width * xpixel + xmin);
        }
        public double yposD(float ypixel)
        {
            return Convert.ToDouble((ymax - ymin) / (-picbox.ClientSize.Height) * (ypixel - picbox.ClientSize.Height) + ymin);
        }
        public double xsizeD(float xpixelsize)
        {
            return Convert.ToDouble(xpixelsize / picbox.ClientSize.Width * (xmax - xmin));
        }
        public double ysizeD(float ypixelsize)
        {
            return Convert.ToDouble(ypixelsize / picbox.ClientSize.Height * (ymax - ymin));
        }

        //--------------------------------------------------------------
        // 생성자
        //--------------------------------------------------------------
        public TCanvas(PictureBox picbox, double xmin, double xmax, double ymin, double ymax)
        {
            this.picbox = picbox;

            this.xmin = xmin;
            this.xmax = xmax;
            this.ymin = ymin;
            this.ymax = ymax;

            // 그림의 크기 계산
            int npixelx = picbox.ClientSize.Width;
            int npixely = picbox.ClientSize.Height;

            // Bitmap 객체생성
            this.bitmap = new Bitmap(npixelx, npixely, PixelFormat.Format24bppRgb);

            // Graphics 개체생성
            if (this.graphics != null) this.graphics.Dispose(); //(꼭 필요는 없음)

            this.graphics = Graphics.FromImage(this.bitmap);
            this.graphics.Clear(Color.White);

            // 속성확인 (꼭 필요는 없음)
            this.graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            this.graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //antialliasing을 줄 수도있지만 그냥 선명하게 그릴게 (None)

            // 단위맞춤 (꼭 필요는 없음)
            this.graphics.PageUnit = GraphicsUnit.Pixel;

            //TCanvas.picbox.Image = TCanvas.bitmap;
        }

        //--------------------------------------------------------------
        // public 메소드들
        //--------------------------------------------------------------
        public void ClearDrawing(Color col)
        {
            this.graphics.Clear(col);
            this.picbox.Image = this.bitmap;
        }
        public void DrawLine(Color col, double x0, double y0, double x1, double y1)
        {
            float xp0 = xpixelpos(x0); float yp0 = ypixelpos(y0);
            float xp1 = xpixelpos(x1); float yp1 = ypixelpos(y1);

            graphics.DrawLine(new Pen(col), xp0, yp0, xp1, yp1);
            this.picbox.Image = this.bitmap;
        }
        public void DrawLine(Color col, int width, double x0, double y0, double x1, double y1)
        {
            float xp0 = xpixelpos(x0); float yp0 = ypixelpos(y0);
            float xp1 = xpixelpos(x1); float yp1 = ypixelpos(y1);

            Pen pen = new Pen(col);
            pen.Width = width;

            graphics.DrawLine(pen, xp0, yp0, xp1, yp1);
            this.picbox.Image = this.bitmap;
        }
        public void DrawFilledPolygon(Color col, int npt, double[] xps, double[] yps)
        {
            PointF[] pts = new PointF[npt];
            for (int i = 0; i < npt; i++)
            {
                pts[i].X = xpixelpos(xps[i]);
                pts[i].Y = ypixelpos(yps[i]);
            }

            SolidBrush brush = new SolidBrush(col);
            graphics.FillPolygon(brush, pts);

            graphics.DrawPolygon(new Pen(col), pts);
            this.picbox.Image = this.bitmap;
        }
        public void DrawEllipse(Color col, double cenx, double ceny, double width, double height)
        {
            float xp = xpixelpos(cenx - width / 2);
            float yp = ypixelpos(ceny + height / 2);
            float wd = xpixelsize(width);
            float ht = ypixelsize(height);

            graphics.DrawEllipse(new Pen(col), xp, yp, wd, ht);
            this.picbox.Image = this.bitmap;
        }
        public void DrawString(string st, double emSize, double x0, double y0)
        {
            float xp0 = xpixelpos(x0); float yp0 = ypixelpos(y0);

            Font font = new Font("verdana", (float)emSize);
            graphics.DrawString(st, font, Brushes.Black, xp0, yp0);
            this.picbox.Image = this.bitmap;
        }
    } // end of Class
}
