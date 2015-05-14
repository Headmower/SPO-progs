using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternLearning
{
    abstract class Beverage
    {
        protected String _name = "Unknown";
        protected double _cost;

        public abstract string getName();
        public abstract double cost();
    }
}
