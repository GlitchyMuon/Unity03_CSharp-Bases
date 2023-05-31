using System.Threading;

namespace Demo_Enum
{
    public enum LightSignalColor { rouge, orange, vert }

    public struct LightSignal
    {
        public LightSignalColor currentColor;

        public void ChangeColor() 
        {
            switch (currentColor)
            {
                case LightSignalColor.rouge:
                    currentColor = LightSignalColor.orange;
                    break;
                case LightSignalColor.orange:
                    currentColor = LightSignalColor.rouge;
                    break;
                case LightSignalColor.vert:
                    currentColor = LightSignalColor.orange;
                    break;
            }
        }

        public void ShowColor()
        {
            switch (currentColor)
            {
                case LightSignalColor.rouge:
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case LightSignalColor.orange:
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    break;
                case LightSignalColor.vert:    Console.BackgroundColor = ConsoleColor.Green;
                    break;
            }
            Console.Clear();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            LightSignal feuRouge = new LightSignal();
            foreach (string colorName in Enum.GetNames<LightSignalColor>())
            {
                Console.WriteLine(colorName);
            }
            string userColor = Console.ReadLine();

            feuRouge.currentColor = Enum.Parse<LightSignalColor>(userColor); //mon Enum.Parse adapte toi, l'information que tu me renvois est un enum LightSignalColor //syntaxe : entre chevrons <> comme le typag d'une liste
              // on parse/cast du string au enum

            for (int i = 0; i < 200; i++)
            {
                feuRouge.ChangeColor();
                feuRouge.ShowColor();
                Thread.Sleep(5000); //comme un clock dans pgzero.
            }
        }
    }
}