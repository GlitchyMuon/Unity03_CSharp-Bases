using System.Text;

namespace Demo_Boucles_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region exo boucle bloquant avec do while
            //string nb1_str;
            //short nb1;
            //bool isConvert;
            //string message = "Veuillez introduire un nombre (entre 1e et 10) :";
            //do
            //{
            //    Console.WriteLine(message);
            //    nb1_str = Console.ReadLine();
            //    message = $"{nb1_str} n'est pas un nombre.\nVeuillez introduire un nombre (entre 1e et 10) :";
            //    isConvert = short.TryParse(nb1_str, out nb1);
            //}
            //while (!isConvert); //vérifie s'il n'est pas converti, sinon refait l'instruction + haut
            #endregion

            #region Exo Bonus Do While
            //Exo Bonus
            //Créez une application permettant à un utilisateur d'entrer un mot de passe.
            //L'utilisateur a 3 trentatives.
            //Si une tentative est correcte, on arrête le programme en le saluant, sinon on lui demande de réessayer.
            //Faites-le avec une boucle "do... while".
            const string PASSWORD = "Cshark";
            ushort limit = 3; //commence à partir de 0, un short inclus les négatifs.
            string password_try; //déclarer la variable à l'avance car ne pourra pas être utilisé dans d'autres while ou if, car aurait été déclarer dans la boucle
            string message = "Entrez votre mot de passe :";

            do
            {
                Console.WriteLine(message);
                password_try = Console.ReadLine();
                Console.WriteLine($"Vous avez {limit} tentatives.");
                message = $"{password_try} n'est pas le bon mot de passe.\nVeuillez réessayer :";
                limit--;
            }
            while (password_try != PASSWORD && limit > 0); // pas d'accolades dans le while du do-while
            if (password_try == PASSWORD)
            {
                Console.WriteLine("Bienvenu 😊!");
            }
            else
            {
                Console.WriteLine("Trop de tentatives ont échoués !");
            }
            #endregion

        }
    }
}