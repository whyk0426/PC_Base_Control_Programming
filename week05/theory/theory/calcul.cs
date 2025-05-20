using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theory
{
    internal class calcul
    {
        public static void Divide (int a, int b, out int quo, out int remain)
        {
            quo = a / b;
            remain = a & b;
        }

        public static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
    }
}
