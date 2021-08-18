using System;
using System.Configuration;

namespace TestProjectRS
{
    public class EnvironmentUtils
    {
        public static string GetVar(string varName)
        {
            return Environment.GetEnvironmentVariable(varName) ?? ConfigurationManager.AppSettings.Get(varName);
        }
    }
}
