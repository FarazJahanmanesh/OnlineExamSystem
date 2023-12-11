using Microsoft.Extensions.Configuration;

namespace Application.Helpers
{
    public static class General
    {
        public static IConfigurationRoot Configuration;
        public static string GetConfigurationValue(string section)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            Configuration = builder.Build();
            var connectionString = Configuration.GetSection(section).Value.ToString();
            return connectionString;
        }
        public static string ReplacePersianDigits(string input)
        {
            string[] persianDigits = { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };
            string[] englishDigits = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            for (int i = 0; i < persianDigits.Length; i++)
            {
                input = input.Replace(persianDigits[i], englishDigits[i]);
            }

            return input;
        }
        //public static string ReplacePersianDigits(this string input)
        //{
        //    return input.Replace("۱", "1")
        //                .Replace("۲", "2")
        //                .Replace("۳", "3")
        //                .Replace("۴", "4")
        //                .Replace("۵", "5")
        //                .Replace("۶", "6")
        //                .Replace("۷", "7")
        //                .Replace("۸", "8")
        //                .Replace("۹", "9")
        //                .Replace("۰", "0");
        //}
    }
}
