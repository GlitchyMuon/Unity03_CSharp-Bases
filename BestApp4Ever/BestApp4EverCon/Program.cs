namespace BestApp4EverCon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = a / 5 * 3 + a;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            a--;
            Console.ForegroundColor = ConsoleColor.Yellow;
            b *= a;
            Console.WriteLine(DisBonjour());
        }
        static string DisBonjour()
        {
            return "Bonjour";
        }
    }
}