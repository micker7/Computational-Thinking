using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_computational_thinking
{
    internal class Exercises
    {
        public static void AreTheseIntegersEqual()
        {
            // Ask the user for two integers. 
            // Check and see if the two integers are equal to each other.
            // If they are, inform the the user that the numbers are equal,
            // else inform the user that the numbers are not equal

            Console.Clear();
            Console.WriteLine("ARE THESE INTEGERS EQUAL?\n");

            // Enter your solution here
            Console.WriteLine("Please input a number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input another number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());


            if (firstNumber == secondNumber)
            {
                Console.WriteLine("They are equal!");
            }
            else 
            {
                Console.WriteLine("They are not equal.");
            }
                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
           
        }






        public static void EvenOrOdd()
        {
            // Ask the user for a number.
            // Tell the user if that number is even or odd.

            Console.Clear();
            Console.WriteLine("EVEN OR ODD?\n");

            // Enter your solution here
            
            Console.WriteLine("Please type in a number");
            int numberTheyChose = Convert.ToInt32(Console.ReadLine());
            
            if(numberTheyChose.ToString().EndsWith("0") ||
               numberTheyChose.ToString().EndsWith("2") ||
               numberTheyChose.ToString().EndsWith("4") || 
               numberTheyChose.ToString().EndsWith("6") || 
               numberTheyChose.ToString().EndsWith("8"))
                //(numberTheyChose % 2 == 0)  <-- can also use remainder operator to find even numbers

                Console.WriteLine($"{numberTheyChose} is an EVEN number.");
           else
            {
                Console.WriteLine($"{numberTheyChose} is an ODD number.");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }






        public static void VowelOrConsonant()
        {
            // Ask the user for a letter. Check whether a letter is a vowel or consonant.
            

            Console.Clear();
            Console.WriteLine("VOWEL OR CONSONANT?\n");

            // Enter your solution here
            Console.WriteLine("Type in a letter.");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "a":
                    Console.WriteLine("This is a vowel.");
                    break;
                case "e":
                    Console.WriteLine("This is a vowel.");
                    break;
                case "i":
                    Console.WriteLine("This is a vowel.");
                    break;
                case "o":
                    Console.WriteLine("This is a vowel.");
                    break;
                case "u": 
                    Console.WriteLine("This is a vowel.");
                    break;
                default:
                    Console.WriteLine("This is a consonant.");
                    break;
            }
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        




        public static void FindLargestNumber()
        {
            // Prompt the user to input two integer values.
            // Find and print the greatest value of the two integers.

            Console.Clear();
            Console.WriteLine("FIND THE LARGEST NUMBER\n");

            // Enter your solution here         
            Console.WriteLine("Type in a number.");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type in a second number.");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type in the last number.");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            int greatestValue;

            if (firstNumber > secondNumber)
            {
                greatestValue = firstNumber;
            }
            else
            {
                greatestValue = secondNumber;
            }
            if(thirdNumber > greatestValue) 
            {
                greatestValue = thirdNumber;
            }

            Console.WriteLine($"The {greatestValue} is bigger.");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }






        public static void DivisibleBy3()
        {
            // Ask the user for a number and then tell them if it is divisible by 3

            Console.Clear();
            Console.WriteLine("DIVISIBLE BY 3\n");

            // Enter your solution here
            Console.WriteLine("Type in a number.");
            int input1 = Convert.ToInt32(Console.ReadLine());

            if(input1 % 3 == 0)
            {
                Console.WriteLine("This is divisible by 3.");
            }
            else
            {
                Console.WriteLine("This is not divisible by 3.");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }






        public static void WordsToDigits()
        {
            // Having a string representation of a number, you need to print the digit form of the number.
            // Ask the user to enter a string representation of a number from zero to ten.
            // Using switch case, print the digit (0-10) representation of the number.

            Console.Clear();
            Console.WriteLine("WORDS TO DIGITS\n");

            // Enter your solution here
            Console.WriteLine("Type in a number from 0-10 in word form (ex. two)");
            string userInput1 = Console.ReadLine();

            switch (userInput1.ToLower())
            {
                case "zero":
                    Console.WriteLine("The number is 0");
                    break;             
                case "one":           
                    Console.WriteLine("The number is 1");
                    break;             
                case "two":             
                    Console.WriteLine("The number is 2");
                    break;             
                case "three":          
                    Console.WriteLine("The number is 3");
                    break;             
                case "four":           
                    Console.WriteLine("The number is 4");
                    break;             
                case "five":            
                    Console.WriteLine("The number is 5");
                    break;              
                case "six":             
                    Console.WriteLine("The number is 6");
                    break;             
                case "seven":          
                    Console.WriteLine("The number is 7");
                    break;             
                case "eight":           
                    Console.WriteLine("The number is 8");
                    break;              
                case "nine":            
                    Console.WriteLine("The number is 9");
                    break;             
                case "ten":            
                    Console.WriteLine("The number is 10");
                    break;
                default:
                    Console.WriteLine("ERROR. Write number from zero to ten.");
                    break;
            }
                    Console.Write("Press enter to return to the Main Menu");
                    Console.ReadLine();
            
        }







          public static void WhichNameIsLonger()
        {
            // Ask the user for their first and last name.

            // Print the user's full name.
            // If the first name is longer than the last name, print "First is longer."
            // If the first name and last name are the same length, print "Same-sies!"
            // Otherwise, print "Last must be longer!"

            Console.Clear();
            Console.WriteLine("WHICH NAME IS LONGER?\n");

            // Enter your solution here
            Console.WriteLine("What is your first name?");

            String firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");

            String lastName = Console.ReadLine();

            if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("The first name is longer.");
            }
            else if (firstName.Length == lastName.Length)
            {
                Console.WriteLine("Same-sies!");
            }
            else
            {
                Console.WriteLine("Last name must be longer.");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }






        public static void AreNamesSame()
        {
            // Ask the user for 2 names.

            // If the two names are the same, print "The names are the same."
            // If they're not the same, print "The names are different." 

            Console.Clear();
            Console.WriteLine("ARE THESE NAMES THE SAME?\n");

            // Enter your solution here
            Console.WriteLine("1. Give me a name:");
            String name = Console.ReadLine();
            Console.WriteLine("1. Give me a name again:");
            String secondName = Console.ReadLine();

            if (name == secondName)
            {
                Console.WriteLine("The names are the same.");
            }
            else
            {
                Console.WriteLine("The names are different.");
            }


            Console.WriteLine("2. Give me a name:");
            String name1 = Console.ReadLine();
            Console.WriteLine("2. Give me a name again:");
            String secondName1 = Console.ReadLine();

            if (name1.Equals(secondName1))
            {
                Console.WriteLine("The names are the same.");
            }
            else
            {
                Console.WriteLine("The names are different.");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }







        public static void NameAndBirthplace()
        {
            // Ask the user for their first name and where they were born.
            // Print a sentence to the console that repeats this information.

            Console.Clear();
            Console.WriteLine("NAME AND PLACE OF BIRTH\n");

            // Enter your solution here
            Console.WriteLine("What is your first name?");
            String name3 = Console.ReadLine();
            Console.WriteLine("Where were you born?");
            String birthplace = Console.ReadLine();
            Console.WriteLine("Hi " + name3 + "! You were born in " + birthplace + ".");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }







        //LOOPS SECTION
        //For this next section, in order to get a passing grade, each of the following problems must be solved using at least one of the the loop types we learned in class.

        public static void ReverseCounting()
        {
            // Ask the user for a number between 1-20. Starting at the number given,
            // count backwards to 1 and print the numbers to the console.

            Console.Clear();
            Console.WriteLine("REVERSE COUNTING\n");

            // SOLUTION HERE
            Console.WriteLine("Type in any number between 1-20");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = input; i >= 1; i-- )
            {
                Console.WriteLine(i);
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }






        public static void SquareOfEvenNumbers()
        {
            // For the numbers 1-9, if a number is even print the square of that number (number multiplied by itself) and if it is odd, just print the number
           
            Console.Clear();
            Console.WriteLine("PRINT THE SQUARE OF EVEN NUMBERS\n");

            // SOLUTION HERE            
             for (int i = 1; i <= 9; i++ )
             {
               if(i % 2 == 0) 
               {
                    Console.WriteLine(i * i);
               }
               else
                {
                    Console.WriteLine(i);
                }
                
             }
             
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void GuessMagicNumber()
        {
            // Write a console application that asks the user for an integer.
            // If that integer is evenly divisible by 3, then print “You Won!”.
            // If it isn’t, ask the user to “Try again.”
            // Keep asking them for a number (looping) until they win.

            Console.Clear();
            Console.WriteLine("GUESS THE MAGIC NUMBER\n");
            
            int userInput = Convert.ToInt32(Console.ReadLine());

            // This reads the user's input and converts it to an integer.
            // We'll assume that users can only input integers.
            // SOLUTION HERE



            while (true)
            {
                if (userInput % 3 == 0)
                {
                    Console.WriteLine("You Won!");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again!");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }

            }
            
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }
    }
}
