namespace jumping
{
    public class Director
    {
        private bool isPlaying;
        private string guess;
        private TerminalService stromboli = new TerminalService();
        private Jumper boink = new Jumper();
        private Word word = new Word();


        /// <summary>
        /// Starts an instance of the Director class
        /// </summary>
        public Director()
        {
            guess = "a";
            isPlaying = true;
        }

        ///<summary>
        ///Starts the main loop of the game, also contains the end output
        ///</summary>
        public void StartGame()
        {
            DoOutputs();


            while (isPlaying)
            {
                guess = GetInputs();
                Updates(guess);
                DoOutputs();
            }

            if (word.isFound())
            {
                stromboli.WriteText("Congrats! You win!");
            }
            else
            {
                boink.GameOver();
                boink.DrawParachute();
                stromboli.WriteText(word.cheatCode);
            }

        }

        ///<summary>
        ///Aks for and gets the inputs each round
        ///</summary>
        private string GetInputs()
        {

            string letter = stromboli.ReadText("What is your guess? ");
            return letter;
        }

        ///<summary>
        ///Updates the list for word and/or parachute
        ///</summary>
        private void Updates(string guess)
        {
            bool correcto = word.AddGuess(guess);
            if (!correcto)
            {
                boink.EraseParachute();
            }

        }

        ///<summary>
        ///Draws the updated word and parachute
        ///</summary>
        private void DoOutputs()
        {
            if (boink.parachute.Count <= 5 || word.isFound())
            {
                isPlaying = false;
            }
            else
            {
                word.Draw();
            }
            boink.DrawParachute();

        }
    }
}
