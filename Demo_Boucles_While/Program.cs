namespace Demo_Boucles_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boucle bloquant
            /*
             * Console.WriteLine("Veuillez introduire un nombre (entre 1 et 10): ");
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
            Console.WriteLine("Ceci est bien un nombre entre 1 et 10 ! ✨");*/
            #endregion

            #region Démo boucle simple
            /*
             * int x = 0;

            *while (x < 10) {
            *    Console.WriteLine( $"x vaut : {x}" );
            *    x++;                                    // x = x + 1
            *}
            *
            *Console.WriteLine($"Au final x vaudra : {x}");
            */
            #endregion

            #region Exo bonus boucle
            // Créer une application qui demande un nombre à l'utilisateur et ensuite affiche à l'écran un nombre de ligne correspondant au nombre avec la lettre 'A' qui se répète autant de fois que le numéro de ligne.
            //Exemple: pour 10
            //Affiche:
            //A
            //AA
            //AAA
            //AAAA
            //AAAAA
            //AAAAAA
            //AAAAAAA
            //AAAAAAAA
            //AAAAAAAAA
            //AAAAAAAAAA

            Console.WriteLine("Entrez un nombre : ");
            string? num_lines_str = Console.ReadLine();
            int num_lines = int.Parse(num_lines_str);
            int x = 0;
            string letter = "A";
            string letter_suite = "A";

            while (x < num_lines) 
            {
                // façon trouvé sur stackoverflow :
                //string result = new String('A', x);
                //Console.WriteLine(result);

                Console.WriteLine(letter);
                letter += letter_suite; //si on fait letter += letter, il va doubler car on réaffecte
                x++; 
            }
            
            #endregion
        }
    }
}