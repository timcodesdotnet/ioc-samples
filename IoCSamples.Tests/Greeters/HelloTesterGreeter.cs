using IoCSamples.Greeters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCSamples.Tests.Greeters
{
    internal class HelloTesterGreeter : IGreeter
    {
        public string GetGreeting()
        {
            return "Hello Tester!";
        }
    }
}
