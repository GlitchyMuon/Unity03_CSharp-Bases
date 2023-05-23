using System.Collections;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.Marshalling;
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

            //Essai, pas bon
            /*ushort n_players;
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
            }*/

            #endregion

            #region Exo 7
            /*Réalisez un algorithme nous permettant de déplacer un pion dans un tableau de 10 éléments. Au début, le pion se trouve dans la première case du tableau. Nous pouvons ensuite le déplacer par la gauche (g), par la droite (d) ou de stopper l'algorithme (q).*/

            /*string[] tab = { "♥", ".", ".", ".", ".", ".", ".", ".", ".", "." };
            string proposition;
            const string PION = "♥";
            const string VIDE = ".";


            do
            {
                //étape affichage
                for (int j = 0; j < tab.Length; j++)    //possible foreach (string cell in tab) {Console.Wrrite(cell)}
                {
                    Console.Write(tab[j]);
                }
                Console.WriteLine();

                //étape instruction

                Console.WriteLine("Pour déplacer le pion vers la gauche, taper <g>, vers la droite : <d>. Pour stopper : <q>.");
                proposition = Console.ReadLine().ToLower(); //au cas où l'utilisateur donne un majuscule
                bool moved = false;
                for (int i = 0; i < tab.Length && moved == false; i++) //i < tab.Length (pas -1, sinon il ne vérifie pas la dernière case !!!) OU i <= tab.Length-1
                {
                    if (proposition == "g" && i > 0 && tab[i] == "♥")
                    {

                        tab[i] = VIDE;
                        tab[i - 1] = PION;
                        moved = true;
                        Console.Clear();

                    }
                    if (proposition == "d" && i < tab.Length-1 && tab[i] == "♥")
                    {
                        tab[i] = VIDE;
                        tab[i + 1] = PION;
                        moved = true;
                        Console.Clear();

                    }
                }
            } while (proposition != "q"); //tant que la proposition n'est pas "q", donc sortir du programme, fait/do :

            Console.WriteLine("Fin du programme");*/
            #endregion

            #region Exo 8 - Correction : simplification
            /*Console.OutputEncoding = Encoding.UTF8;
            const string VIDE = "-";
            const string PION = "✨";
            const int TAILLE = 10;

            bool[] grid = new bool[TAILLE];

            int position = 0;
            string direction;


            //Jeu déplacement
            do
            {
                //Affichage 
                Console.Clear();
                foreach (bool cell in grid)
                {
                    Console.WriteLine((cell) ? PION : VIDE);
                }
                Console.WriteLine();

                //Demander direction
                Console.WriteLine("Voulez-vous ammer à (G)auche, à (D)roite ou (Q)uitter");
                direction = Console.ReadLine().ToLower(); // pour récupérer la pression d'une touche : Console.ReadKey().Key;

                //Gestion direction
                switch (direction)
                {
                    case "d":    //Console.Key.D
                        if (grid[grid.Length - 1])
                        {
                        grid[position] = false;
                        position++;
                        grid[position] = true;
                        }
                        break;

                    case "g":   //Console.Key.G
                        if (grid[0])
                        {
                            grid[position] = false; //grid[position--] = false;         //grid[position] = false;
                            position--;             //grid[position] = true;            //grid[--position] = true;
                            grid[position] = true;
                        }
                        break;
                }

            } while (direction != "q");*/

            #endregion

            #region Exo 8
            /*Réalisez un algorithme permettant de rechercher une valeur dans un tableau. Si la valeur se trouve bien dans le tableau, nous affichons sa position.*/

            int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            Console.WriteLine("Quelle valeur cherchez-vous ?");
            int searched_value = int.Parse(Console.ReadLine());
            List<int> found = new List<int>();

            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == searched_value)
                {
                    Console.WriteLine($"La valeur recherchée se trouve à l'indice {i}.");
                    found.Add(i);
                }

            }
            if (found.Count == 0)
            {
                Console.WriteLine("La valeur recherchée n'est pas dans ce tableau.");
            }
            else
            {
                Console.WriteLine("La valeur recherchée se trouve en indice :");
                foreach (int i in found)
                {
                    Console.Write($"{i},");
                }
                Console.WriteLine("\b.");   //supprime le dernier caractère (idem backspace) et met un point
            }
            #endregion
        }
    }
}