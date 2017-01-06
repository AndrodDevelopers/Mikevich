using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1L6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------№1.2------------------------------");

            Console.Write("b = ");
            //double a = 2;
            double b = double.Parse(Console.ReadLine());
            double z1 = Math.Sqrt(2 * b + 2 * Math.Sqrt(Math.Pow(b, 2) - 4)) / (Math.Sqrt(Math.Pow(b, 2) - 4) + b + 2);
            double z2 = 1 / Math.Sqrt(b + 2);
            Console.WriteLine("z1 = {0}", z1);
            Console.WriteLine("z2 = {0}", z2);
            Console.WriteLine();

            Console.WriteLine("------------------------------№3------------------------------");

            Console.Write("x=");
            float x = float.Parse(Console.ReadLine());
            Console.Write("y=");
            float y = float.Parse(Console.ReadLine());
            if (x * x + y * y < 9 && y > 0)
                Console.WriteLine("внутри");
            else if (x * x + y * y > 9 || y < 0)
                Console.WriteLine("вне");
            else Console.WriteLine("на границе");

            Console.WriteLine("------------------------------№4.9------------------------------");
            
            Console.Write("Vvedite vozrast: ");
            int n = int.Parse(Console.ReadLine());
            if ((n <= 1) && (n >= 0)) Console.WriteLine("mladenec");
            else if ((n > 1) && (n <= 10)) Console.WriteLine("schenok");
            else if ((n > 10) && (n <= 16)) Console.WriteLine("{0} letnij uebok kakoj-to", n);
            else if ((n > 16) && (n <= 100)) Console.WriteLine("ok da");

        }
    }
}
