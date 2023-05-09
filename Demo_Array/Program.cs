
using System.Collections;
namespace Demo_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tableau à une dimension


            /*string[] students = {
                "Naël", 
                "Cécile", 
                "Tonia", 
                "Hafsa", 
                "Carol", "Djihen", 
                "Btissam", 
                "Sonia", 
                "Audrey", 
                "Feryel", 
                "Loriane", 
                "Alexia"
            };

            Console.Write($"La classe Unity03 ont comme délégués : {students[3]} et {students[11]}");
            Console.WriteLine($"La classe est constituée de : ");
            *//*for (int i = 0; i < students.Length; i++)
             * {
             *      
             * }
             *//*
            foreach (string student_name in students) Console.WriteLine(student_name); //string student_name n'est qu'une variable crée et utilisée en lecture seule dans la boucle foreach. Elle n'existe que dans la boucle !
            {
                Console.WriteLine(student_name);
            }
             */
            #endregion

            #region 9/05/2023 : Révision avec Alexandre

            //ArrayList tempTour = new ArrayList();

            //tempTour.Add(49.36);
            //tempTour.Add("49.36");
            //tempTour.Add(49);
            //Console.WriteLine("Affichage ArrayList (tempTour)");

            //foreach(var item in tempTour) //var car variable sans typage défini
            //{
            //    Console.WriteLine(item);
            //}

            //tempTour.Remove("49.36");
            //Console.WriteLine("Après ");
            //// variante de boucle :
            ////for (int i = 0; i < tempTour.Count; i++)
            ////{
            ////    Console.WriteLine(tempTour[i]);
            ////}
            #endregion

            #region Demo Hashtable (clé + valeur)

            //Hashtable monDictionnaire = new Hashtable();

            //monDictionnaire.Add("valeur1", 5000);
            //monDictionnaire.Add("valeur2", 8000);
            //monDictionnaire.Add("valeur3", 2000);

            //monDictionnaire.Remove("valleur3");

            //foreach (DictionaryEntry item in monDictionnaire)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}
            #endregion

            #region Queue FIFO

            //Queue listQueue = new Queue();

            //listQueue.Enqueue("élément 1");
            //listQueue.Enqueue("élément 2");
            //listQueue.Enqueue("élément 3");

            //listQueue.Dequeue(); //enlève le premier élément, donc pas besoin de paramètre !

            //foreach (var item in listQueue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Stack LIFO

            Stack listStack = new Stack();

            listStack.Push("élément 1");
            listStack.Push("élément 2");
            listStack.Push("élément 3");
            
            listStack.Pop(); //dernier élément, pas besoin de paramètre
            
            foreach (var item in listStack)
            {
                Console.WriteLine(item);
            }

            #endregion
        }
    }
}