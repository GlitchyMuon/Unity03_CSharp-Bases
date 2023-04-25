namespace Demo_Operateurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Opérateur déplacement de bits          
            /*int i = 1; // 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 1
                        //                                                   3216 8 4 2 1

            i = 1 << 4; //  0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 1 0 0 0 0

            Console.WriteLine(i); */
            #endregion

            #region Opérateur ternaire
            Console.WriteLine("Veuillez indiquer votre âge : ");
            int age;
            bool is_convert = int.TryParse(Console.ReadLine(), out age);

            if (is_convert)
            {

                string status = (age < 18) ? "mineur" : "majeur";
            
                Console.WriteLine($"Vous êtes {status}.");
                Console.WriteLine($"Vous avez {age} an{((age > 1)? "s" : "")}.");

            }
            else
            {
                Console.WriteLine("Apprends à lire !?");
            }
            #endregion

        }
        }
}