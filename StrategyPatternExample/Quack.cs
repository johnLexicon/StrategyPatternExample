using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    class Quack : IQuackBehavior
    {
        string IQuackBehavior.Quack()
        {
            return "quack quack";
        }
    }
}
