namespace Demo_Boucles_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez introduire un nombre (entre 1 et 10): ");
            string? nb1_str = Console.ReadLine();
            bool isConvert = short.TryParse(nb1_str, out short nb1); //déclaré à l'intérieur donc out short nb1. Sinon au dessus : short nb1;
            
            while(!isConvert) //tant qu'il n'est PAS converti
            {
                Console.WriteLine($"{nb1_str} n'est pas un nombre.");
                Console.WriteLine("Veuillez introduire un nombre (entre 1 et 10): ");
                nb1_str = Console.ReadLine();
                isConvert = short.TryParse(nb1_str, out nb1); // on réassigne isConvert car il existe déjà et pareil pour nb1
            }

            while (nb1 < 1 || nb1 > 10)
            {
                Console.WriteLine("Ce n'est pas un nombre entre 1 et 10 ... 😒");
                Console.WriteLine("Veuillez introduire un nombre (entre 1 et 10): ");
                nb1_str = Console.ReadLine();
                isConvert = short.TryParse(nb1_str, out nb1);

                while(!isConvert)
                {
                    Console.WriteLine($"{nb1_str} n'est pas un nombre.");
                    Console.WriteLine("Veuillez introduire un nombre (entre 1 et 10): ");
                    nb1_str = Console.ReadLine();
                    isConvert = short.TryParse(nb1_str, out nb1);
                }
            }
            Console.WriteLine("Ceci est bien un nombre entre 1 et 10 ! ✨");
        }
    }
}