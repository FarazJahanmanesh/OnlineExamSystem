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
    }
}
