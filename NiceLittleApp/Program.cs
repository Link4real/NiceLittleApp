using System;

namespace NiceLittleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //strings etc.
            string secretWord1 = "1939";
            string secretWord2 = "Christopher Columbus";
            string secretWord3 = "Leonardo da Vinci";
            string guess1 = "";
            string guess2 = "";
            string guess3 = "";
            int guessCount1 = 0;
            int guessLimit1 = 3;
            bool OutOfGuesses1 = false;
            int guessCount2 = 0;
            int guessLimit2 = 3;
            bool OutOfGuesses2 = false;
            int guessCount3 = 0;
            int guessLimit3 = 3;
            bool OutOfGuesses3 = false;
            //Start
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Hello and welcome to my little quiz!");
            Console.WriteLine("Have fun and test your knowledge!");
            Console.WriteLine("You have a limit of 3 guesses per question!");
            Console.WriteLine("Made by Link4real!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //Question 1
            do
            {
                if (guessCount1 < guessLimit1)
                {
                    Console.Write("---> When was world war 2? ");
                    guess1 = Console.ReadLine();
                    guessCount1++;
                }
                else
                {
                    OutOfGuesses1 = true;
                }
            } while (secretWord1 != guess1 && !OutOfGuesses1);
            if (OutOfGuesses1)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("You Lose!");
                Console.WriteLine("The correct answer is: " + secretWord1);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            }
            else
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Correct Answer!");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            }
            //Question 2
            do
            {
                if (guessCount2 < guessLimit2)
                {
                    Console.Write("---> Who discovered America? ");
                    guess2 = Console.ReadLine();
                    guessCount2++;
                }
                else
                {
                    OutOfGuesses2 = true;
                }
            } while (secretWord2 != guess2 && !OutOfGuesses2);
            if (OutOfGuesses2)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("You Lose!");
                Console.WriteLine("The correct answer is: " + secretWord2);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            }
            else
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Correct Answer!");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            }
            //Question 3
            do
            {
                if (guessCount3 < guessLimit3)
                {
                    Console.Write("---> Who drew the 'Mona Lisa' ??? ");
                    guess3 = Console.ReadLine();
                    guessCount3++;
                }
                else
                {
                    OutOfGuesses3 = true;
                }
            } while (secretWord3 != guess3 && !OutOfGuesses3);
            if (OutOfGuesses3)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("You Lose!");
                Console.WriteLine("The correct answer is: " + secretWord3);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            }
            else
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Correct Answer!");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            }

            

           Console.WriteLine("Thank you for playing!");
            Console.WriteLine(":)");





            Console.ReadLine();

        }
    }
}
