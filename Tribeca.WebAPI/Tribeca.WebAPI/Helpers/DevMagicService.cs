namespace Tribeca.WebAPI.Helpers
{
    class DevMagicService : IDevMagicService
    {

        // Extensions tranform english to dev magic, dev magic to english and get star sign
        public string TransformToDevMagic(string input)
        {
            var words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var transformedWords = words.Select(word => TransformWord(word)).ToArray();

            return string.Join(" ", transformedWords);
        }

        private string TransformWord(string word)
        {
            char lastChar = word[word.Length - 1];

            char punctuation = '\0';
            if (lastChar == '!' || lastChar == ',' || lastChar == '.')
            {
                punctuation = lastChar;
                word = word.Substring(0, word.Length - 1);
            }

            if (IsVowel(word[0]))
            {
                word = TransformVowelStartingWord(word);
            }
            else if (word[0] == 'y' || word[0] == 'Y')
            {
                word = TransformYStartingWord(word);
            }
            else
            {
                word = TransformConsonantStartingWord(word);
            }
          
            if (punctuation != '\0')
            {
                word += punctuation;
            }

            return word.ToLower(); 
        }


        private string TransformVowelStartingWord(string word)
        {
            return ProcessTransformedWord(word + "yay");
        }

        private string TransformYStartingWord(string word)
        {
            if (word.Length > 1 && IsVowel(word[1]))
            {
                return ProcessTransformedWord(word.Substring(1) + word[0] + "ay");
            }
            else
            {
                return ProcessTransformedWord(TransformVowelStartingWord(word));
            }
        }

        private string TransformConsonantStartingWord(string word)
        {
            int firstVowelIndex = FindFirstVowelIndex(word);
            if (firstVowelIndex == -1)
            {
                return ProcessTransformedWord(word + "ay");
            }
            return ProcessTransformedWord(word.Substring(firstVowelIndex) + word.Substring(0, firstVowelIndex) + "ay");
        }

        private string ProcessTransformedWord(string transformedWord)
        {
            if (transformedWord.Contains("!"))
            {
                transformedWord = transformedWord.Replace("!", "") + "!";
            }
            return transformedWord;
        }

        private int FindFirstVowelIndex(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (IsVowel(word[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        private bool IsVowel(char c)
        {
            return "aeiouAEIOU".IndexOf(c) >= 0;
        }
    }
}

