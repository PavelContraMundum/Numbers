using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    internal class Program
    {
        //Entry point method
        static void Main(string[] args)
        {
            GetAppInfo(); //Run GetAppInfo function to get info 

            GreetUser(); //Ask for users name and greet

            while (true)
            {



                //Init correct number
                //int correctNumber = 7;

                //Create new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    //Get users input
                    string input = Console.ReadLine();

                    //Make sure its a number

                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        //Keep going

                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Print error message
                       PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                //Print success message
                PrintColorMessage(ConsoleColor.Yellow, "Correct!!! You guessed it!");

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                //Get answer

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;

                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Pavel";

            //Change text color 
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //Ask user name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color 
            Console.ForegroundColor = color;

            //Tell user it is not a number 
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }

    
}
