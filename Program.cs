using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Guesses guesses = new Guesses();
            Answer answer = new Answer();

            var submittedAnswer = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Have a guess mofo");
            var guessesRemaining = 0;

            List<string> hangmanPieces = new List<string>();
            hangmanPieces.Add("");
            hangmanPieces.Add("_____\n\n\n");
            hangmanPieces.Add("_____\n|\n|\n|");
            hangmanPieces.Add("_____\n|   O\n|\n|");
            hangmanPieces.Add("_____\n|   O\n|   |\n|");
            hangmanPieces.Add("_____\n|   O\n|  /|\n|");
            hangmanPieces.Add("_____\n|   O\n|  /|\\\n|");
            hangmanPieces.Add("_____\n|   O\n|  /|\\\n|  /");
            hangmanPieces.Add("_____\n|   O\n|  /|\\\n|  / \\");

            answer.initiateCharArrays(submittedAnswer);

            while (guessesRemaining < 8)
            {

                answer.EvaluateGuess(guesses.correctGuesses);

                Console.WriteLine("\n");
                var guess = Console.ReadLine();
                Console.Clear();

                if (guesses.EvaluateGuess(guess, submittedAnswer))
                {
                    guesses.addCorrectGuess(guess);
                    Console.WriteLine("Whoop! Have another guess mofo");
                    Console.WriteLine(hangmanPieces[guessesRemaining]);
                }
                else
                {
                    guessesRemaining += 1;
                    Console.WriteLine("Oops bummer! Have another guess mofo");
                    Console.WriteLine(hangmanPieces[guessesRemaining]);         
                }

            }

            Console.WriteLine("GAME OVER :)");
         

            while (Console.ReadKey().Key != ConsoleKey.End) { };
        }
    }
}
