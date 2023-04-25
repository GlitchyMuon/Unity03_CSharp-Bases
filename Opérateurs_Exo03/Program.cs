namespace Opérateurs_Exo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez votre BBAN : ");
            string? bban = Console.ReadLine();
            string? two_last = bban?.Substring(10, 2);
            string? be_concat = $"{two_last}{two_last}111400";
            long modulo_be_concat = long.Parse(be_concat)% 97; //ne pas mettre dans la parenthèse car parenthèse prioritaire, donc il va tenter le modulo sur le string par encore parse en long !
            long soustr_modulo_be_concat = 98 - modulo_be_concat;

            Console.WriteLine($"BE{soustr_modulo_be_concat}{bban}");
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