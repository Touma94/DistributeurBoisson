using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistibuteurBoisson
{
    internal class Recipe
    {
        public string Name { get; }
        public Dictionary<Ingredient, int> Ingredients { get; }

        public Recipe(string name, Dictionary<Ingredient, int> ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }

        public float GetPrice() //on calcule et récupère le prix de la recette
        {
            float totalCost = 0;

            foreach (var ingredient in Ingredients)
            {
                totalCost += ingredient.Key.Cost * ingredient.Value;
            }

            return totalCost * 1.3f;
        }
    }
}
