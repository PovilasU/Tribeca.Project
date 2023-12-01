using System.Text.RegularExpressions;

namespace Tribeca.WebAPI.Helpers
{
    public class DevMagicService : IDevMagicService
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

        public string TransformYStartingWord(string word)
        {
            // First check if 
            //When the letter ‘Y’
            //appears in the second position of a word,
            //the standard rules for word formation

            bool startsWithConsonantClusterAndY = Regex.IsMatch(word, @"^[^aeiouAEIOU]+y", RegexOptions.IgnoreCase);

                if (startsWithConsonantClusterAndY)
                {
           
                static string GetConsonantCluster(string word)
                {
                    if (!string.IsNullOrEmpty(word))
                    {
                        int indexY = -1;
                       
                        for (int i = 0; i < word.Length; i++)
                        {
                            char currentChar = word[i];
                            if (currentChar == 'Y' || currentChar == 'y')
                            {
                                indexY = i;
                                break;
                            }
                        }
                   
                        if (indexY > 0)
                        {               
                            for (int i = 0; i < indexY; i++)
                            {
                                if ("aeiouyY".IndexOf(word[i]) >= 0)
                                {
                                    return null; 
                                }
                            }
                       
                            return word.Substring(0, indexY);
                        }
                    }

                    return null; 
                }
                            
                string resultString = word.Replace(GetConsonantCluster(word), string.Empty);
                string devMagicWord = resultString + GetConsonantCluster(word).ToLower() + "ay";

                return devMagicWord;              
            }


            if (word.Length > 1 && (word[1] == 'Y' || word[1] == 'y'))
            {
                Console.WriteLine("The second character is Y or y.");
                return ProcessTransformedWord(word.Substring(1) + word[0] + "ay").ToLower();
            }
 


            if (word.Length > 1 && IsVowel(word[1]))
            {
                return ProcessTransformedWord(word.Substring(1) + word[0] + "ay").ToLower();
            }
            else
            {
                return ProcessTransformedWord(TransformVowelStartingWord(word).ToLower());
            }
        }


        public string TransformConsonantStartingWord(string word)
        {
            int firstVowelIndex = FindFirstVowelIndex(word);

            if (firstVowelIndex == -1)
            {
                return ProcessTransformedWord(word + "ay");
            }

            string transformedWord = word.Substring(firstVowelIndex) + word.Substring(0, firstVowelIndex) + "ay";

            return ProcessTransformedWord(transformedWord);
        }



        public string ProcessTransformedWord(string transformedWord)
        {
            int exclamationCount = transformedWord.Count(c => c == '!');

            if (exclamationCount > 0)
            {
                transformedWord = transformedWord.Replace("!", "") + new string('!', exclamationCount);
            }

            return transformedWord;
        }

        public int FindFirstVowelIndex(string word)
        {    
            for (int i = 0; i < word.Length; i++)
            {
                if ("aeiouAEIOU".Contains(word[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool IsVowel(char c)
        {
            return "aeiouAEIOU".IndexOf(c) >= 0;
        }


        // tranform from devmagic to english

        public string TransformFromDevMagic(string input)
        {
            var words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var transformedWords = words.Select(word => RemoveYFromBeginning(TransformWordToEng(word))).ToArray();

            return string.Join(" ", transformedWords);
        }


        public string RemoveYFromBeginning(string input)
        {
            if (input.Length > 0 && char.ToLower(input[0]) == 'y')
            {

                return input.Substring(1);
            }
            else
            {
                return input;
            }
        }


        public string TransformWordToEng(string word)
        {

            if (string.IsNullOrEmpty(word))
            {
                return word;
            }


            char lastChar = word[word.Length - 1];
            char punctuation = '\0';

            if (char.IsPunctuation(lastChar))
            {
                punctuation = lastChar;
                word = word.Substring(0, word.Length - 1);
            }


            string transformedWord = TransformWordEng(word);


            if (punctuation != '\0')
            {
                transformedWord += punctuation;
            }

            return transformedWord;
        }

        private string TransformWordEng(string word)
        {

            if (word.EndsWith("ay", StringComparison.OrdinalIgnoreCase))
            {
                word = word.Substring(0, word.Length - 2);
            }


            if (word.Length > 1 && char.IsLetter(word[word.Length - 1]) && char.IsLetter(word[word.Length - 2]))
            {
                char lastChar = word[word.Length - 1];
                char secondLastChar = word[word.Length - 2];

                word = lastChar + word.Substring(0, word.Length - 2) + secondLastChar;
            }
            string lowercasedWord = word.ToLower();

            return lowercasedWord;
        }

    }
}

