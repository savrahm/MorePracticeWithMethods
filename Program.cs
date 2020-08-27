using System;
using System.Linq.Expressions;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintNegToPos1000();
            //PrintBy3();
            //EqualNumberChecker(firstNum: 12, secondNum: 11);
            //OddOrEven(24);
            //PosOrNeg(-237);
            //CanVote();
            //InRange(12);
            //MultiplicationTable(2);
            //ArrayBuilder(5);

            //int[] testArray = { 3, 4, 5 };
            //SumArray(testArray);

            //CubeAllBelow(3);

        }

        static void CubeAllBelow(int topNumber)
        {
            for (int num = 1; num <= topNumber; num++)
            {
                var cubedNumber = num * num * num;
                Console.WriteLine($"The starting number is {num}, and the cube of {num} is {cubedNumber}.");
            }
        }

        static void SumArray(int[] someArray)
        {
            var temp = 0;

            foreach (int element in someArray)
            {
                temp += element;
            }
            Console.WriteLine(temp);
        }

        static void ArrayBuilder(int indexNumber)
        {
            int[] userArray = new int[indexNumber];


            for (var index = 0; index < indexNumber; index++)
            {
                Random random = new Random();                
                var temp = random.Next(0, 100);
                userArray[index] = temp;

                Console.WriteLine(temp);
            }


            Console.WriteLine(userArray[2]);
        }

        static void MultiplicationTable(int x)
        {

            int[] tableArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            foreach(int timesBy in tableArray)
            {
                int product = x * timesBy;
                Console.WriteLine($"{x} times {timesBy} is {product}.");
            }
        }

        static void InRange(int x)
        {
            var message = (x >= -10 && x <= 10) ? $"Yes! {x} is in range!" : $"Oh no! {x} is out of range!";
            Console.WriteLine(message);
        }

        static void CanVote()
        {
            Console.WriteLine("How old are you?");

            int userAge;
            bool userInput = Int32.TryParse(Console.ReadLine(), out userAge);
           
            if(userInput)
            {
                int waitTime = 18 - userAge;
                var message = (userAge >= 18) ? "Great, you can vote!" : $"Sorry, you can't vote yet! You'll be eligible to vote in about {waitTime} years.";
               
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Uh oh. Something went wrong.");
            }
        }

        static void PosOrNeg(int x)
        {
            if(x > 0)
            {
                Console.WriteLine($"{x} is positive.");
            }
            else if(x < 0)
            {
                Console.WriteLine($"{x} is negative.");
            }
            else
            {
                Console.WriteLine($"Zero isn't positive or negative.");
            }
        }
        static void OddOrEven(int x)
        {
            if(x % 2 == 0)
            {
                Console.WriteLine($"{x} is even.");
            }
            else
            {
                Console.WriteLine($"{x} is odd.");
            }
        }
        static void PrintNegToPos1000()
        {
            for(int num = -1000;  num <= 1000; num++)
            {
                Console.WriteLine(num);
            }
        }

        static void PrintBy3()
        {
        for(int num = 1; num <= 1000; num++)
            {
                if (num % 3 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }

        static void EqualNumberChecker(int firstNum, int secondNum)
        {
            if(firstNum == secondNum)
            {
                Console.WriteLine($"Yes, {firstNum} and {secondNum} are equal.");
            }
            else
            {
                Console.WriteLine($"No, {firstNum} and {secondNum} are not equal.");
            }
        }
    }
}
