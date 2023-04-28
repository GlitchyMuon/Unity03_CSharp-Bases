namespace Demo_Boucles_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo for(..., ..., ...) simple boucle

            /*const string PASSWORD = "Test1234=";
            Console.WriteLine("Entrez votre mot de passe : ");
            string insert_password = Console.ReadLine();
            for (int i = 0; i < 3 && insert_password != PASSWORD; i++) 
            {
                Console.WriteLine($"{insert_password} n'est pas le bon mot de passe...\nMote de passse :");
                insert_password = Console.ReadLine();
            }
            if (insert_password == PASSWORD)
            {
                Console.WriteLine("Bienvenu 👻 !");
            }
            else
            {
                Console.WriteLine("Trop de tentatives ont échoués ...");*/
            #endregion

            #region Exo bonus table multiplication
            // Exo Bonus 

            // A l'aide de deux boucles FOR, afficher les tables de multiplication de 1 à 9.
            // Affichage :
            // Table de 1 :
            // 1 x 1 = 1 ; 1 x 2 = 2 ; 1 x 3 = 3 ; 1 x 4 = 4 ; 1 x 5 = 5 ; 1 x 6 = 6 ; 1 x 7 = 7 ; 1 x 8 = 8 ; 1 x 9 = 9 ; 1 x 10 = 10

            for (int table = 1; table <= 10; table++)
            {
                Console.WriteLine($"Table de {table}");

                for (int multi = 1; multi <= 10; multi++)
                {
                    Console.Write($"{table} X {multi} = {table * multi} ; "); //pas WriteLine car fait d'office un retour à la ligne
                }
                Console.WriteLine(); //mettre ici car il va faire un \n après chaque dizaines, du calcul.
            }
            #endregion
        }
    }
}

