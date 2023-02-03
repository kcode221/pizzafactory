using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public class PizzaCooker
    {
        public int CookAPizza(float cookTime)
        {
            System.Threading.Thread.Sleep((int)cookTime);
            return (int)cookTime;
        }

    }
}
