/*
ArraysAndListsEx_031
ArraysAndListsExercises
link: https://www.udemy.com/csharp-tutorial-for-beginners/learn/v4/t/lecture/2910726?start=0
Exercises Exercises
Section 6, Lecture 55
description:
3- Write a program and ask the user to enter 5 numbers. 
If a number has been previously entered, display an error message 
and ask the user to re-try. Once the user successfully enters 5 
unique numbers, sort them and display the result on the console.
by Blazej BOCZEK 
@ email- b.boczek89@gmail.com
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraysAndListsEx_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = new List<int>();

            for (var i=0; i < 5; ++i)
            {
                var number = Convert.ToInt32(Console.ReadLine());

                if (numberList.Contains(number))
                {
                    Console.WriteLine("You already enter "+number+ " pls enter another number");
                    continue;
                }
                numberList.Add(number);
            }
            numberList.Sort();
            Console.WriteLine();
            Console.WriteLine("Sort numbers: ");
            foreach (var numb in numberList)
                Console.WriteLine(numb);
            Console.ReadLine();



        }
    }
}
