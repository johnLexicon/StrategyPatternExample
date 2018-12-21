using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    abstract class Duck
    {
        //Gets instantiated from subclass.
        protected IFlyBehavior flyBehavior;
        //Gets instantiated from subclass.
        protected IQuackBehavior quackBehavior;

        internal string PerformQuack()
        {
            return quackBehavior.Quack();
        }

        internal string Swim()
        {
            return "duck is swimming";
        }

        internal string PerformFly()
        {
            return flyBehavior.Fly();
        }

        internal abstract string Display();
    }
}
