using System.Security.Cryptography.X509Certificates;

namespace Exo_Enum
{
    internal class Program
    {
        public enum ColorFamily { Coeur, Carreau, Pique, Trefle } //pas besoin de ";"

        public enum Values { As = 14, deux = 2, trois = 3, quatre = 4, cinq = 5, six = 6, sept = 7, huit = 8, neuf = 9, dix = 10, Valet = 11, Dame = 12, Roi = 13 }

        public struct Carte
        {
            public ColorFamily couleurs;
            public Values valeurs;
        }
        static void Main(string[] args)
        {
            Carte[] deck = new Carte[52];
            int i = 0;
            foreach (string couleur in Enum.GetNames<ColorFamily>())
            {
                foreach (string valeur in Enum.GetNames<Values>()) 
                {
                    deck[i].valeurs = Enum.Parse<Values>(valeur);
                    deck[i].couleurs = Enum.Parse<ColorFamily>(couleur);
                    i++;
                }
            }
            foreach (Carte carte in deck)
            {
                Console.WriteLine($"La carte du {carte.valeurs} de {carte.couleurs}");
            }
            
        }
    }
}