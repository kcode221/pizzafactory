using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaFactory.Models;

namespace PizzaFactory
{
    public class PizzaBuilder
    {
        public readonly List<string> PizzaTypes = new List<string> { "deep", "stuffed", "thin" };
        public readonly List<string> PizzaBases = new List<string> { "pan", "crust", "crispy" };
        public readonly List<string> PizzaToppings = new List<string> { "ham and mushroom", "pepperoni", "vegetable" };

        private string ChooseOption(List<string> ingredient)
        {
            var random = new Random();
            return ingredient[random.Next(ingredient.Count)];
        }

        public Pizza BuildAPizza()
        {
            return new Pizza(ChooseOption(PizzaTypes), ChooseOption(PizzaBases), ChooseOption(PizzaToppings));   
        }

    }
}
