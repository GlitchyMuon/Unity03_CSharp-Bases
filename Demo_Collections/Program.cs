using System.Collections;


namespace Demo_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Nicole");
            list.Add("Samuel");
            list.Add(41);

            Console.WriteLine($"Le premier élément de la liste est : {list[0]}");
            Console.WriteLine($"Le second élément de la liste est : {list[1]}");
            Console.WriteLine($"Le dernier élément de la liste est : {list[list.Count - 1]}"); //propriété Count d'ArrayList permet de savoir le nombre d'éléments dans ArrayList. C'est comme .Length mais ce dernier est pour les tableaux.

            //Suppression de valeur
            Console.WriteLine("Si on supprime le 'Nicole' :");
            list.Remove("Nicole");



        }
    }
}