using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaPatrones.Conductual;
namespace PracticaPatrones
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaPizzaAbstracta fabricaSeleccionada= FabricaPizzaAbstracta.GetFabrica("Pizza Fabrica");

            Pizza pizza = fabricaSeleccionada.GetPizza("Pizza Veggie");

            Console.WriteLine(pizza.SetNamePizza());

            Console.ReadLine();
        }
    }
}
