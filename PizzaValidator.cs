using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaFactory.Models;

namespace PizzaFactory
{
    public class PizzaValidator
    {
        private Dictionary<Pizza, int> CookedPizzas = new Dictionary<Pizza, int>();
        public bool ValidateAPizza(Pizza pizza)
        {
            if (CookedPizzas.ContainsKey(pizza))
                return false;
            else
            {
                CookedPizzas[pizza] = 1;
                return true;
            }
        }

    }
}
