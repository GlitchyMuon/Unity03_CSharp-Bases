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

            #region List<T> typée
            /*            //Création d'une liste vide :
                        //List<string> students = new List<string>();

                        //Création d'une liste pré-remplie :
                        List<string> students = new List<string>() { "Naël", "Cécile" };

                        //Ajout d'une valeur :
                        students.Add("Tonia");

                        //Ajout de plusieurs valeurs :
                        students.AddRange(new string[] { "Hafsa", "Carol", "Djihen", "Bitsam", "Sonia", "Audrey", "Feryel", "Loriane", "Alexia" });

                        Console.WriteLine($"Le premier élément de la liste est : {students[0]}");
                        Console.WriteLine($"Le second élément de la liste est : {students[1]}");
                        Console.WriteLine($"Le dernier élément de la liste est : {students[students.Count - 1]}");

                        //Suppression de valeur 
                        Console.WriteLine("Si on supprime le 'Alexia' :");
                        students.Remove("Alexia");
                        Console.WriteLine($"Le dernier élément de la liste est : {students[students.Count - 1]}");
                        Console.WriteLine("Si on supprime le premier :");
                        students.RemoveAt(0);
                        Console.WriteLine($"Le premier élément de la liste est : {students[0]}");
            */
            #endregion
        }
    }
}