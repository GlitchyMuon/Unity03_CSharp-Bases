namespace Opérateurs_Exo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un nombre entier : ");
            int n1;
            bool isConvert = int.TryParse(Console.ReadLine(), out n1);

            if (isConvert == true)
            {
                Console.WriteLine("Entre un deuxième nombre entier : ");
                int n2;
                isConvert = int.TryParse(Console.ReadLine(), out n2); //la même variable, mais on change sa valeur, on réutilise la variable, donc pas besoin de déclarer que c'est un bool, car on est sûr que c'est un booléen.

                if (isConvert == true) 
                { 
                    int result_div_ent = n1 / n2;
                    int result_modulo = n1 % n2;
                    double div_double = (double)n1 / (double)n2; //si on ne met PAS de (double) devant les entiers du calculs, il va faire le calcul de la division entière et l'afficher en double.
                    // différence entre le float et le double : le double est plus précis, deux décimales après la virgule.
                    // ici, pas besoin d'autant de précision, donc : float div_float = (float)n1 / n2
                    // juste un seul des deux éléments de la division peuvent être en float, l'ordinateur va considérer la division possible qu'entre float, donc va transformer l'autre, qui est entier, en float aussi.

                    // Variante
                    // int result_div_ent = n1 / n2;
                    // Console.WriteLine("Résultat de la division entière : ");
                    // Console.WriteLine(result_div_ent);
                    Console.WriteLine($"Résultat de la division entière : {result_div_ent}");
                    Console.WriteLine($"Résultat du modulo : {result_modulo}");
                    Console.WriteLine($"Résultat de la division : {div_double}");
                }
            }
            if (isConvert == false) // if (isConvert)
            {
                Console.WriteLine("Vous devez entrer un nombre...");
            }

        }
    }
}
//énoncé :
//Calcule de la division entière, du modulo et de la division de deux entiers.
//Résultat attendu pour 5 et 2 → Division entière : 2, Modulo: 1, Division: 2,5.s