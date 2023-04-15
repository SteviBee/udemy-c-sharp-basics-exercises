using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;
using System;
using System.Collections.Generic;
using System.Drawing;

//Format quick key -> Option + shift + F
//Option + shift + arrow -> copy below
//Option+ command + arrow -> change window 

//Entry point: NORMAL
//namespace HelloWorld
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}

namespace Section_5_Exercises
{
    public class Conditionals

    {
        static void Main(string[] args)

        {

            //1- Write a program and ask the user to enter a number.The number should be between 1 to 10.
            //If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid".
            // (This logic is used a lot in applications where values entered into input boxes need to be validated.)
            static void AskNum()
            {
                Console.WriteLine("Enter number between 1-10: ");
                //Create variable:
                int input = Convert.ToInt32(Console.ReadLine());
                if (input <= 10)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalde");
                }
            }

            //AskNum();

            //2- Write a program which takes two numbers from the console and displays the maximum of the two.
            static void TwoNums()
            {
                Console.WriteLine("Enter two number, and I will show max: ");
                var spiltted = Console.ReadLine().Split(" ");
                int inputOne = Convert.ToInt32(spiltted[0]);
                int inputLast = Convert.ToInt32(spiltted[1]);

                if (inputOne > inputLast)
                {
                    Console.WriteLine("Max is: {0}", inputOne);
                }
                else
                {
                    Console.WriteLine("Max is: {0}", inputLast);

                }
            }
            //TwoNums();
            // 3 - Write a program and ask the user to enter the width and height of an image.
            //Then tell if the image is landscape or portrait.
            static void WidthHeightFinder()
            {
                Console.WriteLine("enter width of an image: ");
                var width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter height of an image: ");
                var height = Convert.ToInt32(Console.ReadLine());

                var imageType = (width > height) ? "landscape" : "portrait";
                Console.WriteLine(imageType);
            }
            //WidthHeightFinder();

            //            4 - Your job is to write a program for a speed camera.
            //For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
            //Write a program that asks the user to enter the speed limit.Once set, the program asks for the speed of a car.
            // If the user enters a value less than the speed limit, program should display Ok on the console.
            //If the value is above the speed limit, the program should calculate the number of demerit points.
            //For every 5km / hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
            // If the number of demerit points is above 12, the program should display License Suspended.
            static void Other()
            {
                Console.Write("What is the speed limit? ");
                var speedLimit = Convert.ToInt32(Console.ReadLine());

                Console.Write("What is the speed of this car? ");
                var carSpeed = Convert.ToInt32(Console.ReadLine());

                if (carSpeed < speedLimit)
                    Console.WriteLine("Ok");
                else
                {
                    const int kmPerDemeritPoint = 5;
                    var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
                    if (demeritPoints > 12)
                        Console.WriteLine("License Suspended");
                    else
                        Console.WriteLine("Demerit points: " + demeritPoints);
                }



            }

            //1 - Write a program to count how many numbers between 1 and 100
            //are divisible by 3 with no remainder.
            //Display the count on the console.
            static void CountDivideByThree()
            {
                //var randomNum = new Random();
                //randomNum.Next(100);
                // create a while loop to check and go

                var visibleCounter = 0;
                for (var i = 1; i < 100; i++)
                {
                    if (i % 3 == 0)
                    {
                        visibleCounter++;
                    }

                }
                Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", visibleCounter);

            }
            //CountDivideByThree();


            //2 - Write a program and continuously ask the user to enter a number
            //or "ok" to exit.
            //Calculate the sum of all the previously entered
            //numbers and display it on the console.
            static void AskForNumAndSum()
            {
                var sum = 0;
                while (true)
                {
                    Console.WriteLine("Enter a number or type 'ok' to exit");
                    var getInput = Console.ReadLine();
                    if (getInput == "ok")
                    {
                        Console.WriteLine("Exiting... total sum = {0}", sum);
                        break;
                    }
                    else
                    {
                        sum = sum + Convert.ToInt32(getInput);
                    }

                }
            }
            //AskForNumAndSum();
            //3 - Write a program and ask the user to enter a number.
            //Compute the factorial of the number and print it on the console.
            //For example, if the user enters 5, the program
            //should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            static void ComputeFactoral()
            {
                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());

                var factorial = 1;
                for (var i = 1; i <= number; i++)
                    factorial *= i;

                Console.WriteLine("{0}! = {1}", number, factorial);
            }
        }

    }


}