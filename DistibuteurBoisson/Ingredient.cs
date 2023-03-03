using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistibuteurBoisson
{
    internal class Ingredient
    {
        public string Name { get; set; }
        public float Cost { get; set; } //le coup d'un ingrédient par dose

        public Ingredient(string name, float cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
