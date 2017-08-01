/*
link :https://www.udemy.com/csharp-tutorial-for-beginners/learn/v4/t/lecture/2910704?start=0
Exercises
Section 5, Lecture 48

description:
4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is
behaving correctly, you can display the secret number on the console first.)


by Blazej BOCZEK
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlFlow_isExercieses_04
{
    class Program
    {
        public static void guessNumber ()
        {
            var counter = 1;
            var anwser = new Random().Next(1, 10);
            Console.WriteLine("the anwser is: "+anwser);
            while (counter<=4)
            {
                Console.Write("Pick a number between 1 and 10: ");
                var myTry= Convert.ToInt32(Console.ReadLine());
                if (myTry == anwser)
                {
                    Console.WriteLine("You won");
                    break;
                }
               
                if (counter == 4)
                {
                    Console.WriteLine("You lose");
                }
                counter++;
            }
           
        }
        static void Main(string[] args)
        {
            guessNumber();
            Console.ReadKey();

        }
    }
}
