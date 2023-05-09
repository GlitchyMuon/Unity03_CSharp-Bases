//Rappel après congés, avec formateur Alexandre
//using System.Text.Json.Nodes;

namespace Demo_Tableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tableau à 1 dimension
            //int[] monTableau = { 2, 4, 6, 8, 10, 12, 14, 16, 18 };

            //for (int i = 0; i < monTableau.Length; i++)
            //{
            //    Console.WriteLine("L'élément " + i + " de mon tableau est : " + monTableau[i]);
            //}
            #endregion

            #region Tableau à 2 dimensions (tableaux matriciels) taille fixe

            //int[,] monTableau2Dim = {{ 0, 1, 2},
            //                         { 3, 4, 5},
            //                         { 6, 7, 8},
            //                         { 9, 10, 11},
            //                         { 0, 1, 2}};
            //Console.WriteLine(monTableau2Dim.Length)->va afficher 9, la longueur totale, sans prendre en compte les dimensions

            //Console.WriteLine("--------------------- Tableau 2 Dim ---------------------");

            //for (int i = 0; i < monTableau2Dim.GetLength(0); i++)
            //{
            //    Console.WriteLine("Affichage ligne " + i);
            //    for (int j = 0; j < monTableau2Dim.GetLength(1); j++) // si int j = 1 ; j < monTableau2Dim.GetLength(1)-1; j++
            //    {
            //        Console.Write(monTableau2Dim[i, j] + " ");

            //    }
            //    Console.WriteLine();

            //}
            #endregion

            #region Tableau à 3 dimensions (tableaux matriciels) taille fixe
            //int[3, 3, 3] 
            // colonnes, lignes, éléments
            // équivalent python : lignes, colonnes, éléments
            int[,,] monTableau3Dim = { {{1, 1, 1,}, {2, 2, 2}, {3, 3, 3} },
                                       {{4, 4, 4,}, {5, 5, 5}, {6, 6, 6} },
                                       {{7, 7, 7,}, {8, 8, 8}, {9, 9, 9} }
                                     };
            for (int i = 0; i < monTableau3Dim.GetLength(0); i++) //le i sont les colonnes. Mais lignes visuellement : {{1, 1, 1,}, {2, 2, 2}, {3, 3, 3} }
            {
                for (int j = 0; j < monTableau3Dim.GetLength(1); j++) //le j sont les lignes ex : : {1, 1, 1}. Colonnes visuellement
                {
                    Console.WriteLine("L'élément : " + j + " contient : ");
                    for (int k = 0; k < monTableau3Dim.GetLength(2); k++) // le k sont les éléments à l'intérieur
                    {
                        Console.Write(monTableau3Dim[i, j, k]);
                    }
                }    
            }
            #endregion
        }
    }
}