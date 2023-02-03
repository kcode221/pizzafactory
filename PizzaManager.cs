using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaFactory.Models;

namespace PizzaFactory
{
    public class PizzaManager
    {
        public PizzaBuilder PBuilder { get; set; }
        public PizzaValidator PValidator { get; set; }
        public PizzaCooker PCooker { get; set; }
        public PizzaLogger PLogger { get; set; }

        public PizzaManager(PizzaBuilder pBuilder, PizzaValidator pValidator,
                            PizzaCooker pCooker, PizzaLogger pLogger)
        {
            PBuilder = pBuilder;
            PValidator = pValidator;
            PCooker = pCooker;
            PLogger = pLogger;
        }

        public Pizza CreateAPizza()
        {
            var pizza = PBuilder.BuildAPizza();
            if (PValidator.ValidateAPizza(pizza))
            {
                PCooker.CookAPizza(pizza.CalculateCookTime());
                PLogger.LogAPizza(pizza);
            }

            return pizza;
        }

    }
}
