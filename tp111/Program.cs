﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
namespace TP1
{
    //E1
    class Program {
        
        static int min(int a, int b) => a < b ? a : b;

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



        private static int AskUserForParameter() {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        static void E1(){
            Multiplication();
        }
        
        //E2

        class NotAPrimeException : Exception{
            public NotAPrimeException() {  }

            public NotAPrimeException(int number) : base(String.Format("{0} is not a prime number.", number)) {}   
        }
        static void printPrimes() {
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

        public static void fibonacci(int num) {

            if(num > 1000 || num < 1){
                Console.WriteLine("Number shouldn't be smaller than 1 or bigger than 1000.");
                return;
            }

            int a = 0, b = 1, c = 0;  
            for (int i = 2; i <= num; i++) {  
                c = a + b;  
                a = b;  
                b = c;  
            }  
            Console.Write("F({0}) = {1}", num, c);  
        }

        public static int factorial(int num){
            return num > 1 ? num * factorial(num - 1) : 1;
            // If the number is too high(420,000 for example), it will result in Stack Overflow. The program will try to use more memory than there is available.

            // A recursive function is a function that calls itself, like this one. It does, however, need an exit condition whithout which the program would enter an infinite loop.
        }

        private static int PowerFunction(int x) {
            return (int)(Math.Pow(x, 2) - 4);
        }


        static void E2(){
            // printPrimes();
            // fibonacci(30);
            // Console.WriteLine(factorial(10));
        }

        static void E3(){
            for (int i = -3; i <= 3; i++) {
                Console.Write("{0}:", i);
                try { 
                    int powerResult = PowerFunction(i);
                    float result = 10 / powerResult;
                    Console.Write("PowerFunction of {0} is {1}.\n", i, powerResult);
                    Console.Write("Result:10/{0} = {1}\n\n\n", powerResult, result);
                } catch (System.Exception e) {
                    Console.Write("Exception caught: {0}\n\n\n", e.Message);
                }
            }
        }


        static void E4(){
            Console.WriteLine("Please enter two numbers separated by a space and press enter :");
            string[] result = Console.ReadLine().Split(" ");
            int.TryParse(result[0], out var m);
            int.TryParse(result[1], out var n);
            for (int i = 0; i <= m; i++) {
                for (int j = 0; j <= n; j++) {

                    if((i == 0 && j == 0) || (i == 0 && j == n) || (i == m && j == 0) || (i == m && j == n)){
                        Console.Write("0");
                        continue;
                    }

                    if(i == 0 || i == m){
                        Console.Write("_");
                        continue;
                    }
                    if(j == 0 || j == n){
                        Console.Write("|");
                        continue;
                    }
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
        }
        static void E4_corrected(){
            Console.WriteLine("Please enter two numbers separated by a space and press enter :");
            string[] result = Console.ReadLine().Split(" ");
            int.TryParse(result[0], out var m);
            int.TryParse(result[1], out var n);
            for (int i = 0; i <= m; i++) {
                for (int j = 0; j <= n; j++) {

                    if((i == 0 && j == 0) || (i == 0 && j == n) || (i == m && j == 0) || (i == m && j == n)){
                        Console.Write("0");
                        continue;
                    }

                    if(i == 0 || i == m){
                        Console.Write("__");
                        continue;
                    }
                    if(j == 0 || j == n){
                        Console.Write("|");
                        continue;
                    }
                    Console.Write("  ");
                }
                Console.Write("\n");
            }
        }

        static void E5(){
            string jsonFilePath = "DOGE_AllDataPoints_3Days.json";
            string json = File.ReadAllText(jsonFilePath);
            var values = JsonSerializer.Deserialize<Dictionary<string,object> >(json);
            
            foreach(KeyValuePair<string, object> kvp in values) {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }
        //
        static void Main(string[] args) {
            // E1();
            // E1();
            // E1();
            // E1();
            E1();
        }
    }
}
