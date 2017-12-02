using System;

//Namespace
namespace NumberGuesser
{
    //Main Class 
    class Program
    {
        //Entry Point Method 
        static void Main(string[] args)
        {

            //run function to get app info 
            GetAppInfo();

            GreetUser(); //Ask for users name and greet

            while (true)
            {
                //Set correct number
                //int correctNumber = 7;

                //Create random number 

                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    //Get user input
                    string input = Console.ReadLine();


                    //Make sure its a number 

                    if (!int.TryParse(input, out guess))
                    {

                        PrintColorMessage(ConsoleColor.DarkRed, "Please enter an actual number");
                        //keep going 
                        continue;


                    }
                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //match correct number 

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number Please Guess again");
                    }

                }

                //Output Success message
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("You guessed the correct number!");

                Console.ResetColor();

                Console.WriteLine("Do you want to play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }else if (answer =="N"){
                        
                    return;
                }else{
                    return;
                }
            }

        }

        static void GetAppInfo(){

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Jason Navarro";

            //change text color 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

        static void GreetUser(){
            //Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's play a game...", inputName);

        }

        static void PrintColorMessage(ConsoleColor color, string message){

            Console.ForegroundColor =  color;

            Console.WriteLine(message);

            Console.ResetColor();

        }
    }
}

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {

            string pasqui = "My name is Jason Pasqui";

            string pasqui2 = "My name is Jason Navarro";

                Console.WriteLine( String.IsNullOrEmpty(pasqui));
                
                Console.WriteLine(pasqui.Length);
                

                Console.WriteLine(pasqui.Substring(11));

                Console.WriteLine("Equal Strings " + pasqui.Equals(pasqui2));

                Console.WriteLine(pasqui.Length);

                Console.WriteLine(pasqui.Replace("Jason Pasqui", "Pas Navarro1"));

                Console.WriteLine(pasqui.Remove(0, 11));

                // Using Arrays
                string[] testArr = new string[3] { "jason", "pasqui", "navarro" };

                Console.WriteLine(String.Join(" ", testArr));
        }
    }
}
