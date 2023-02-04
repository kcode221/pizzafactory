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

        public Pizza CreateAUniquePizza()
        {
            int pCount = 0;
            Pizza pizza = PBuilder.BuildAPizza();
            while (pCount < 1)
            {

                if (PValidator.ValidateAPizza(pizza))
                {
                    pCount++;
                    PCooker.CookAPizza(pizza.CalculateCookTime());
                    PLogger.LogAPizza(pizza);
                }
                else
                {
                    pizza = PBuilder.BuildAPizza();
                    continue;
                }
            }
            return pizza;
        }

    }
}
