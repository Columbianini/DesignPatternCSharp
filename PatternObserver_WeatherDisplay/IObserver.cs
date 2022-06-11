using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver_WeatherDisplay
{
    interface IObserver
    {
        void update();
    }

    class CurrentConditionsDisplay : IObserver
    {
        public float temperature { get; set; }
        public float humidity { get; set; }
        public WeatherData weatherData { get; set; }

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void update()
        {
            this.humidity = weatherData.humidity;
            this.temperature = weatherData.temperature;
            display();
        }

        public void display()
        {
            Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
        }
    }

    class StatisticsDisplay : IObserver
    {
        public List<float> temperatures { get; set; }
        public WeatherData weatherData { get; set; }
        public StatisticsDisplay(WeatherData weatherData)
        {
            temperatures = new List<float>();
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void update()
        {
            temperatures.Add(weatherData.temperature);
            display();
        }

        public void display() => Console.WriteLine($"Avg/Max/Min temperature: {temperatures.Average():0.0}/{temperatures.Max():0.0}/{temperatures.Min():0.0}");
    }

    class ForecastDisplay : IObserver
    {
        public float lastPressure { get; set; }
        public float currentPressure { get; set; }
        public WeatherData weatherData { get; set; }
        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void update()
        {
            currentPressure = weatherData.pressure;
            display();
            lastPressure = currentPressure;
        }

        public void display()
        {
            if(lastPressure == currentPressure)
            {
                Console.WriteLine("More of the same");
            }
            else if(lastPressure < currentPressure)
            {
                Console.WriteLine("Improving weather on the way");
            }
            else
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }
    }


    class HeatIndexDisplay : IObserver
    {
        public float temperature { get; set; }
        public float humidity { get; set; }
        public WeatherData weatherData { get; set; }
        public HeatIndexDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void update()
        {
            temperature = weatherData.temperature;
            this.humidity = weatherData.humidity;
            display();
        }

        public void display() => Console.WriteLine($"Heat Index is {computeHeatIndex(temperature, humidity)}");

        private float computeHeatIndex(float t, float rh)
        {
            float index = (float)((16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh) +
                (0.00941695 * (t * t)) + (0.00728898 * (rh * rh)) +
                (0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh)) +
                (0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) + (0.0000291583 *
                (rh * rh * rh)) + (0.00000142721 * (t * t * t * rh)) +
                (0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh)) +
                0.000000000843296 * (t * t * rh * rh * rh)) -
                (0.0000000000481975 * (t * t * t * rh * rh * rh)));
            return index;
        }

    }
}
