﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    class Squeek : IQuackBehavior
    {
        public string Quack()
        {
            return "squeeeeek";
        }
    }
}
