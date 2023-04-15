using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;

namespace exercises_6;
class Program
{
    static void Main(string[] args)
    {
        //1 - When you post a message on Facebook, depending on
        //the number of people who like your post,
        //Facebook displays different information.

        //If no one likes your post, it doesn't display anything.
        //If only one person likes your post, it displays:
        //          [Friend's Name] likes your post.
        //If two people like your post, it displays:
        //          [Friend 1] and[Friend 2] like your post.
        //If more than two people like your post, it displays:
        //          [Friend 1], [Friend 2] and[Number of Other People] others like your post.
        //Write a program and continuously ask the user
        //          to enter different names, until the user presses Enter(without supplying a name).
        //          Depending on the number of names provided, display a message based on the above pattern.

        static void Exercise1()
        {
            Console.WriteLine("Enter a name and press 'enter': (press enter with no name to end");
            var listOfFriends = new List<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "" || input == null || input == " ")
                {
                    Console.WriteLine("exiting...");
                    break;
                }
                listOfFriends.Add(input);

            }
            Console.WriteLine("The people who like your post are: {0}, {1}, {2}",
                listOfFriends[0], listOfFriends[1], listOfFriends.Count());

        }
        Exercise1();
        /// <summary>
        /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
        /// Display the reversed name on the console.
        /// </summary>
        static void Exercise2()
        {
            Console.Write("What's your name? ");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);
        }

        /// <summary>
        /// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
        /// an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
        /// and display the result on the console.
        /// </summary>
        static void Exercise3()
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've previously entered " + number);
                    continue;
                }

                numbers.Add(number);
            }

            numbers.Sort();

            foreach (var number in numbers)
                Console.WriteLine(number);
        }

        /// <summary>
        /// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
        /// include duplicates. Display the unique numbers that the user has entered.
        /// </summary>
        static void Exercise4()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            Console.WriteLine("Unique numbers:");
            foreach (var number in uniques)
                Console.WriteLine(number);
        }


        /// <summary>
        /// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
        /// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
        /// the 3 smallest numbers in the list.
        /// 
        /// </summary>
        static void Exercise5()
        {
            string[] elements;
            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);
        }
    }

}




