using System;
using System.Collections.Generic;
using System.IO;

namespace unit03.Jumper
{
    public class Word
    {
        public string hiddenWord;
        List<char> answer = new List<char>();
        public List<char> guess = new List<char>();

        public Word()
        {
            
        }
        /// <summary>
        /// Get's a random word from the list of provided words in "sample.txt".
        /// </summary>
        public string getWord()
        {
            List<string> lines = new List<string>(File.ReadLines("sample.txt"));
            Random rand = new Random();
            int randomIndex = rand.Next(0, lines.Count);
            string chosenWord = lines[randomIndex];
            return chosenWord;
        }


        public void listWord(string ripWord){
            answer.AddRange(ripWord.ToLower());
        }

        /// <summary>
        /// Adds a _ for every letter in the word.
        /// </summary>
        public void createHiddenWord(){
            foreach (int i in answer){
                guess.Add('_');
            }
            }

        /// <summary>
        /// Shows the player their guess.
        /// </summary>
        public void printGuess(){
            Console.WriteLine(string.Format("{0}", string.Join(" ", guess)));       
        }

        /// <summary>
        /// Checks to see if the letter guessed is in the word that has been give.
        /// </summary>
        public int Compare(List<char> listPreviousGuesses, int numberOfGuesses){
            for(int i=0;i<answer.Count;i++){
                if (listPreviousGuesses.Contains(answer[i])){
                    guess[i] = answer[i];}}
            if (answer.Contains(listPreviousGuesses[numberOfGuesses-1])){
                return 0;}
            else {
                return 1;}

        }

        /// <summary>
        /// Prints the answer.
        /// </summary>
        public void printAnswer(){
            Console.WriteLine(string.Format("{0}", string.Join(" ", answer)));
        }

    };
}