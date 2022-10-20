using System;
using System.Collections.Generic;

namespace unit03.Jumper
{
    /// <summary>
    /// TThe jumper class for creating the jumper and printing it for the user to see.
    /// </summary>
    public class Jumper{
        private List<string> _jumper = new List<string>();
        private int _count;
        private int _trueTries = 0;

        /// <summary>
        /// Set's up the initial jumper.
        /// </summary>
        public Jumper()
        {
            _jumper.Add("  ___");
            _jumper.Add(" /___\\");
            _jumper.Add(" \\   /");
            _jumper.Add("  \\ /");
            _jumper.Add("   O");
            _jumper.Add("  /|\\");
            _jumper.Add("  / \\");
        }

        /// <summary>
        /// Checks to see if the user has guessed the word or not.
        /// </summary>
        public bool checkInput(List<char> guesses, string currentGuess){
            if (guesses.Contains(currentGuess[0])){
                Console.WriteLine("You already guessed that letter!");
                return true;
            }
            else {
                return false;
            }

        }

        /// <summary>
        /// Checks the jumper to see if the have gone through all of the guesses.
        /// </summary>
        public bool checkJumper(List<char> wordGuess, int tries){
            _count = 0;
            for(int i=0;i<wordGuess.Count;i++){
                if (wordGuess[i] != '_'){
                    _count++;
                }
                else{}
            }
            if (_count == wordGuess.Count){
                return false;
                
            }
            else if(tries == 4){
                return false;
            }
            else {
                return true;
            }
        }

        /// <summary>
        ///This prints the jumper and changes him to an x 
        ///if the user runs out of guesses.
        /// </summary>
        public void printJumper(int tries){
            if (tries == _trueTries)
            {

            }
            else if(tries == 4)
            {
                _jumper.RemoveRange(0,1);
                _jumper[0] = "   X";


            }
            else
            {
                _jumper.RemoveRange(0,1);
                _trueTries++;
            }
            Console.WriteLine(string.Format("{0}", string.Join("\n", _jumper)));
        }
    }
}