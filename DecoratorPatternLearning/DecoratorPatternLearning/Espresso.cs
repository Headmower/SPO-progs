using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternLearning
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            this._cost = 0.95;
            this._name = "Espresso";
        }

        override public double cost()
        {
            return _cost;
        }

        override public String getName()
        {
            return _name;
        }
    }
}
