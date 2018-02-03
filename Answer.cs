using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Answer
    {

        Guesses guesses = new Guesses();

        public List<char> dashList = new List<char>();
        public char[] charArray { get; set; }

        public List<char> initiateCharArrays(string submittedAnswer)
        {
            charArray = submittedAnswer.ToCharArray();

            for (var i = 0; i < charArray.Length; i++)
            {
                if(charArray[i] == ' ')
                {
                    dashList.Add('|');
                } else
                {
                    dashList.Add('-');
                }
            }

            return dashList;
        }

        public List<char> EvaluateGuess(List<string> correctGuesses)
        {
            for (var i = 0; i < charArray.Length; i++)
            {
                foreach (var g in correctGuesses)
                {
                    if (charArray[i].ToString() == g)
                    {
                        dashList[i] = charArray[i];                     
                    }
                }
            }
            foreach (var dl in dashList)
            {
                Console.Write(dl);
            }

            if (!dashList.Contains('-'))
            {
                Console.Clear();
                foreach (var dl in dashList)
                {
                    Console.Write(dl);
                }
                Console.WriteLine("\nWHOOP WHOOP! WELL DONE!");
            }
            return dashList;
        }

    }
}
