using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Models
{
    public class Pizza
    {
        public string PizzaType { get; set; }
        public string PizzaBase { get; set; }
        public string PizzaTopping { get; set; }

        public Pizza(string type, string pbase, string topping)
        {
            PizzaType = type;
            PizzaBase = pbase;
            PizzaTopping = topping;
        }

        private int ToppingCookingTime(string topping)
        {
            return topping.Length * 100;
        }

        public float CalculateCookTime()
        {
            return Utils.GetSettingFloat(PizzaType) * (Utils.GetSettingInt("BaseCookTime") + ToppingCookingTime(PizzaTopping));
        }

        public string BoxPizza()
        {
            return PizzaType + " " + PizzaBase + " " + PizzaTopping + " " + ((int)CalculateCookTime()).ToString();
        }

    }
}
