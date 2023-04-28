namespace Demo_Random
{
    internal class Program
    {
        static Random RNG = new Random();
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int nb_aleatoire = RNG.Next(5, 101); // (inclus, non-inclus) (non-inclus)
                // Next = donne moi le prochain, ici nombre aléatoire, compris entre (101)
                Console.WriteLine(nb_aleatoire);
            }
        }
    }
}