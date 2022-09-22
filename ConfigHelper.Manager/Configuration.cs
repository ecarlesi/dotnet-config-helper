using Microsoft.Extensions.Configuration;
using System.Diagnostics;

namespace ConfigHelper.Manager
{
    public static class Configuration
    {
        public static T GetCustomSection<T>(string sectionName)
        {
            return GetCustomSection<T>(sectionName, "appsettings.json");
        }

        public static T GetCustomSection<T>(string sectionName, string filename)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(filename);
            IConfigurationRoot config = builder.Build();

            return config.GetSection(sectionName).Get<T>();
        }
    }
}