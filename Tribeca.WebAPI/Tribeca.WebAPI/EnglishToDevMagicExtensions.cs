namespace Tribeca.WebAPI
{
    
    static class EnglishToDevMagicExtensions
    {
        //Extension method to translate english to Dev Magic
        public static string EnglishToDevMagic(this string str) 
        {
            //TODO: implement methond
         return "EnglishToDevMagic Test: " + str.ToLower();
        }

        //Extension method to translate Dev Magic to english
        public static string DevMagicToEnglish(this string str)
        {
            //TODO: implement methond
            return "DevMagicToEnglish test: " + str.ToLower();
        }
    }
}
