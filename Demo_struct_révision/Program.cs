namespace Demo_struct_révision
{
    public struct Ingredient
    {
        public string nom;
        public string unite_mesure;
        public int quantite;
    }

    public struct Recette
    {
        #region champs/variables membres
        public string nom;
        ///<summary>
        ///En minute.
        ///</summary>
        public int duree;
        ///<summary>
        ///Niveau de 0 à 10
        ///</summary>
        public int difficulte;
        public List<Ingredient> ingredients;
        public List<string> etapes;
        #endregion

        #region Propriétés
        //Pas encore vu
        #endregion

        #region Constructeurs et destructeur
        //Pas encore vu
        #endregion

        #region Méthodes
        //Méthode pour ajouter automatiquement les ingrédients
        public void AjoutIngredient(string nom, string unite_mesure, int quantite) //void = on obtient aucun résultat, pas de valeur qui doit être sauvegarder
        {
            if (ingredients is null)
            {
                ingredients = new List<Ingredient>();
            }

            //ingredients = ingredients ?? new List<Ingredient>(); //Coalesce : récupère la valeur de gauche si non-null, sinon prends celle de droite
            //logique inverse : l'action de vérifier si quelque chose est null, si oui, prendre l'élément à droite, si non garde l'élément qui est déjà prêt
            //OU
            //ingredients ??= new List<Ingredient>();

            Ingredient ingredient;
            ingredient.nom = nom;
            ingredient.unite_mesure = unite_mesure;
            ingredient.quantite = quantite;
            ingredients.Add(ingredient);
        }
        #endregion
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Recette recette_1 = new Recette();
            recette_1.nom = "Crumble aux pommes";
            recette_1.duree = 60;
            recette_1.difficulte = 2;
            recette_1.ingredients = new List<Ingredient>();
            Console.WriteLine($"Pour un {recette_1.nom} il faut :");


            /*Console.WriteLine("Pour faire un crumble aux pommes, il nous faut :");
            Ingredient ingredient_1;
            ingredient_1.nom = "Pomme";
            ingredient_1.unite_mesure = "pièce";
            ingredient_1.quantite = 3;
            Ingredient ingredient_2;
            ingredient_2.nom = "Beurre";
            ingredient_2.unite_mesure = "gramme";
            ingredient_2.quantite = 50;
            Ingredient ingredient_3;
            ingredient_3.nom = "Farine";
            ingredient_3.unite_mesure = "gramme";
            ingredient_3.quantite = 60;
            Ingredient ingredient_4 = ingredient_3;     //copie des valeurs de ingredient_3
            ingredient_4.nom = "Sucre";                 //changement de valeur pour le nom d'ingredient_4
                                                        //attention, le changement se fait que sur ingredient_4, ingredient_3 ne change pas !

            List<Ingredient> ingredients = new List<Ingredient>();
            recette_1.ingredients.Add(ingredient_1);
            recette_1.ingredients.Add(ingredient_2);
            recette_1.ingredients.Add(ingredient_3);
            recette_1.ingredients.Add(ingredient_4);
            //ingredients.AddRange(new Ingredient[] {ingredient_1, ingredient_2, ingredient_3, ingredient_4};*/

            recette_1.AjoutIngredient("Pomme", "pièce", 3);
            recette_1.AjoutIngredient("Beurre", "gramme", 50);
            recette_1.AjoutIngredient("Farine", "gramme", 60);
            recette_1.AjoutIngredient("Sucre", "gramme", 60);

            foreach (Ingredient ingredient in recette_1.ingredients)
            {
                Console.WriteLine($"\t-\t{ingredient.nom} : {ingredient.quantite} {ingredient.unite_mesure}");
                    //\t = tabulation
            }
        }
    }
}