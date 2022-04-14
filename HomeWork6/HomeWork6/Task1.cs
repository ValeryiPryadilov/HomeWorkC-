using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    public delegate double Fun(double x, double y);
    class Task1
    {

        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x , b));
                x += 1; 
            }
            Console.WriteLine("---------------------");
        }

        public static double Ax2 (double a, double x)
        {
            Console.Write($"{a} - {x}");
            return a * Math.Pow(x, 2);
        }

        public static double SinX (double a, double x)
        {
            Console.Write($"{a} - {x}");
            return a * Math.Sin(x);
        }



        
        
        
        static void Main()
        {

            Fun fun = Ax2;
            

            Table(Ax2, -2, 2);

            Table(SinX, -2, 2);
            Console.ReadLine();
        }
        
    }
}
