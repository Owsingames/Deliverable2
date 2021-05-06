using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gand Circus Deliverable 2 -- Chat bot");
            Console.WriteLine("Welcome to chatbot -- dialog commands -- Hello, Sup, Hello there, Bye \n");


            //check user input twice
            bool inputHello = false;
            bool supInput = false;
            bool inputThere = false;

            //continue loop until user says bye
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("What would you like to say to chatbot?");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("User: ");
                //get user input
                string userInput = Console.ReadLine().ToLower();

                //user input hello
                if (userInput == "hello")
                {
                    //check for same input
                    if (inputHello == true)
                    {
                        Console.WriteLine("I'm sorry you already siad that \n");
                        inputHello = false;
                    }
                    else
                    {
                        Console.WriteLine("Chatbot: Hi good to see you \n");
                        inputHello = true;
                        supInput = false;
                        inputThere = false;
                    }

                }
                //user input sup
                else if (userInput == "sup")
                {
                    //check for same input
                    if (supInput == true)
                    {
                        Console.WriteLine("I'm sorry you already siad that \n");
                        supInput = false;
                    }
                    else
                    {
                        Console.WriteLine("Chatbot: I am good \n");
                        supInput = true;
                        inputHello = false;
                        inputThere = false;
                    }
                }
                //user input hello there
                else if (userInput == "hello there")
                {
                    //check for same input
                    if (inputThere == true)
                    {
                        Console.WriteLine("I'm sorry you already siad that \n");
                        inputThere = false;
                    }
                    else
                    {
                        Console.WriteLine("Chatbot: General Kenobi \n");
                        inputThere = true;
                        supInput = false;
                        inputHello = false;
                    }
                }
                //user input bye - end while loop
                else if (userInput == "bye")
                {
                    Console.WriteLine("Chatbot: Goodbye! \n");
                    break;
                }
                //check for any non-valid dialog command
                else
                {
                    Console.WriteLine("Please enter a valid dialog command. \n");
                }
            }


        }
    }
}
