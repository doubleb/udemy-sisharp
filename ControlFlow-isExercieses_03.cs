/*
link :https://www.udemy.com/csharp-tutorial-for-beginners/learn/v4/t/lecture/2910704?start=0
Exercises
Section 5, Lecture 48

description:
3- Write a program and ask the user to enter a number. 
Compute the factorial of the number and print it on the console. 
For example, if the user enters 5, the program 
should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
by Blazej BOCZEK

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlFlow_isExercieses_03
{
    class Program
    {
        public static void myFactorial(int factorial)
        {
            var wynik = 1;
            if (factorial==0)
                Console.WriteLine("{0}!={1}", factorial, wynik);
            
            for (var i = 1; i <= factorial; ++i)
                wynik *= i;
            Console.WriteLine("{0}!={1}",factorial,wynik);
        }
        static void Main(string[] args)
        {
            Console.Write("enter the number: ");
            var num = Convert.ToInt32(Console.ReadLine());
            myFactorial(num);

            Console.ReadKey();


        }
    }
}
