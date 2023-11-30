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
            if (IsVowel(word[0]))
            {
                return TransformVowelStartingWord(word);
            }
    
            else if (word[0] == 'y' || word[0] == 'Y')
            {
                return TransformYStartingWord(word);
            }
       
            else
            {
                return TransformConsonantStartingWord(word);
            }
        }

        private string TransformVowelStartingWord(string word)
        {            
            return word + "yay"; 
        }

        private string TransformYStartingWord(string word)
        {         
            if (word.Length > 1 && IsVowel(word[1]))
            {
               
                return word.Substring(1) + word[0] + "ay";
            }
            else
            {                
                return TransformVowelStartingWord(word);
            }
        }

        private string TransformConsonantStartingWord(string word)
        {      
            int firstVowelIndex = FindFirstVowelIndex(word);
            if (firstVowelIndex == -1)
            {              
                return word + "ay";
            }         
            return word.Substring(firstVowelIndex) + word.Substring(0, firstVowelIndex) + "ay";
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
