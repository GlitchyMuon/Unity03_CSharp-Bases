namespace Demo_Conversion
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez indiquer votre age : ");
            string years_old = Console.ReadLine();

            //int age_convert = Convert.ToInt32(years_old);

            //Console.WriteLine($"L'age converti est : {age_convert} de type {age_convert.GetType()}");

            //int age_parse = int.Parse(years_old);

            //Console.WriteLine($"L'age converti est : {age_parse} de type {age_parse.GetType()}");
            
            int age_tryparse;

            bool age_isok = int.TryParse(years_old, out age_tryparse);

            Console.WriteLine($"L'age a été converti : {age_isok}");
            Console.WriteLine($"L'âge converti est  : {age_tryparse} de type {age_tryparse.GetType()}");


        }
    }
}

