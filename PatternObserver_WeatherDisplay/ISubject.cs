using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver_WeatherDisplay
{
    interface ISubject
    {
        void registerObserver(IObserver o);
        void removeObserver(IObserver o);
        void notifyObserver();
    }

    class WeatherData : ISubject
    {
        public List<IObserver> observers {get;set;}
        public float temperature { get; set; }
        public float humidity { get; set; }
        public float pressure { get; set; }

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void notifyObserver()
        {
            foreach(var observer in observers)
            {
                observer.update();
            }
        }

        public void registerObserver(IObserver o) => observers.Add(o);

        public void removeObserver(IObserver o) => observers.Remove(o);

        public void measurementsChanged()
        {
            notifyObserver();
        }

        public void setMeasurements(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();        
        }
    }


}
