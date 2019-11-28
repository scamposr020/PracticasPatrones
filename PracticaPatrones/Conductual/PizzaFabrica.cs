using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPatrones.Conductual
{
    class PizzaFabrica:FabricaPizzaAbstracta
    {
        public override Pizza GetPizza(String pizza) {
            if (pizza.ToLower().Equals("pizza vegetariana"))
            {
                return new PizzaVegetariana();
            }
            else {
                return new Pizza_Vegana();
            }
        }
    }
}
