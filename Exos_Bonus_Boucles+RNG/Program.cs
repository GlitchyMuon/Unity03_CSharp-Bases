using System.Text;

namespace Exos_Bonus_Boucles_RNG
{
    internal class Program
    {
        static Random RNG  = new Random(); // !!! La déclaration de RNG se fait dans la classe, pas dans le Main() !
                                           // !!! La variable doit être static (= variable globale)
        static void Main(string[] args)
        {
            #region exo Bonus : Plus ou Moins simple
            /* + Une application reçoit deux nombres d'utilisateurs :
             * - juste_prix
             * - proposition
             * + Lorsque la proposition est plus petit que juste_prix :
             *   L'application répond : «C'est plus»
             *   
             * + Lorsque proposition est plus grand que juste_prix :
             *   L'application répond : «C'est moins»
             *   
             * + Si proposition est égal à juste_prix :
             *   L'application répond :
             *   «Bravo, vous avez deviné le Juste Prix !»
             */

            // Avec boucle while et if else if
            /*string juste_prix_str;
            string proposition_str;

            Console.WriteLine("Indiquez le juste prix :");
            ushort juste_prix = ushort.Parse(Console.ReadLine());

            Console.WriteLine("Joueur ! Quel est selon vous le Juste Prix ?");
            ushort proposition = ushort.Parse(Console.ReadLine());
            Console.Clear();

            while (proposition != juste_prix)
            {
                if (proposition > juste_prix)
                {
                    Console.WriteLine("C'est moins.");
                    Console.WriteLine("Joueur ! Quel est selon vous le Juste Prix ?");
                    proposition_str = Console.ReadLine();
                    proposition = int.Parse(proposition_str);
                }
                else if (proposition < juste_prix)
                {
                    Console.WriteLine("C'est plus.");
                    Console.WriteLine("Veuillez faire une proposition de prix :");
                    proposition_str = Console.ReadLine();
                    proposition = int.Parse(proposition_str);
                }
            }

            Console.WriteLine("Bravo, vous  avez deviné le Juste Prix !");*/

            //Avec boucle do ... while

            /*Console.Clear();
            *ushort juste_prix;
            *ushort proposition;
            *Console.WriteLine("Bienvenu au jeu du Juste Prix !");
            *Console.WriteLine("Indiquez le juste prix :");
            *juste_prix = ushort.Parse(Console.ReadLine());
            *Console.Clear();

            do
            {
                Console.WriteLine("Veuillez faire une proposition de prix :");
                proposition = ushort.Parse(Console.ReadLine());

                if (proposition > juste_prix)
                {
                    Console.WriteLine("C'est moins.");
                }
                else if (proposition < juste_prix)
                {
                    Console.WriteLine("C'est plus.");
                }
            }
            while (proposition != juste_prix);
            Console.WriteLine("Bravo, vous  avez deviné le Juste Prix !");*/

            #endregion

            #region plus ou Moins : Avancé

            /*Plus ou moins : avancé
 
            • juste_prix reçoit un nombre aléatoirement entre 1 et 100
 
            • Si proposition est égal à juste_prix
                L'application répond : 
                « Bravo, vous avez devinez le Juste Prix en # tentative(s)! ».
 
            # est un nombre venant d'une variable.
            Le 's' de "tentative" ne doit apparaitre que si nécessaire.*/

            /*int juste_prix = RNG.Next(1, 101);
            ushort proposition;
            ushort tries = 0;

            Console.Clear();
            Console.WriteLine("Bienvenu au jeu du Juste Prix !");

            do
            {
                Console.WriteLine("Veuillez faire une proposition de prix :");
                proposition = ushort.Parse(Console.ReadLine());
                tries++;

                if (proposition > juste_prix)
                {
                    Console.WriteLine("C'est moins.");
                }
                else if (proposition < juste_prix)
                {
                    Console.WriteLine("C'est plus.");
                }
            }
            while (proposition != juste_prix);
            Console.WriteLine($"Bravo, vous  avez deviné le Juste Prix en {tries} tentative{((tries > 1) ? "s" : "")} !");*/
            #endregion


            #region Plus ou moins : Avancé+

            /*• Le joueur doit choisir un niveau de difficulté
 
            • juste_prix reçoit :
                Si difficulté "facile": un nombre aléatoirement entre 1 et 10
                Si difficulté "moyen": un nombre aléatoirement entre 1 et 100
                Si difficulté "dificile": un nombre aléatoirement entre 1 et 1000
 
            • Le joueur est limité à 10 tentatives.
 
            • Si proposition est égal à juste_prix
                L'application répond : 
                « Bravo, vous avez devinez le Juste Prix en # tentative(s)! ».
              Sinon l'application répond :
                « Désolé, le Juste Prix le juste prix était de #! ».
 
            • On propose au joueur de rejouer une partie!*/

            Console.Clear();
            Console.WriteLine("Bienvenu au jeu du Juste Prix !");
            Console.WriteLine("Choissisez un niveau de difficulté (facile, moyen ou difficile): ");
            string difficulty = Console.ReadLine();
            int juste_prix;
            ushort proposition;
            ushort tries = 0;

            switch((difficulty?.ToLower()))
            {
                case "facile":
                    juste_prix = RNG.Next(1, 11);
                    break;

                case "moyen":
                    juste_prix = RNG.Next(1, 101);
                    break;
                case "difficile":
                    juste_prix = RNG.Next(1, 1001);
                    break;
                default:
                    Console.WriteLine("Vous n'avez pas choisi de difficulté...\nDifficulté par défaut :... DIFFICILE !");
                    juste_prix = RNG.Next(1, 1001);
                    break;
            }

            do
            {
                Console.WriteLine("Veuillez faire une proposition de prix :");
                proposition = ushort.Parse(Console.ReadLine());
                tries++;

                if (proposition > juste_prix)
                {
                    Console.WriteLine("C'est moins.");
                }
                else if (proposition < juste_prix)
                {
                    Console.WriteLine("C'est plus.");
                }
            }
            while (proposition != juste_prix);
            Console.WriteLine($"Bravo, vous  avez deviné le Juste Prix en {tries} tentative{((tries > 1) ? "s" : "")} !");


            #endregion
        }
    }
}