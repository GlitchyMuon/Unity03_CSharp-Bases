namespace Exo_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encodez un nombre entier : ");
            string n1_str = Console.ReadLine();

            Console.WriteLine("Encodez un deuxième nombre entier : ");
            string n2_str = Console.ReadLine();

            //int n1_parse = int.Parse(n1_str);
            //int n2_parse = int.Parse(n2_str);

            //Console.WriteLine($"Les nombres convertis sont : {n1_parse} et {n2_parse} de type {n1_parse.GetType()} et {n2_parse.GetType()}");
            //Console.WriteLine($"La somme est {n1_parse + n2_parse} ");

            int n1_try_parse; 
            int n2_try_parse;

            // Pas besoin de sauvegarder dans une variable -> bool n1_isok =        car pas utitilisé
            int.TryParse(n1_str, out n1_try_parse);
            // on peut déclarer une variable dans le out
            //int.TryParse(n1_str, out int n1);
            //pour éviter de stocker une variable pour rien, on peut faire : 
            //int.TryParse(Console.ReadLine(), out int n1);
            

            int.TryParse(n2_str, out n2_try_parse);
            //bool n2_isok = 

            //Console.WriteLine($"Les nombres ont été converti : 1er nombre : {n1_isok}, 2ième nombre : {n2_isok}.");
            Console.WriteLine($"La somme en est {n1_try_parse + n2_try_parse}.");
            //Console.WriteLine($"Les nombres convertis sont : {n1_try_parse} et {n2_try_parse}. \nLa somme en est {n1_try_parse + n2_try_parse}.");
            //Console.WriteLine($"Leurs types sont : {n1_try_parse.GetType()} et {n2_try_parse.GetType()}");

        }
    }
}