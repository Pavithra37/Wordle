using System;

namespace Wordle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey! Guess a five letter word in 5 tries.");
            Game wordleGame = new Game();
            wordleGame.WordleGame();
        }
    }

    class Game
    {
        int times = 0;
        public void WordleGame()
        {
            string wordToGuess = "honey";
            string input = null;
            
            input = Console.ReadLine();
            times++;
            if (input.Length == 5)
            {
                if(input == wordToGuess)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine(wordToGuess);
                    Console.ResetColor();
                    Console.WriteLine("Congrats! You guessed it right.");
                }
                else
                {
                    for(int i=0;i<wordToGuess.Length;i++)
                    {
                        if(wordToGuess[i] == input[i])
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Write(input[i]);
                        }
                        else
                        {
                            if(wordToGuess.Contains(input[i]))
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.Write(input[i]);
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Write(input[i]);
                            }
                        }
                        if(i == wordToGuess.Length - 1)
                        {
                            Console.WriteLine("");
                        }
                    }
                  
                    Console.ResetColor();
                    if(times<5)
                    {
                       WordleGame();
                       
                    }
                    else
                    {
                        Console.Write("Sorry, you failed to guess the word. The word is : " + wordToGuess);
                        
                    }
    
                }

            }
            else
            {
                Console.WriteLine("Sorry, the word must be 5 letters. Try again.");
                times--;
                WordleGame();
            }
            


        }
    }
}
