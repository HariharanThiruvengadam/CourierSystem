﻿using Microsoft.Extensions.Configuration;

namespace CourierManagement.Utility
{
    
    internal static class ConnectionUtil
    {
        private static IConfiguration _iconfiguration;
        static ConnectionUtil()
        {
            GetAppSettingsFile();
        }

        public static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appSettingsConfig.json");
            _iconfiguration = builder.Build();

        }

        public static string GetConnectionString()
        {
            return _iconfiguration.GetConnectionString("LocalConnectionString");
        }
    }
}
