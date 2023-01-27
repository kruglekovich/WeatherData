using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherData
{
    interface Observer
    {
            void update(float temperature, float humidity, float pressure);
        
    }
}
