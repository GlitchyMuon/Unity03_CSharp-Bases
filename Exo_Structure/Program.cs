using Exo_Structure.Struct;
using System.Security.Cryptography.X509Certificates;

//deleted the ConsoleApp1 namespace version
namespace Exo_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ecrire une structure pour définir un point possédant deux entier X, Y et créer un tableau deux dimensions de 5 sur 5 de type « Point » (nullable) 
               et remplir une des diagonales, ensuite à l’aide de deux boucles afficher les valeurs dans la console comme suit : 
             « X : 1 - Y : 1 »
                                 « X : 2 - Y : 2 »
                                                     « X : 3 - Y : 3 »
             ... *//*

             Point[,]? points = new Point[5,5]; //Point car le type, remplace string, int etc. pour déclarer le type de tableaux

             //for car incrémentation du i
             for (int i = 1; i < 6; i++) // valeur littérale au dessus, car on veut qu'il commence i à 1 et qu'il soit strictement plus petit que 6
             {
                 Point point = new Point();
                     point.X = i;
                 points[i,0] = point;

                 for (int j = 1; j < 6; j++)
                 {

                     point.Y = j;
                     points[i,j] = point;
                 }


                 for (int k = 0; k < points.GetLength(0); k++)
                     {

                         Console.Write($"X : {point.X} ");
                         for (int m = 0; m < points.GetLength(1); m++)
                         {
                         Console.Write($"Y : {point.Y}");
                         }
                     }
             }*/

            #region Correction

            #region Creation

            Point[,] tabPoints = new Point[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                        Point newPoint = new Point();
                        newPoint.X = i;
                        newPoint.Y = i;
                        tabPoints[i, j] = newPoint;
                    }
                }
                #endregion

                #region Affichage
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i != j)
                    {
                        Console.Write($"    ");
                    }
                    else
                    {
                        Console.Write($"X : {tabPoints[i, j].X} - Y {tabPoints[i, j].Y}");
                    }
                }
                Console.WriteLine();

            }
            #endregion
            #endregion
        }
    }
}