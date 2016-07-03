using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCSamples.Greeters
{
    internal class HelloWorldGreeter : IGreeter
    {
        public string GetGreeting()
        {
            return "Hello World";
        }
    }
}
