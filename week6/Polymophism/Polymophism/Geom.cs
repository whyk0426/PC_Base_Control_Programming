using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

class Geom
{
    public virtual void Draw(PictureBox pic) { }
    public Color col;
}


class Circle : Geom
{
    private int xcen, ycen, radius;
    public static int num;

    public Circle(int xcen, int ycen, int radius, Color col)
    {
        this.col = col;     // 상속된 속성
        this.xcen = xcen;   // 확장된 속성
        this.ycen = ycen;
        this.radius = radius;
        num++;              // static 멤버
    }

    public override void Draw(PictureBox pic)
    {
        Graphics grp = pic.CreateGraphics();
        grp.DrawEllipse(new Pen(col), xcen, ycen, radius * 2, radius * 2);
    }
}

class Diamond : Geom
{
    private int xcen, ycen, xsize, ysize;
    public static int num;

    public Diamond(int x, int y, int xs, int ys, Color col)
    {
        this.col = col;
        this.xcen = x;
        this.ycen = y;
        this.xsize = xs;
        this.ysize = ys;
        num++;
    }

    public override void Draw(PictureBox pic)
    {
        Graphics grp = pic.CreateGraphics();
        grp.DrawLine(new Pen(col), xcen + xsize / 2, ycen, xcen, ycen + ysize / 2);
        grp.DrawLine(new Pen(col), xcen, ycen + ysize / 2, xcen - xsize / 2, ycen);
        grp.DrawLine(new Pen(col), xcen - xsize / 2, ycen, xcen, ycen - ysize / 2);
        grp.DrawLine(new Pen(col), xcen, ycen - ysize / 2, xcen + xsize / 2, ycen);
    }
}

class Rectangular : Geom
{
    private int xcen, ycen, xsize, ysize;
    public static int num;

    public Rectangular(int x, int y, int xs, int ys, Color col)
    {
        this.col = col;
        this.xcen = x;
        this.ycen = y;
        this.xsize = xs;
        this.ysize = ys;
        num++;
    }
    public override void Draw(PictureBox pic)
    {
        Graphics grp = pic.CreateGraphics();
        grp.DrawLine(new Pen(col), xcen - xsize / 2, ycen - ysize / 2, xcen + xsize / 2, ycen - ysize / 2);
        grp.DrawLine(new Pen(col), xcen + xsize / 2, ycen - ysize / 2, xcen + xsize / 2, ycen + ysize / 2);
        grp.DrawLine(new Pen(col), xcen + xsize / 2, ycen + ysize / 2, xcen - xsize / 2, ycen + ysize / 2);
        grp.DrawLine(new Pen(col), xcen - xsize / 2, ycen + ysize / 2, xcen - xsize / 2, ycen - ysize / 2);
    }
}

class Triangle : Geom
{
    private int xcen, ycen, radius;
    private double rad1, rad2, rad3;
    public static int num;

    public Triangle(int x, int y, int r, int a1, int a2, int a3, Color col)
    {
        this.rad1 = a1 * Math.PI / 180;
        this.rad2 = a2 * Math.PI / 180;
        this.rad3 = a3 * Math.PI / 180;
        this.col = col;
        this.xcen = x;
        this.ycen = y;
        this.radius = r;
        
        num++;
    }
    public override void Draw(PictureBox pic)
    {
        Graphics grp = pic.CreateGraphics();
        grp.DrawLine(new Pen(col), xcen + Convert.ToInt32(radius * Math.Cos(rad1)), ycen + Convert.ToInt32(radius * Math.Sin(rad1)), xcen + Convert.ToInt32(radius * Math.Cos(rad2)), ycen + Convert.ToInt32(radius * Math.Sin(rad2)));
        grp.DrawLine(new Pen(col), xcen + Convert.ToInt32(radius * Math.Cos(rad2)), ycen + Convert.ToInt32(radius * Math.Sin(rad2)), xcen + Convert.ToInt32(radius * Math.Cos(rad3)), ycen + Convert.ToInt32(radius * Math.Sin(rad3)));
        grp.DrawLine(new Pen(col), xcen + Convert.ToInt32(radius * Math.Cos(rad3)), ycen + Convert.ToInt32(radius * Math.Sin(rad3)), xcen + Convert.ToInt32(radius * Math.Cos(rad1)), ycen + Convert.ToInt32(radius * Math.Sin(rad1)));

    }
}