using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weather.Core
{
    public static class TemperatureHelper
    {
        public static int GetFarenheit(int tempC)
        {
            return 32 + (int)(tempC / 0.5556);
        }
        public static string GetSummary(int tempC)
        {
            string summary = String.Empty;
            switch (tempC)
            {
                case int n when (n < 0):
                    summary = "Freezing";
                    break;
                case int n when (n < 4):
                    summary = "Bracing";
                    break;
                case int n when (n < 7):
                    summary = "Chilly";
                    break;
                case int n when (n < 12):
                    summary = "Cool";
                    break;
                case int n when (n < 16):
                    summary = "Mild";
                    break;
                case int n when (n < 20):
                    summary = "Warm";
                    break;
                case int n when (n < 24):
                    summary = "Balmy";
                    break;
                case int n when (n < 28):
                    summary = "Hot";
                    break;
                default:
                    summary = "Sweltering";
                    break;

            }
            return summary;
        }
    }
}
