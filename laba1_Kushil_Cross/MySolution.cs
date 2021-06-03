using System;

namespace MyLib
{
    public class MySolution
    {
        public static double fac(double i)
        {
            if (i == 0)
            {
                return 1;
            }
            else
            {
                return i * fac(i - 1);
            }
        }
        public static double sum_row(double x, double n)
        {
            double res = 1;
            for(int i = 1; i <= n; i++)
            {
                res = res + Math.Pow(x, i * 2) / fac(i * 2);
            }
            return res;
            

        }
        public static double func_ch(double x)
        {
            double ch;
            ch = (Math.Pow(Math.E, x) + Math.Pow(Math.E, (-x))) / 2;
            return ch;

        }
        public static double Perimeter(double side)
        {
            double per;
            per = 4 * side;
            return per;
        }
        public static double Sum(double x, double n)
        {
            double S = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    S = 1;
                }
                S = S + (Math.Pow(x * Math.Log(x, Math.E), i) / fac(i));
            }
            return S;
        }
        public static double Func_t(double x, double n)
        {
            double t;
            t = Math.Abs(sum_row(x, n) - func_ch(x)) / func_ch(x) * 100;
            return t;
        }
        
      
    }
}
