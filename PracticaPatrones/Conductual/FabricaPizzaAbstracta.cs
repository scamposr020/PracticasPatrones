using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPatrones.Conductual
{
    public abstract class FabricaPizzaAbstracta
    {
        public static FabricaPizzaAbstracta GetFabrica(String tipo) {
            if (tipo.Equals("Pizza Fabrica"))
            {
               return new PizzaFabrica();
            }
            else {
                return new PizzaFabrica2();
            }
        }
        
        public abstract Pizza GetPizza(String Pizza);
    }
}
