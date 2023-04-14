internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Votre nom : ");
        string? name = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Votre prénom : ");
        string? firstName = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Votre âge : ");
        string? age = Console.ReadLine();
        Console.Clear();

        Console.WriteLine($"Bonjour à vous {name} {firstName} !");
        Console.WriteLine($"Vous ne faites pas vos {age} ans !");



    }
}