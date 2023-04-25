//Corrigé et amélioré avec le if (bban_str.Length == 12 && long.TryParse(bban_str, out _))

namespace Opérateurs_Exo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez votre IBAN :");
            string? iban_str = Console.ReadLine();
            if (iban_str?.Length == 16 && long.TryParse(iban_str?.Substring(4, 12), out _)) // pas de out, il ne retourne rien, car on n'en a pas besoin
            {
                string? ten_first = iban_str?.Substring(4, 10); //si bban (0, 10)
                string? two_last = iban_str?.Substring(14, 2); //si bban (10)

                long ten_first_parse = long.Parse(ten_first); //long pas int, car ce qu'on a est plus grand
                short two_last_parse = short.Parse(two_last);

                if (ten_first_parse % 97 == two_last_parse)
                {
                    Console.WriteLine("OK");
                }
                else if (ten_first_parse % 97 == 0 && two_last_parse == 97) // sinon on peut le mettre dans la 1ère condition avec un || ou. Mieux si on a 10000 lignes !
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("KO");
                }
            }
            else
            {
                Console.WriteLine("Ce n'est pas un BBAN valide...");
            }
        }
    }
}