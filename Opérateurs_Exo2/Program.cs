namespace Démo_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello, World !";
            Console.WriteLine(message.Substring(0, 5)); // 0 est l'index de départ. 5 est la quantité de caractères, pas l'index à laquelle ça se termine !
            Console.WriteLine(message.Substring(7, 5));
            //Console.WriteLine(message.Substring(7)); 
            // jusqu'au bout d'exclamation
        }
    }
}