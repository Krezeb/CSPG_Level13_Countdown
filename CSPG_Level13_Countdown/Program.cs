using System;

namespace CSPG_Level13_Countdown
{
    class Program
    {
        static void Main(string[] args)
        {
            CountDown(10);
        }
        static int CountDown(int number)
        {
            if (number == 0) return 1; //This is Base Case. Recursion ends when "number" == 0
            Console.WriteLine(number); //Displays current "number"
            return number * CountDown(number - 1); //Returns number and initiates recursion (-1 otherwise straight up loop)
        }
    }
}

//Challenge Countdown 100 XP
//Note: This challenge requires that you have read The Basics of Recursion side quest to attempt.
//The Council of Freach has summoned you. New writing has appeared on the Tomb of Algol the Wise, the 
//last True Programmer to wander this land. The writing strikes fear and awe into the hearts of the loop
//loving people of Freach: “The next True Programmer shall be able to write any looping code with a 
//method call instead.” The Senior Counselor, scared of a world without loops, asks you to put your skill to 
//the test and rewrite the following code, which counts down from 10 to 1, with no loops:
//for (int x = 10; x > 0; x--)
//    Console.WriteLine(x);
//As you consider the words on the Tomb of Algol the Wise, you begin to think that with recursion, you 
//might be able to rewrite code to count down from 10 to 1 using recursion instead of a loop.
//Objectives:
//• Write code that counts down from 10 to 1 using a recursive method.
//• Hint: Remember that you must have a base case that ends the recursion and that every time you 
//call the method recursively, you must be getting closer and closer to that base case