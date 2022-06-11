using System;

namespace PatternObserver_WeatherDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.setMeasurements(80, 65, 30.4F);
            weatherData.setMeasurements(82, 70, 29.2F);
            weatherData.setMeasurements(78, 90, 29.2F);
        }

    }
}
