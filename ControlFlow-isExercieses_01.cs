/*
link :https://www.udemy.com/csharp-tutorial-for-beginners/learn/v4/t/lecture/2910704?start=0
Exercises
Section 5, Lecture 48

description:
1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
Display the count on the console.
by Blazej BOCZEK

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlFlow_isExercieses_01
{
    class Program
    {
        public static void divNoRemainder( int number)
        {
            var counter = 0;
            for (var i = 1; i <= 100; ++i)
            {
                if (i % number == 0)
                    counter += 1;

            }
            Console.WriteLine(counter + " numbers are divisibe by "+number +" with no remainder");
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            var numb = Convert.ToInt32(Console.ReadLine());

            divNoRemainder(numb);
            Console.ReadKey();
        }
    }
}
