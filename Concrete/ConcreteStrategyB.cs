using StrategyPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPattern.Concrete
{
    public class ConcreteStrategyB : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();

            return list;
        }
    }
}
