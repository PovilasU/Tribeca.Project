namespace Tribeca.WebAPI.Helpers
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

        //Extension method to return star sign based on month

        public static string StarSign(this string birthDate)
        {
            DateTime date = DateTime.Parse(birthDate);

            int birthMonth = date.Month;

            string[] starSigns = {
            "Capricorn", "Aquarius", "Pisces", "Aries",
            "Taurus", "Gemini", "Cancer", "Leo",
            "Virgo", "Libra", "Scorpio", "Sagittarius"
        };

            return starSigns[birthMonth - 1];
        }

    }
}
