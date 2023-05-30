using Exo_Methode01_Celsius_Fahrenheit.Struct;

namespace Exo_Methode01_Celsius_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Formule
            /*°F =( °C x 1,8 ) + 32
              °C = (°F - 32) / 1,8*/
            Celsius current_celsius = new Celsius() { temperature = 25 };
            Fahrenheit current_fahrenheit = current_celsius.ConvertToF();

            Fahrenheit tomorrow_fahrenheit = new Fahrenheit() { temperature = 250 };

            Celsius tomorrow_celsius = tomorrow_fahrenheit.ConvertToC();

            Console.WriteLine($"Aujourd'hui il fait {current_celsius.temperature}°C.\nDemain il fera{tomorrow_celsius.temperature}°C.\tEn Fahrenheit : {tomorrow_fahrenheit.temperature}°F");
        }
    }
}