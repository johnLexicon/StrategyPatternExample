using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck redhead = new RedheadDuck();
            Duck mallard = new MallardDuck();
            Duck rubber = new RubberDuck();

            var ducks = new List<Duck>()
            {
                redhead,
                mallard,
                rubber
            };

            foreach (var item in ducks)
            {
                Console.WriteLine(item.GetType());
                Console.WriteLine(item.PerformQuack());
                Console.WriteLine(item.Swim());
                Console.WriteLine(item.PerformFly());
                Console.WriteLine(item.Display());
                Console.WriteLine();
            }
        }
    }
}
