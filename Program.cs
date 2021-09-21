using System;


namespace DzSkiba_1
{
    class Program
    {
        static void Main(string[] args)
        {


            double e = 0.001;

            double x1;
            double x2;

            double f_prop = (1 + Math.Sqrt(5)) / 2;

            double a = -2;
            double b = 2;
           
            

            while (Math.Abs(b - a) > e)
            {
                x1 = b - ((b - a) / f_prop);
                x2 = a + ((b - a) / f_prop);

                if (Y(x1) <= Y(x2))
                {
                    a = x1;
                }
                else
                {
                    b = x2;
                }
            }

            System.Console.Write("Max: ");
            System.Console.WriteLine((a + b) / 2);
            a = -2;
            b = 2;

            while (Math.Abs(b - a) > e)
            {
                x1 = b - ((b - a) / f_prop);
                x2 = a + ((b - a) / f_prop);

                if (Y(x1) >= Y(x2))
                {
                    a = x1;
                }
                else
                {
                    b = x2;
                }
            }


            System.Console.Write("Min: ");
            System.Console.Write((a+b) / 2);

        }
        static double Y(double x)
        {
            return x * x;
        }
    }
}
