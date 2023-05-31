using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_StructuresMethodes_ShowInventory.Struct
{
    /*Créer une application ayant 2 structures :
            - Chest doit avoir un champ : "quantity" (entier)
                    doit avoir un champ : "type" (string)
                    doit avoir une méthode : "GetContent" qui vide le Chest (quantité passe à 0)*/
    public struct Chest
    {
        public int quantity;
        public string type;
        

        public void GetContent()
        {
            quantity = 0;
        }
    }
}
