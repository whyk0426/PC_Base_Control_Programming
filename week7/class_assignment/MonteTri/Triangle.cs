using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace MonteTri
{
    class Triangle
    {
        public double x1, y1, x2, y2, x3, y3;

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            // ..... 채울곳
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
        }

        public double AreaSigned()
        {
            // ..... 채울곳
            double area_assigned = (x1 * y2 + x2 * y3 + x3 * y1) - (x1 * y3 + x3 * y2 + x2 * y1);
            area_assigned /= 2.0;

            return area_assigned;
        }

        public bool IsPointInside(double xp, double yp)
        {
            // ..... 채울곳
            Triangle triangle1 = new Triangle(xp, yp, x1, y1, x2, y2);
            Triangle triangle2 = new Triangle(xp, yp, x2, y2, x3, y3);
            Triangle triangle3 = new Triangle(xp, yp, x3, y3, x1, y1);

            double area1 = triangle1.AreaSigned();
            double area2 = triangle2.AreaSigned();
            double area3 = triangle3.AreaSigned();

            bool is_inside = (area1 >= 0 && area2 >= 0 && area3 >= 0) || (area1 <= 0 && area2 <= 0 && area3 <= 0);

            return is_inside;
        }

        public void Draw(PictureBox pic, Color col, double xp, double yp)
        {
            // ..... 채울곳
            Graphics grp = pic.CreateGraphics();
            grp.DrawEllipse(new Pen(col), (float)xp, (float)yp, 1, 1);
        }
    }
}
