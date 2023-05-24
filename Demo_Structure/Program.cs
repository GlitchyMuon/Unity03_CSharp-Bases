using Demo_Structure.Struct;

namespace Demo_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal monAnimal = new Animal();
            monAnimal.Couleur = "Jaune";
            monAnimal.Espèce = "Pangolin";
            monAnimal.Nom = "Sabelette";
            monAnimal.Habitat = "dans la jungle en Chine";
            monAnimal.Sauvage = true;

           string result = $"Je m'appelle {monAnimal.Nom}, J'habite {monAnimal.Habitat} et je suis un {monAnimal.Espèce} de couleur {monAnimal.Couleur}.";

            if (monAnimal.Sauvage)
            {
                result += "Attention, je suis suavage !!!";
            }
            else
            {
                result += "Viens me faire un câlin :) !";
            }

            Console.WriteLine(result);
        }
    }
}