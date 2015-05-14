using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternLearning
{
    class Cappucino : Beverage
    {
        public Cappucino()
        {
            lock (this)
            {
                this._cost = 0.75;
                this._name = "Cappucino";
            }
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
