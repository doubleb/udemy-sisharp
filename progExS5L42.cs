/*
Exercises Section 5, Lecture 42
Note: for all these exercises, ignore input validation unless otherwise directed. 
Assume the user enters a value in the format that the program expects.
For example,if the program expects the user to enter a number, don't worry about validating if
the input is a number or not. When testing your program, simply enter a number.
1- Write a program and ask the user to enter a number. The number should be between 1 to 10.
If the user enters a valid number, display "Valid" on the console.
Otherwise, display "Invalid". (This logic is used a lot in applications where values entered
into input boxes need to be validated.)

@by: Blazej Boczek b.boczek89@gmail.com

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlFlowExercises_01
{
    class Program
    {


        public static void ifValid(int number)
        {
            if (1<=number&&number <=10)
                 Console.WriteLine("valid");
                 else
                Console.WriteLine("Invalid");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 to 10");
            Console.Write("x?= ");
            var number = Convert.ToInt32(Console.ReadLine());
            ifValid(number);

            Console.ReadKey();

        }
    }
}
