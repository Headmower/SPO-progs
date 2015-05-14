using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternLearning
{
    class Shit : BeverageDecorator
    {
        public Shit(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override double cost()
        {
            return 0.05 + _beverage.cost();
        }

        public override string getName()
        {
            return _beverage.getName() + " + shit";
        }
    }
}
