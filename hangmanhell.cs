using System;
using System.Collections.Generic;
using System.Text;

enum Selectmenu { Play = 1 , Exit }

namespace ConsoleApp60
{
    class Program
    {
        static void Main(string[] args)
        {
            playhangman();
            hangmangame();
        }
        static void playhangman()
        {
            Console.WriteLine("Welcome To Hangman Game");
            Console.WriteLine("---------------------------");
            Console.WriteLine("[1] Play Game");
            Console.WriteLine("[2] Exit");
            Console.Write("Please Select Menu : ");
            Selectmenu mn = (Selectmenu)(int.Parse(Console.ReadLine()));
            selectmenu(mn);
        }
        static void selectmenu(Selectmenu mn) 
        {
            if (mn == Selectmenu.Play) 
            {
                hangmangame();
            }
            else if (mn != Selectmenu.Exit)
            {
                Console.ReadLine();
            }
        }
        static void hangmangame() 
        {
            string[] Word = new string[3];
            Word[0] = "tennis";
            Word[1] = "football";
            Word[2] = "badminton";
            Random random = new Random();
            int rd = random.Next(0, 2);
            string newGuessWord = Word[rd];


            StringBuilder displayToPlayer = new StringBuilder(newGuessWord.Length);
            for (int i = 0; i < newGuessWord.Length; i++)
                displayToPlayer.Append('_');

            List<char> correctGuesses = new List<char>();
            List<char> incorrectGuesses = new List<char>();

            int incorrect = 0;
            int lives = 6;
            bool win = false;
            int lettersRevealed = 0;

            string input;
            char guess;

            while (!win && lives > 0)
            {
                Console.Write("Input letter alphabet : ");

                input = Console.ReadLine();
                guess = input[0];

                if (correctGuesses.Contains(guess))
                {
                    Console.WriteLine(guess);
                    continue;
                }
                else if (incorrectGuesses.Contains(guess))
                {
                    Console.WriteLine(guess);
                    continue;
                }

                if (newGuessWord.Contains(guess))
                {
                    correctGuesses.Add(guess);

                    for (int i = 0; i < newGuessWord.Length; i++)
                    {
                        if (newGuessWord[i] == guess)
                        {
                            displayToPlayer[i] = newGuessWord[i];
                            lettersRevealed++;
                        }
                    }

                    if (lettersRevealed == newGuessWord.Length)
                        win = true;
                }
                else
                {
                    incorrectGuesses.Add(guess);
                    incorrect++;
                    Console.WriteLine("Incorrect Score : {0}",incorrect);
                    Console.WriteLine(guess);
                    lives--;
                    
                }

                Console.WriteLine(displayToPlayer.ToString());
            }

            if (win)
                Console.WriteLine("You win!");
            else
                Console.WriteLine("You lost!");

            
            Console.ReadLine();
        }
    }
}
        
    

