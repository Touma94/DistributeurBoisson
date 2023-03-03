using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistibuteurBoisson
{
    internal class CoffeeMachine
    {
        private List<Ingredient> ingredients = new List<Ingredient>();
        private List<Recipe> recipes = new List<Recipe>();
        //private List<Drink> drinks= new List<Drink>();

        public CoffeeMachine()
        {
            /*CREATION DES INGREDIENT NECESSAIRE AUX RECETTES AVEC LEUR PRIX PAR DOSE*/

            Ingredient laitEnPoudre = new Ingredient("Lait en poudre", 10f);
            Ingredient cafe = new Ingredient("Café", 30f);
            Ingredient chocolatEnPoudre = new Ingredient("Chocolat", 40f);
            Ingredient the = new Ingredient("Thé", 30f);
            Ingredient eau = new Ingredient("Eau", 5f);

            /* AJOUT DES INGREDIENTS A LA LISTE DES INGREDIENTS*/

            ingredients.Add(laitEnPoudre);
            ingredients.Add(cafe);
            ingredients.Add(chocolatEnPoudre);
            ingredients.Add(the);
            ingredients.Add(eau);

            /* CREATION DES RECETTES + AJOUT DES RECETTES A LA LISTE DES RECETTES*/


            Dictionary<Ingredient, int> espressoIngredients = new Dictionary<Ingredient, int>
            {
                { cafe, 2 },
                { eau, 1 }
            };
            Recipe espresso = new Recipe("Espresso", espressoIngredients);
            recipes.Add(espresso);

            Dictionary<Ingredient, int> laitIngredients = new Dictionary<Ingredient, int>
            {
                { laitEnPoudre, 2 },
                { eau, 1 }
            };
            Recipe lait = new Recipe("Lait", laitIngredients);
            recipes.Add(lait);


            Dictionary<Ingredient, int> capuccinoIngredients = new Dictionary<Ingredient, int>
            {
                { laitEnPoudre, 2 },
                { eau, 1 },
                { cafe, 1 },
                { chocolatEnPoudre, 1 }
            };
            Recipe capuccino = new Recipe("Capuccino", capuccinoIngredients);
            recipes.Add(capuccino);

            Dictionary<Ingredient, int> chocolatChaudIngredients = new Dictionary<Ingredient, int>
            {
                { eau, 3 },
                { chocolatEnPoudre, 2 }
            };
            Recipe chocolatChaud = new Recipe("Chocolat Chaud", chocolatChaudIngredients);
            recipes.Add(chocolatChaud);

            Dictionary<Ingredient, int> cafeAuLaitIngredients = new Dictionary<Ingredient, int>
            {
                { laitEnPoudre, 1 },
                { eau, 2 },
                { cafe, 1 }
            };
            Recipe cafeAuLait = new Recipe("Café au lait", cafeAuLaitIngredients);
            recipes.Add(cafeAuLait);

            Dictionary<Ingredient, int> mokaccinoIngredients = new Dictionary<Ingredient, int>
            {
                { laitEnPoudre, 1 },
                { eau, 2 },
                { cafe, 1 },
                { chocolatEnPoudre, 2 }
            };
            Recipe mokaccino = new Recipe("Mokacinno", mokaccinoIngredients);
            recipes.Add (mokaccino);

            Dictionary<Ingredient, int> theIngredients = new Dictionary<Ingredient, int>
            {
                { eau, 2 },
                {the, 1 }
            };
            Recipe the2 = new Recipe("Thé", theIngredients);
            recipes.Add(the2);
        }

        public Recipe get_recipe(String name) //On recupère la recette à partir de son nom
        {
            for(int i=0;i<this.recipes.Count;i++)
            {
                if( String.Compare(recipes[i].Name,name)==0)
                {
                    return recipes[i];
                }

            }
            return null;
        }

        public float GetPrice(String recipe_name) //On récupère le prix de la recette
        {
            Recipe my_recipe = get_recipe(recipe_name);

            return my_recipe.GetPrice();
        }
    }
}
