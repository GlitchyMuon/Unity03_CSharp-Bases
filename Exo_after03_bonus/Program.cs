/*Créez une application permettant de savoir si une année est Bissextile ou pas.
*Une année est dite bissextile lorsqu'elle est divisible par 4 mais pas par 100.
*Une année peut être bissextile si celle-ci est divisible par 400.
*Bissextile : 2024, 2000        Non-bissextile : 1987, 1900
*/

namespace Exo_bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcul d'année bissextile ou non. Donne une année : ");
            string year_str = Console.ReadLine();

            int year;
            bool n_isConvert = int.TryParse(year_str, out year);

            if (n_isConvert)
                if ((year%4 == 0 && year%100 != 1) || year % 400 == 0)
                    // les années qui ne font pas partie des siècle OU 1 année bissextile tous les 400ans
                {
                    Console.WriteLine($"L'année {year} est bissextile.");
                }
                else
                {
                    Console.WriteLine($"L'année {year} n'est pas bissextile.");
                }

        }
    }
}