using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    class FlyNoWay : IFlyBehavior
    {
        public string Fly()
        {
            return "I cannot fly!!!";
        }
    }
}
