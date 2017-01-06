using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1L5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------#1--------------\a");
            
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);

            Console.WriteLine("--------------#2--------------\a");

            Console.Write("q = ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("w = ");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {1} + {0}", q, w, q + w);

            Console.WriteLine("--------------#3--------------\a");

            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("a = ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, a + b + c);

            Console.WriteLine("--------------#4--------------\a");

            Console.Write("s = ");
            double s = double.Parse(Console.ReadLine());
            Console.Write("z = ");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} * {1} = {2}", s, z, s * z);

            Console.WriteLine("--------------#5--------------\a");

            Console.Write("e = ");
            double e = double.Parse(Console.ReadLine());
            Console.Write("r = ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:.###} : {1:.###} = {2:.###}", e, r, e / r);

            Console.WriteLine("--------------#6--------------\a");

            Console.Write("t = ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("i = ");
            double i = double.Parse(Console.ReadLine());
            Console.Write("u = ");
            double u = double.Parse(Console.ReadLine());
            Console.WriteLine("({0} + {1}) + {2} = {0} + ({1} + {2})", t, i, u, t, i, u);

            Console.WriteLine("--------------#7--------------\a");

            Console.WriteLine("C format: {0:C}", 99989.987);
            Console.WriteLine("D9 format: {0:D9}", 99999);
            Console.WriteLine("E format: {0:E}", .31415926538 * 10);
            Console.WriteLine("F format: {0:F3}", 55555.6666);
            Console.WriteLine("N format: {0:N}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);
            Console.Write("\n\n");

            Console.WriteLine("--------------#8--------------\a");
            
            Console.WriteLine("12 -> {0:X}", 12);
            Console.WriteLine("256 -> {0:X}", 256);
            Console.WriteLine("1001 -> {0:X}", 1001);
            Console.WriteLine("12345679 -> {0:X}", 123456789);

            Console.WriteLine("--------------#9--------------\a");

            Console.WriteLine("Онажды в студёную зимнюю пору\nя из лесу вышел.\nБыл сильный мороз...\n\t\t\tА.С.Пушкин\a");
        }
    }
}
