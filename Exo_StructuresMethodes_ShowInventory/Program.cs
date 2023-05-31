using Exo_StructuresMethodes_ShowInventory.Struct;

namespace Exo_StructuresMethodes_ShowInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Créer une application ayant 2 structures :
            - Chest doit avoir un champ : "quantity" (entier)
                    doit avoir un champ : "type" (string)
                    doit avoir une méthode : "GetContent" qui vide le Chest (quantité passe à 0)
 
            - Player
                    doit avoir un champ : "inventory" (dictionnaire avec comme clé le type d'objet, et en valeur la quantité)
    
                    doit avoir une méthode : "Loot" qui retourne un booléen si on récupère quelque chose et prend en paramètre un objet "Chest". La méthode doit vider le Chest une fois ajouter la quantité dans l'inventaire.
 
                    doit avoir une méthode : "ShowInventory" qui affiche le contenu de l'inventaire.*/

            Chest chest1 = new Chest();
            chest1.type = "Or";
            chest1.quantity = 500;

            Chest chest2 = new Chest() { type = "Amulet of Luck", quantity = 1 };
            Chest chest3 = new Chest() { type = "Potion", quantity =1 };

            Player joueur = new Player();  // on n'initilise pas les valeurs, ce sera dans le constructeur

            joueur.ShowInventory();

            if (joueur.Loot(ref chest1)) Console.WriteLine("Tutu tutuuuu !");
            if (joueur.Loot(ref chest2)) Console.WriteLine("Tutu tutuuuu !");
            if (joueur.Loot(ref chest3)) Console.WriteLine("Tutu tutuuuu !");
            if (joueur.Loot(ref chest1)) Console.WriteLine("Tutu tutuuuu !"); //coffre vidé

            // les structures ne se changeant pas dans la méthode, on est obligé d'utiliser un élément référentiel.
            //Les class, contrairement aux structures, sont des éléments référentiels

            joueur.ShowInventory();

        }
    }
}