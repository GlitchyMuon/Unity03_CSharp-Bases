using System.Linq;

namespace Demo_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dictionary<ConsoleKey, string> msg_per_key = new Dictionary<ConsoleKey, string>();

            msg_per_key.Add(ConsoleKey.G, "On va à gauche !");
            msg_per_key.Add(ConsoleKey.D, "On va à droite !");
            msg_per_key.Add(ConsoleKey.G, "Ciao !");

            msg_per_key[ConsoleKey.Q] = "Au revoir !";
            ConsoleKey key;

            do
            {
                Console.WriteLine("Utiliser G, D ou Q :");

                foreach (ConsoleKey key_dico in msg_per_key.Keys)
                {
                    Console.Write($"{key_dico}");
                }
                Console.WriteLine("\b :");
                key = Console.ReadKey().Key;
                Console.WriteLine(msg_per_key[key]);

                if (msg_per_key.ContainsKey[key]); //je vérifie si mon dictionnaire contien la clé (est présente), sinon crash...
                {
                    Console.WriteLine(msg_per_key[key]);
                }
            }while (key != ConsoleKey.Q);*/

            #region Exo 10
            /*En considérant une liste d'entiers trié dans l'ordre croissant, réaliser un algorithme étant capable d'insérer une nouvelle valeur dans la liste de façon à ce que la liste reste triée. Le but n'est évidemment pas d'insérer la valeur à la fin et de trier après mais bien de l'insérer au bon endroit directement.*/

            //List<int> ma_liste = new List<int>();
            //Ou
            //List<int> ma_liste = new List<int>() {12, 15, 18, 24};

            /*List<int> nb_croissant = new List<int>() { 1, 3, 4, 5, 5, 6 };
            string temp;

            Console.WriteLine("Veuillez entrer un nombre à rajouter à la liste :");
            int nb_ajout = int.Parse(Console.ReadLine());*/

            /*if (nb_ajout >= nb_croissant[nb_croissant.Count - 1]) //nombre à la fin de ma liste
            {
                nb_croissant.Add(nb_ajout);
            }
            else
            {
                nb_croissant.Add(nb_croissant[nb_croissant.Count - 1]);   //sinon, ajoute un duplicata en dernier)
                for (int i = nb_croissant.Count - 3; i >= 0; i--) //Initialisation par la fin. Attention : count -1 est la copie du nombre déjà analysée, count - 2 est le nombre déjà analysé, donc count - 3 est le nombre à vérifier.
                {
                    if (nb_croissant[i] > nb_ajout)
                    {
                        nb_croissant[i + 1] = nb_croissant[i];
                    }
                    else
                    {
                        nb_croissant[i + 1] = nb_ajout; //la case de copie devient mon nombre ajouté
                        i = -1; // il sort de la condition car -1 est plus petit que 0
                    }
                }
            }*/

            //Avec Insert();

            /*int position = 0;
            bool found = false;

            for (int i = 0; i <nb_croissant.Count && !found; i++)
            {
                position = i;
                found = true;
            }
            if (found)
            {
                nb_croissant.Insert(position, nombre_ajout);
            }
            else 
            {
                nb_croissant.Add(nb_ajout);
            }*/


            #endregion

            #region Exo 11
            /*Réalisez un algorithme dans lequel nous devons rechercher une valeur (entrée par l'utilisateur) dans une liste d'entiers. Si on trouve cette valeur, nous devons la supprimer de la liste.*/


            #endregion
        }
    }
}