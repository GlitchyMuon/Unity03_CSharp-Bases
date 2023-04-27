namespace Demo_Boucles_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo for(..., ..., ...) simple boucle

            const string PASSWORD = "Test1234=";
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
                Console.WriteLine("Trop de tentatives ont échoués ...");
            }

            #endregion
        }
    }
}
