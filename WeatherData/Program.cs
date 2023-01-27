using System;

namespace WeatherData
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay current = new CurrentConditionsDisplay(weatherData);

            weatherData.setMeasurements(-10, 81, 752);
            weatherData.setMeasurements(-9, 82, 751);
            weatherData.setMeasurements(-8, 80, 750);
        }
    }
}
