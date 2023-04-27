namespace Opérateurs_Exo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez votre BBAN : ");
            string? bban_str = Console.ReadLine();

            if (bban_str?.Length == 12 && long.TryParse(bban_str, out _))
            {
                string? two_last = bban_str?.Substring(10, 2);
                string? be_concat = $"{two_last}{two_last}111400";
                long be_concat_long = long.Parse(be_concat);
                short modulo = (short)(be_concat_long % 97); //ne pas mettre dans la parenthèse car parenthèse prioritaire, donc il va tenter le modulo sur le string par encore parse en long !
                short soustr_modulo_be_concat = (short)(98 - modulo); //le modulo va donner une valeur entre 1 et 96 
                
                                           //interpolation juste pour le 0             //interpolation pour le soustr
                Console.WriteLine($"IBAN : BE{((soustr_modulo_be_concat < 10)? "0":"")}{soustr_modulo_be_concat}{bban_str}"); //si on utilise la string bban_str, les 0 restent, mais pas si on l'utilise converti, car le parse enlève les 0.
                //added ternary operator because we need a condition if the number after country suffix BE, is smaller than 10. So that the 0 doesn't get deleted.
            }
            else
            {
                Console.WriteLine("BBAN non valide ...");
            }
        }
    }
}
/* Transformer un compte bancaire BBAN Belge (xxx-xxxxxxx-xx) en IBAN (BExx-xxxx-xxxx-xxxx). 
 * BBAN : 732-0382076-44 → IBAN : BE55 7320 3820 7644
1. Récupérez les 2 derniers nombres : 732-0382076-44
2. Concaténez le 2 fois suivi du code 111400 (représentant le code BE0) : 4444111400
3. Effectuez l’opération de soustraction de 98 par le modulo 97 du code précédent : 98 - (4444111400 % 97) → 98 - 43 → 55
4. Unifiez le tout : BE55 7320 3820 7644
 */