using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Methode01_Celsius_Fahrenheit.Struct
{
    public struct Celsius
    {
        public double temperature;

        public Fahrenheit ConvertToF()
        {
            //°F =( °C x 1,8 ) + 32
            Fahrenheit fahrenheit = new Fahrenheit();
            fahrenheit.temperature = (temperature * 1.8) + 32;
            return fahrenheit; 
            //pas le calcul, mais l'objet contenant le résultat



        }
    }
}
