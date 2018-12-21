using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    class MallardDuck : Duck
    {

        internal MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }

        internal override string Display()
        {
            return "Looks like a Mallard duck";
        }
    }
}
