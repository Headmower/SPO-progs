using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternLearning
{
    abstract class BeverageDecorator : Beverage
    {
        protected Beverage _beverage;
    }
}
