using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Tmath
    {
        public static void Normalize(double[] vec, double[] uvec)
        {
            double mag = Math.Sqrt((vec[0] * vec[0] + vec[1] * vec[1] + vec[2] * vec[2]));

            uvec[0] = vec[0] / mag;
            uvec[1] = vec[1] / mag;
            uvec[2] = vec[2] / mag;
        }

        public static void Normalize(double[] vec, out double[] uvec)
        {
            double mag = Math.Sqrt((vec[0] * vec[0] + vec[1] * vec[1] + vec[2] * vec[2]));
            uvec = new double[3];
            uvec[0] = vec[0] / mag;
            uvec[1] = vec[1] / mag;
            uvec[2] = vec[2] / mag;
        }

             ////아니면 double 형으로 return 가능
    }
}
