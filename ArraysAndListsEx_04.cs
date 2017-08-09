/*
ArraysAndListsEx_031
ArraysAndListsExercises
link: https://www.udemy.com/csharp-tutorial-for-beginners/learn/v4/t/lecture/2910726?start=0
Exercises Exercises
Section 6, Lecture 55
description:
4- Write a program and ask the user to continuously enter a number or type
 "Quit" to exit. The list of numbers may include duplicates. 
 Display the unique numbers that the user has entered.
by Blazej BOCZEK 
@ email- b.boczek89@gmail.com
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraysAndListsEx_04
{
    class Program
    {

        
        static void myNumbers ()
        {
            var allNumber = new List<int>();
            var unqueNumber = new List<int>();

            while (true)
            {
                Console.Write("enter number or type quit to exit: ");
                var sourceInput = Console.ReadLine();

                if (sourceInput.ToLower() == "quit")
                    break;
                try
                {
                    allNumber.Add(Convert.ToInt32(sourceInput));
                }
                catch (Exception)
                {
                    Console.WriteLine("!!!!!!!!!!!WARNING!!!!!!!!!!");
                    Console.WriteLine("not a number try again");
                }
            }
            foreach (var numb in allNumber)
            {
                if (!unqueNumber.Contains(numb))
                    unqueNumber.Add(numb);
            }
            if (unqueNumber.Count !=0)
            {
                Console.WriteLine("Yours unique numbers : ");
                foreach (var numb in unqueNumber)
                    Console.WriteLine(numb);
            }
        }
        static void Main(string[] args)
        {
            myNumbers();
            Console.ReadLine();
        }
    }
}
