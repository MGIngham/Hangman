using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Guesses
    {
             
        public bool isCorrectAnswer { get; set; }
        public List<string> correctGuesses = new List<string>();    

        public bool EvaluateGuess(string letter,  string answer)
        {
            return (answer.Contains(letter)) ? true : false;
        }

        public List<string> addCorrectGuess(string correctGuess)
        {
            correctGuesses.Add(correctGuess);

            return correctGuesses;
        }

    }
}
