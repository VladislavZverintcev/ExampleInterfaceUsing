using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleInterfaceUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            var victor = new Human("Vitek", "Russian");
            var barsic = new Cat("Barsic", "Persian");
            victor.LetsEat("Meat");
            barsic.LetsEat("Sheba");
            Console.ReadKey();
        }
    }
}
