using System.Collections;
using System.Text;

namespace Exos_Tableaux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exo 1
            ///*Ecrire un algorithme qui saisit 6 entiers et les stocke dans un tableau, puis affiche le contenu de ce tableau une fois qu’il est rempli.*/

            /*ushort[] liste_entier = new ushort[6];
            ushort proposition_count = 0;

            for (int i = 0;  proposition_count < liste_entier.Length; i++)
            { 
                Console.WriteLine("Entrer un entier : ");
                ushort proposition_n = ushort.Parse(Console.ReadLine());
                liste_entier[i] = proposition_n;
                proposition_count += 1;
            }

            for (int i = 0; i < liste_entier.Length; i++)
            {
                Console.Write("Contenu du tableau : " + liste_entier[i]);
            }*/
            #endregion

            #region Exo 2
            /*BONUS: initialiser un tableau de 10 entiers avec les valeurs 2, 4, 8, 16, 32, 64, 128, 256, 512, 
                1024 à l’aide d’une boucle. Ensuite, à l’aide d’une boucle, afficher la valeur de chaque cellule
                    du tableau avec l’opération Ecrire().*/

            /*int[] ints = new int[11];
            ints[0] = 2;

            for (int i = 1; i < ints.Length; i++)
            {
                //ints[0] *= 2
                ints[i] = ints[i-1] * 2; //i-1 car on veut le précédent et le multiplier * 2
            }

            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine("Valeur de chaque cellule du tableau : " + ints[i]);
            }

            // variante de solution :
            //int[] monTableau = new int[10];
            //int chiffre = 2;
            //monTableau[0] = chiffre;

            for (int = 1; i < monTableau.Length; i++)
            {
                chiffre *= 2;
                monTableau[i] = chiffre;
            }

            // variante d'affichage :
            //foreach (var item in ints)
            //{
            //     Console.WriteLine(item + " ");
            //}
            */
            #endregion

            #region Exo 3
            ushort n_players;
            string n_players_str;
            double score;

            Console.WriteLine("Nombre de joueurs : ");
            n_players_str = Console.ReadLine();
            n_players = ushort.Parse(n_players_str);
            double[] scores = new double[n_players];

            for (int i = 0; i < n_players; i++) 
            {
                Console.WriteLine("Entrez le score pour le joueur : " + i);
                score = double.Parse(Console.ReadLine());
                scores[i] = score;
            }

            foreach (var player in scores)
            {
                //calculer la moyenne des scores et l'afficher
                //Console.WriteLine(player);
            }

            #endregion
        }
    }
}