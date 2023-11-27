namespace Tribeca.WebAPI
{
    //Method to translate english to Dev Magic
    static class EnglishToDevMagicExtensions
    {
        public static string EnglishToDevMagic(this string str) 
        {
            //TODO: implement methond
         return "EnglishToDevMagic Test: " + str.ToLower();
        }

        public static string DevMagicToEnglish(this string str)
        {
            //TODO: implement methond
            return "DevMagicToEnglish test: " + str.ToLower();
        }
    }
}
