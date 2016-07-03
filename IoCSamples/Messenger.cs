using IoCSamples.Greeters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCSamples
{
    public class Messenger
    {
        private readonly IGreeter _greeter;

        public Messenger(IGreeter greeter)
        {
            _greeter = greeter;
        }

        public string GetWelcomeMessage()
        {
            return _greeter.GetGreeting();
        }
    }
}
