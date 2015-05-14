using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Cappucino();
            beverage = new Milk(beverage);
            beverage = new Milk(beverage);
            beverage = new Chocolate(beverage);
            beverage = new Shit(beverage);

            Console.WriteLine(beverage.getName() + " : " + beverage.cost());
            Console.ReadLine();
        }
    }
}
