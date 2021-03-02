using StrategyPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPattern.Concrete
{
    // Concrete Strategies implement the algorithm while following the base
    // Strategy interface. The interface makes them interchangeable in the
    // Context.
    public class ConcreteStrategyA : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }
}
