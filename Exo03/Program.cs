namespace Exo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donne un nombre entier : ");

            
            int n;
            bool n_isConvert = int.TryParse(Console.ReadLine(), out n);


            if (n_isConvert)
            { 
                int half_of_n = n / 2;
                if (half_of_n + half_of_n == n) Console.WriteLine($"{n} est pair.");    //s'il n'y a qu'une instruction, on peut skip les accolades et mettre sur la même ligne
                
                else Console.WriteLine($"{n} est impair.");
            
            }
            else 
            {
                Console.WriteLine("On a demandé un nombre ! 😒");
            }
        }
    }
}