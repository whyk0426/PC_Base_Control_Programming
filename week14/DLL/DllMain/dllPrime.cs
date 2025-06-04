using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

static class dllPrime
{
    [DllImport("PrimeCPP.dll",
                         CallingConvention = CallingConvention.Cdecl)]
    public static extern void dllFindNumberOfPrimeNumber(int nMax, ref int nprime);
}