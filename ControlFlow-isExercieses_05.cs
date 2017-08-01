/*
link :https://www.udemy.com/csharp-tutorial-for-beginners/learn/v4/t/lecture/2910704?start=0
Exercises
Section 5, Lecture 48

description:
5- Write a program and ask the user to enter a series of numbers separated by comma. 
Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", 
the program should display 8.
by Blazej BOCZEK

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlFlow_isExercieses_05
{
    class Program
    {
        public static void myMax()
        {
            Console.WriteLine("Enter a series of numbers sepeared by coma: ");
            var inputs = Console.ReadLine();
            var numbers = inputs.Split(',');

            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
      
            }
            Console.WriteLine("max is " +max);

        }
        static void Main(string[] args)
        {
            myMax();
            Console.ReadKey();

        }
    }
}
