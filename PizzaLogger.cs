using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaFactory.Models;

namespace PizzaFactory
{
    public class PizzaLogger
    {
        private string FilePath { get; set; }
        public PizzaLogger(string path)
        {
            FilePath = path;
            if (File.Exists(FilePath))
                File.Delete(FilePath);

        }
        public string LogAPizza(Pizza pizza)
        {
            File.AppendAllText(FilePath, pizza.BoxPizza() + Environment.NewLine);
            return pizza.BoxPizza();
        }

    }
}
