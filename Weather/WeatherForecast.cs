using System;
using Weather.Core;

namespace Weather
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => TemperatureHelper.GetFarenheit(TemperatureC);

        public string Summary => TemperatureHelper.GetSummary(TemperatureC);
    }
}
