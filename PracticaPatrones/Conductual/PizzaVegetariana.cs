using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPatrones.Conductual
{
    public class PizzaVegetariana : Pizza
    {
        public override string SetNamePizza()
        {
            return "Pizza Veggie";
        }
    }
}
