using System;

namespace Demo_Variables
{
    internal class Program
    {
        static string program_name = "Démonstration pour les Game03 !"; //variable globale
        static void Main(string[] args)
        {
            string message = "Hello, World!"; //variable locale
            Console.WriteLine(message);
            Console.WriteLine(program_name);
        }
    }
}
//cw tab tab permet grâce à Intellisense, le Console.Writeline(); en autocomplétion