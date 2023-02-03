using System;
using System.Collections.Generic;

using PizzaFactory;
using PizzaFactory.Models;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaManager = new PizzaManager(new PizzaBuilder(),
                                                new PizzaValidator(),
                                                new PizzaCooker(),
                                                new PizzaLogger(Utils.GetSettingString("PizzaFile")));
            int totalPizzas = Utils.GetSettingInt("TotalPizzas");

            Pizza pizza;
            if (totalPizzas > 0)
            {
                for (int i = 0; i < totalPizzas; i++)
                {
                    pizza = pizzaManager.CreateAPizza();

                    Console.WriteLine(i + " " + pizza.BoxPizza());
                }
            }
        }
        
    }
}