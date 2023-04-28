namespace Demo_TableauScores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int TAILLE = 10;
            int[] scores = new int[TAILLE];

            Console.WriteLine($"Combien de scores faut-il calculer ? (entre 2 et {TAILLE}");
            ushort nbr_score = ushort.Parse( Console.ReadLine() );

            for (int i = 0; i < nbr_score; i++) 
            {
                Console.WriteLine($"Veuillez introduire le score du joueur {i + 1}");
                scores[i] = ushort.Parse( Console.ReadLine() ) ;
            }

            int sommes = 0;

            for (int i = 0; i < nbr_score; i++)
            {
                sommes += scores[i];
            }

            Console.WriteLine($"Votre moyenne de scores est : {sommes / nbr_score}.");

        }
    }
}