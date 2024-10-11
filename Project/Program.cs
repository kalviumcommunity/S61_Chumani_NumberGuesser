// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace NumberGuesser {

    class Program{
        public static void Main(string[] args){
            // start here
            GetAppInfo();

            // ask for users name and greet
            GreetUser();

            while(true){
                // Set correct number
                
                // Create a new Random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while(guess != correctNumber){
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if(!int.TryParse(input, out guess)){
                        // Print error message
                        PrintColor(ConsoleColor.Red, "Please use an actual number");

                        // keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if(guess != correctNumber){
                        // Print error message
                        PrintColor(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // Output success message
                PrintColor(ConsoleColor.Yellow, "CORRECT!!! You guessed it!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y"){
                    continue;
                }else if(answer == "N"){
                    return;
                }else{
                    return;
                }
            }
        }

        // get and display app info
        static void GetAppInfo(){
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Brad Traversy";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Ask user's name and greet
        static void GreetUser(){
            // Ask user's name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game", inputName);
        }

        // Print color message
        static void PrintColor(ConsoleColor color, string message){
            // Change text color
            Console.ForegroundColor = color;

            // Write out app info
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
