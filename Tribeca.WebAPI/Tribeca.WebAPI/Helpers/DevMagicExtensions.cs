namespace Tribeca.WebAPI.Helpers
{
    static class DevMagicExtensions
    {
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
