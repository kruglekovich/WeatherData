using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherData
{
    class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private Subject weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("Текщая состояние: " + temperature + "°С и " + humidity + "% влажности и " + pressure + "мм давления");
        }

        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature; ;
            this.humidity = humidity;
            this.pressure = pressure;

            display();
        }
    }
}
