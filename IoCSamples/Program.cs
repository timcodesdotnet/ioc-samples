using IoCSamples.DependencyInjection;
using IoCSamples.Greeters;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();

            container.Register<IGreeter, HelloWorldGreeter>();

            container.Verify();

            DependencyResolver.SetupContainer(container);

            RunProgram();
        }

        static void RunProgram()
        {
            var messenger = DependencyResolver.Get<Messenger>();
            Console.Write(messenger.GetWelcomeMessage());
            Console.ReadLine();
        }
    }
}
