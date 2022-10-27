namespace jumping
{
    class Word
    {

        private List<string> word = new List<string>();
        TerminalService asparagus = new TerminalService();
        private List<string> guesses = new List<string>();
        public string cheatCode = "";


        ///<summary>
        ///Creates a new instance of the Word class
        ///</summary>
        public Word()
        {
            //fill in the list "word"
            string magic = getWord();
            for (int i = 0; i < magic.Length; i++)
            {
                char letter = magic.ElementAt(i);
                string newLetter = letter.ToString();
                word.Add(newLetter);
                cheatCode = magic;
            }


        }
        /// <summary>
        /// From a limited list of words, chooses one at random
        /// </summary>
        /// <returns></returns>
        private string getWord()
        {
            List<string> wordList = new List<string> { "about", "apricot", "apple", "ate", "eight", "infinity", "duodecillion", "numerical", "fruit", "antidisestablishmentarianism", "pneumonoultramicroscopicsolicovolcaniconiosis", "floxinoxinihilipilification", "quinquinquagintillion", "superb", "umbrella", "fantasmagorical", "stupendous", "dog", "cat", "mouse", "horse", "ham", "sandwich", "chips", "crisps", "boot", "sock", "dire" };
            int range = wordList.Count;
            Random random = new Random();
            string MagicWord = wordList.ElementAt(random.Next(0, range));
            return MagicWord;
        }
        /// <summary>
        /// Draws the word with spaces
        /// </summarys>
        /// <returns></returns>
        public void Draw()
        {

            foreach (string letter in word)
            {
                //If the letter has been guessed, display it
                if (guesses.Contains(letter))
                {
                    asparagus.WriteLines($" {letter} ");
                }
                //If it isn't in our guesses so far, leave a "_"
                else
                {
                    asparagus.WriteLines($" _ ");
                }

            }
            asparagus.WriteText("");

        }
        public bool AddGuess(string guess)
        {
            guesses.Add(guess);
            return (word.Contains(guess));
        }
        public bool isFound()
        {
            bool isFound = true;
            foreach (string letter in word)
            {
                if (!guesses.Contains(letter))
                {
                    isFound = false;
                }
            }
            return isFound;
        }
    }
}