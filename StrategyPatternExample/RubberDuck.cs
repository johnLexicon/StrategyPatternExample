using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    class RubberDuck : Duck
    {

        internal RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeek();
        }

        internal override string Display()
        {
            return "Looks like rubber duck";
        }
    }
}
