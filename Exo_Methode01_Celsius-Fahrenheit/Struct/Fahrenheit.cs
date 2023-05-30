using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Methode01_Celsius_Fahrenheit.Struct
{
    public struct Fahrenheit
    {
        //°C = (°F - 32) / 1,8*/
        public double temperature;

        public Celsius ConvertToC()
        {
            Celsius celsius = new Celsius();
            celsius.temperature = (temperature - 32) / 1.8;
            return celsius;
        }
    }
}
