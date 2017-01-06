using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1L7
{
    class Program
    {
        static void Main(string[] args)
        {
            // while, do while, for
            Console.WriteLine("---------------------------№1.1---------------------------\n");
           
            Console.WriteLine("\nWHILE");
            int q = 60;
            while (q >= 10) {
                Console.WriteLine(" " + q);
                q -= 2;
            }

            Console.WriteLine("\nDO WHILE");
            q = 60;
            do
            {
                Console.WriteLine(" " + q);
                q -= 2;
            }
            while (q >= 10);
            
            Console.WriteLine("\nFOR");
            for (q = 60; q >= 10; q -= 2) {
                Console.WriteLine(" " + q);
            }


            Console.WriteLine("\n---------------------------№1.2---------------------------\n");

            Console.WriteLine("WHILE");
            int n = 25;
            while (n <= 35)
            {
                Console.WriteLine(n + " " + (n + 0.5) + " " + (n - 0.2));
                n++;
            }

            Console.WriteLine("\nDO WHILE");
            int m = 25;
            do
            {
                Console.WriteLine(m + " " + (m + 0.5) + " " + (m - 0.2));
                m++;
            }
            while (m <= 35);
            
            Console.WriteLine("\nFOR");
            for (int i = 25; i <= 35; i++)
            {
                Console.WriteLine(i + " " + (i + 0.5) + " " + (i - 0.2));
            }
            
            Console.WriteLine("\n---------------------------№1.3---------------------------\n");
                
            Console.Write("Vvedite A: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Vvedite B: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("WHILE");
            float p = b;
            while (p >= a)
            {
                Console.Write(Math.Pow(p, 3) + " ");
                p--;
            }

            Console.WriteLine("\nDO WHILE");

            float o = b;
            do
            {
                Console.Write(Math.Pow(o, 3) + " ");
                o--;
            }
            while (o >= a);

            Console.WriteLine("\nFOR");

            for (float l = b; l >= a; l--)
            {
                Console.Write(Math.Pow(l, 3) + " ");
            }

            Console.WriteLine("\n---------------------------№1.4---------------------------\n");
            
            Console.Write("Vvedie A: ");
            float e = float.Parse(Console.ReadLine());
            Console.Write("Vvedite B: ");
            float r = float.Parse(Console.ReadLine());
            Console.Write("Vvedite X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Vvedite Y: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("WHILE");
            float s = e;
            while (s <= r)
            {
                if (s % 10 == x || s % 10 == y)
                {
                    Console.Write(s + " ");
                }
                s++;
            }

            Console.WriteLine("\nDO WHILE");

            float c = e;
            do
            {
                if (c % 10 == x || c % 10 == y)
                {
                    Console.Write(c + " ");
                }
                c++;
            }
            while (c <= r);

            Console.WriteLine("\nFOR");

            for (float z = a; z <= b; z++)
            {
                if (z % 10 == x || z % 10 == y)
                {
                    Console.Write(z + " ");
                }
            }
            
            Console.WriteLine("\n---------------------------№1.5---------------------------\n");

            Console.WriteLine("WHILE");

            int v = 100;
            while (v <= 999)
            {
                if (v % 10 == v / 100)
                {
                    Console.Write(v + " ");
                }
                v++;
            }

            Console.WriteLine("\nDO WHILE");

            int k = 100;
            do
            {
                if (k % 10 == (int)(k / 100))
                {
                    Console.Write(k + " ");
                }
                k++;
            }
            while (k <= 999);

            Console.WriteLine("\nFOR");

            for (int j = 100; j <= 999; j++)
            {
                if (j % 10 == j / 100)
                {
                    Console.Write(j + " ");
                }
            }
        }
    }
}

