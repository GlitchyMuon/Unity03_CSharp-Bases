using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_StructuresMethodes_ShowInventory.Struct
{
    /*- Player
                    doit avoir un champ : "inventory" (dictionnaire avec comme clé le type d'objet, et en valeur la quantité)
    
                    doit avoir une méthode : "Loot" qui retourne un booléen si on récupère quelque chose et prend en paramètre un objet "Chest". La méthode doit vider le Chest une fois ajouter la quantité dans l'inventaire.
 
                    doit avoir une méthode : "ShowInventory" qui affiche le contenu de l'inventaire.*/
    public struct Player
    {
        public Dictionary<string, int> inventory;

        public bool Loot(ref Chest chest) //le mot-clé "in" protège en lecture seule, le paramètre
            //Attention : les mots-clés ref et in ne peuvent cohabiter...
        {   
            //ma tentative de solution
           /*inventory.Add(chest.type, chest.quantity);
            inventory.Add("Lampe Torche", 1);
            inventory.Add("Bois", 10);
            inventory.Add("Corde", 1);

            if (chest.quantity == 0)
            {
                chest.GetContent();            
            }
            return false;*/
            
            if (chest.quantity == 0) return false;

            inventory ??= new Dictionary<string, int>();

            if (inventory.ContainsKey(chest.type))
            {
                //int oldQuantity = inventory[chest.type]
                //inventory[chest.type0] = oldQuantity +    chest.quantity;

                inventory[chest.type] += chest.quantity;
            }
            else
            {
                inventory.Add(chest.type, chest.quantity);
            }

            //chest.quantity = 0 //Donne une erreur car les variables de chest sont protégées par le mot-clé "in"

            chest.GetContent();     //Pas de soucis avec GetContent(), c'est la méthode du chest lui-même qui change la variable "quantity"

            return true;
        }

        public void ShowInventory()
        {
            Console.WriteLine("Contenu de l'inventaire  :");
            if (inventory is null || inventory.Count == 0) Console.WriteLine("L'inventaire est vide.");
            else {
                foreach (KeyValuePair<string, int> kvp in inventory)
                {
                    if (kvp.Value > 0)
                    {
                        Console.WriteLine($"Objet : {kvp.Key}, quantité : {kvp.Value}.");
                    }
                }
            }
        }
    }
}
