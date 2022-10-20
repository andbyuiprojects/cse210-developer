using System;
using System.Collections.Generic;

namespace unit03.Jumper
{
    /// <summary>
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {

        private bool _isPlaying = true;
        private string chosenWord;

        private TerminalService terminalService = new TerminalService();
        public Word hiddenWord = new Word();
        private Jumper _jumper = new Jumper();
        public int tries = 0;
        public int numberOfGuesses = 0;

        private bool _checkInput;

        List<char> guessedLetters = new List<char>();

        public string currentGuess = "test";


        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            StartUp();
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

         /// <summary>
        /// Starts the game giving a hint.
        /// </summary>
        private void StartUp()
        {
            Console.WriteLine("\n Hint: It has to do with the class.");
            chosenWord = hiddenWord.getWord();
            hiddenWord.listWord(chosenWord);
            hiddenWord.createHiddenWord();
            hiddenWord.printGuess();
        }

         /// <summary>
        /// Gets input from the user.
        /// </summary>
        private void GetInputs()
        {
            Console.WriteLine("\n");
            _jumper.printJumper(tries);
            _checkInput = true;
            while (_checkInput){
                currentGuess = terminalService.ReadGuess("\nGuess a letter [a-z]: ");
                _checkInput = _jumper.checkInput(guessedLetters, currentGuess);
            }
            guessedLetters.Add(currentGuess[0]);
            

        }

         /// <summary>
        /// Does the updates by seeing what the user guessed and comparing it to the word adn number of guesses.
        /// </summary>
        private void DoUpdates()
        {
            numberOfGuesses = guessedLetters.Count;
            int usedTries = hiddenWord.Compare(guessedLetters, numberOfGuesses);
            tries = tries + usedTries;
            _isPlaying = _jumper.checkJumper(hiddenWord.guess, tries);
        }

        /// <summary>
        /// Prints everything the user needs to see.
        /// </summary>
        private void DoOutputs()
        {
            Console.WriteLine("\n");
            if (_isPlaying){
                hiddenWord.printGuess();
            }
            else {
                _jumper.printJumper(tries);
                hiddenWord.printAnswer();
                Console.WriteLine("\n");
            }
  
        }
    }
}