/*
ArraysAndListsEx_02
ArraysAndListsExercises

link: https://www.udemy.com/csharp-tutorial-for-beginners/learn/v4/t/lecture/2910726?start=0
Exercises Exercises
Section 6, Lecture 55
description:

2- Write a program and ask the user to enter their name. Use an array to reverse the name and
then store the result in a new string. Display the reversed name on the console.

by Blazej BOCZEK 
@ email- b.boczek89@gmail.com
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraysAndListsEx_02
{
    class Program
    {


        public static void myRead()
        {
            Console.WriteLine("Enter your name");
            var name = Console.ReadLine();
            var arr1 = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                arr1[name.Length - i] = name[i - 1];
            Console.Write("Your name revesed: ");
            Console.WriteLine(arr1);
        }

        static void Main(string[] args)
        {
            myRead();
            Console.ReadKey();
            


        }
    }
}
