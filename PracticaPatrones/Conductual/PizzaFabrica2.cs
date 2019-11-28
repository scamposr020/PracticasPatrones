using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPatrones.Conductual
{
    class PizzaFabrica2:FabricaPizzaAbstracta
    {
        public override Pizza GetPizza(String Pizza) {

            if (Pizza.ToLower().Equals("pizza jamon"))
            {
                return new PizzaJamon();
            }
            else {
                return new PizzaVegetariana();
            }
        }

    }
}
