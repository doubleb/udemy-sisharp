/*
link :https://www.udemy.com/csharp-tutorial-for-beginners/learn/v4/t/lecture/2910704?start=0
Exercises
Section 5, Lecture 48

description:
2- Write a program and continuously ask the user to enter 
a number or "ok" to exit. Calculate the sum of all the previously 
entered numbers and display it on the console.
by Blazej BOCZEK

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlFlow_isExercieses_02
{
    class Program
    {
        public static void enterNumber()
        {
            var sum = 0;
            while (true)
            {
                
                Console.Write("enter number or type 'ok' to exit: " );
                var numeros = Console.ReadLine();
                if (numeros.ToLower() == "ok"||String.IsNullOrWhiteSpace(numeros))
                    break;
                sum += Convert.ToInt32(numeros);              
               
            }

            Console.WriteLine("The sum of all numbers is "+sum);
        }
        static void Main(string[] args)
        {
            enterNumber();
            Console.ReadKey();
        }
    }
}
