using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Demo_Conditionnel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel est votre âge ?");
            string? age_str = Console.ReadLine();

            int age;
            bool age_isConvert = int.TryParse(age_str, out age);

            if (age_isConvert == true && age >= 18)
            {
                Console.WriteLine("Quel est votre nationalité ?");
                string? nationalite = Console.ReadLine();
                /*if (nationalite.ToUpper() == "Belge".ToUpper()) 
                {
                    Console.WriteLine("Bienvenu sur notre site concours !");

                }
                else 
                {
                    Console.WriteLine("" +
                        $"Votre nationalité : '{nationalite}' n'est pas prise en charge... ");
                }*/

                switch(nationalite.ToLower()) //on peut mettre ToLower mais pas dans les case
                {
                    case "belge":
                        Console.WriteLine("Bienvenu sur notre site concours !");
                        break;

                    case "français":
                        Console.WriteLine("Macron démission ! Mais bienvenu quand même ...");
                        break;

                    case "québecquois":
                        Console.WriteLine("Monte dans l'char ! Tabernacle !");
                        break;

                    case "suisse":
                        Console.WriteLine("Bienvvvveeennuuuue");
                        break;

                    default:
                        Console.WriteLine($"Votre nationalité : {nationalite} n'est pas pris en charge...");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Reviens quand tu seras majeur.");
            }
        }
    }
}