using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace TP1

{
    class Program1
    {


        public static int Puissance(int x)
        { return (int)(Math.Pow(x, 2) - 4); }

        static int Fibonacci(int nbrseries, int N)
        {
            int a = 1;
            for (int i = 0; i <= nbrseries; i++)
            {
                int temp = a;
                a = N;
                N = temp + a;
            }
            return a;
        }

        static void Prime()
        {
            Console.WriteLine("\nPrime from 1 and 1000 : ");
            for (int i = 2; i <= 1000; i++)
            {
                bool Prime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        Prime = false;
                        break;
                    }
                }
                if (Prime == true)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("\n --------------------------------- \n");
        }

        static int Factorial(int Facto)
        {
            if (Facto == 0) return 1;
            return Facto * Factorial(Facto - 1);
        }

        static void Multiplication()
        {
            Console.WriteLine("Table of ?:");
            int N = Convert.ToInt32(Console.ReadLine());
            while (N > 1000)
            {
                Console.WriteLine("Table of ?:");
                N = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Table of {0}", N);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}*{1}={2}", i, N, i * N);
            }


    }
}
}