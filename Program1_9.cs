using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1L9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter X: ");
            double x = int.Parse(Console.ReadLine());
            Console.Write("Enter Y: ");
            double y = int.Parse(Console.ReadLine());
            double z = min(3 * x, 2 * y) + min(x - y, x + y);
            Console.WriteLine("Min = " + z);
            
            /////////// 1.1//////////
            Console.WriteLine("---------#1.1---------");
            Console.Write("Enter X: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Y: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Z: ");
            int z1=int.Parse(Console.ReadLine());
            Console.Write("Enter V: ");
            int v1=int.Parse(Console.ReadLine());
            int minxy = minOfTwo(x1, y1);
            int minzv = minOfTwo(z1, v1);
            Console.WriteLine("Min of XY : {0}; Min of ZV : {1}", minxy, minzv);
             
            /////////// 1.2//////////
            Console.WriteLine("---------#1.2---------");
            Console.Write("Enter X: ");
            double x2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Y: ");
            double y2 = int.Parse(Console.ReadLine());
            double z2 = max(x, 2 * y - x) + max(5 * x + 3 * y, y);
            Console.WriteLine("Max = " + z2);
            
            //////////// 1.3//////////
            Console.WriteLine("---------#1.3---------");
            Console.Write("f(x)=x^3-sinx\nEnter A : ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("Enter B : ");
            double x4 = double.Parse(Console.ReadLine());
            double y3 = maxOfAAndB(x3);
            double y4 = maxOfAAndB(x4);
            if (y3 > y4)
            {
                Console.WriteLine("Max in A");
            }
            else
            {
                Console.WriteLine("Max in B");
            }

            ///////////// 1.4//////////
            Console.WriteLine("---------#1.4---------");
            Console.Write("f(x)=cos(2x)+sin(x-3)\nEnter A : ");
            double a4 = getNumberFromKeyboard();
            Console.Write("Enter B : ");
            double b4 = getNumberFromKeyboard();
            double y5 = function4(a4);
            double y6 = function4(b4);
            Console.WriteLine(bolsheMenshe(y5, y6));

            ///////////// 2.2///////////
            Console.WriteLine("---------#2.2---------");
            Console.Write("A=");
            double a = getNumberFromKeyboard();
            Console.Write("B=");
            double b = getNumberFromKeyboard();
            Console.Write("h=");
            double h = getNumberFromKeyboard();
            for (double i = a; i <= b; i += h)
            Console.WriteLine("f({0:f4})={1:f8}", i, f(i));
            
        }

        static double f(double x)
        {
            double y;
            if (Math.Abs(x) < 3)
            {
                y = Math.Sin(x);
            }
            else if (x< 9)
            {
                y = (Math.Sqrt(Math.Pow(x, 2) + 1)) / (Math.Sqrt(Math.Pow(x, 2) + 5));
            }
            else
            {
                y = Math.Sqrt(Math.Pow(x, 2) + 1) - Math.Sqrt(Math.Pow(x, 2) + 5);
            }
            return y;
        }


        static string bolsheMenshe(double a, double b)
        {
            string result;
            if (a > b)
            {
                result = "Max in A";
            }
            else
            {
                result = "Max in B";
            }
            return result;
        }

        static double function4(double a)
        {
            return Math.Cos(2 * a) + Math.Sin(a - 3);
        }

        static double getNumberFromKeyboard()
        {
            return double.Parse(Console.ReadLine());
        }

        static double maxOfAAndB(double a)
        {
            double c = Math.Pow(a, 3) - Math.Sin(a);
            return c;
        }

        static double max(double a1, double b1)
        {
            return (a1 > b1) ? a1 : b1;
        }

        static int minOfTwo(int a, int b)
        {
            return (a < b) ? a : b;
        }

        static double min(double a, double b)
        {
            return (a < b) ? a : b;
            /*
            double c;
            if (a < b)
            {
                c = a;
            }
            else
            {
                c = b;
            }
            return c;
             */

        }
    }
}
