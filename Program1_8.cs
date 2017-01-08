using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1L8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------PRIMER---------------------------");

            Console.WriteLine("Stroki: ");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Stolbcy: ");
            int m=int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; ++i, Console.WriteLine())
            {
                for (int j = 1; j <= m; ++j)
                {
                    Console.Write(" " + j);
                }
            }

            Console.WriteLine("\n---------------------------#1.2---------------------------\n");

            for (int i = 1; i <= 4; ++i, Console.WriteLine())
            {
                for (int j = 1; j <= 10; ++j)
                {
                    Console.Write(" " + j);
                }
            }
            
            Console.WriteLine("\n---------------------------#1.3---------------------------\n");

            for (int i = 1; i <= 5; ++i, Console.WriteLine())
            {
                for (int j = -10; j <= 12; ++j)
                {
                    Console.Write(" " + j);
                }
            }
            
            Console.WriteLine("\n---------------------------#1.4---------------------------\n");
            
            int a = 41;
            for (int i = 1; i <= 4; ++i, Console.WriteLine())
            {
                for (int j = 1; j <= 10; ++j)
                {
                    Console.Write(" " + a);
                    a = a + 1;
                }
            }

            Console.WriteLine("\n---------------------------#1.5---------------------------\n");
            
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 0 + i; j++)
                {
                    Console.Write(" " + 5);
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("\n---------------------------#1.6---------------------------\n");
            
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j <= 5 - i; j++)
                {
                    Console.Write(" " + 1);
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("\n---------------------------#1.7---------------------------\n");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 0 + i; j++)
                {
                    Console.Write(" " + i);
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("\n---------------------------#1.11---------------------------\n");

            
           for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 0 + i; j++)
                {
                    Console.Write(" " + j);
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("\n---------------------------#2---------------------------\n");

            Console.Write("Razmer doski = ");
            int razmerPolya = int.Parse(Console.ReadLine());
            if ((razmerPolya * razmerPolya) % 2 != 0)
            {
                Console.WriteLine("black: " + ((razmerPolya * razmerPolya) / 2 + 1));
            }
            else
            {
                Console.WriteLine("black: " + ((razmerPolya * razmerPolya) / 2));
            }

            Console.Write("Enter the number of cell:\nK = ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("L = ");
            int l = int.Parse(Console.ReadLine());
            if ((n*n)%2==0)
            {
                Console.WriteLine("Back!");
            }
            else
            {
                Console.WriteLine("White!");
            }

            Console.Write("Enter the coordinates of first cell:\nK1 = ");
            int k1 = int.Parse(Console.ReadLine());
            Console.Write("L2 = ");
            int l1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the coordinates of second cell:\nK1 = ");
            int k2 = int.Parse(Console.ReadLine());
            Console.Write("L2 = ");
            int l2 = int.Parse(Console.ReadLine());
            if ((((k1 + l1) % 2 == 0) && ((k2 + l2 ) % 2 == 0)) || (((k1 + l1) % 2 != 0) && ((k2 + l2) % 2 != 0)))
            {
                Console.WriteLine("Same!");
            }
            else
            {
                Console.WriteLine("Different!");
            }

            Console.WriteLine("\n---------------------------#3---------------------------\n");

            Console.Write("day: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Your date: {0:##}.{1:##}.{2:####}", day, month, year);
            Console.WriteLine("1 - skolko proshlo\n2 - skolko ostalos\n3 - yesterday\n4 - tomorrow");
            int q = int.Parse(Console.ReadLine());
            int fullYear = 365;
            switch (q)
            {
                case 1: Console.WriteLine("proshlo {0} dnej", day + month * 30); break;
                case 2: Console.WriteLine("ostalos {0} dnej", fullYear - (day + month * 30)); break;
                case 3: Console.WriteLine("vchera bylo {0:##}.{1:##}.{2:####}", day - 1, month, year); break;
                case 4: Console.WriteLine("zavtra budet {0:##}.{1:##}.{2:####}", day + 1, month, year); break;
            }

        }
    }

}