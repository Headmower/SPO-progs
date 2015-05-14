using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternLearning
{
    class Chocolate : BeverageDecorator
    {
        public Chocolate(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override double cost()
        {
            return 0.15 + _beverage.cost();
        }

        public override string getName()
        {
            return _beverage.getName() + " + chocolate";
        }
    }
}
