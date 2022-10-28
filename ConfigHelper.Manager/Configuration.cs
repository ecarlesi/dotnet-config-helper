using Microsoft.Extensions.Configuration;
using System.Diagnostics;

namespace ConfigHelper.Manager
{
    public static class Configuration
    {
        public static T GetCustomSection<T>(string sectionName)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.Development.json", optional: true, reloadOnChange: true);

            IConfigurationRoot config = builder.Build();

            return config.GetSection(sectionName).Get<T>();
        }
    }
}