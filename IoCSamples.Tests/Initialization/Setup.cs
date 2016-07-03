using IoCSamples.DependencyInjection;
using IoCSamples.Greeters;
using IoCSamples.Tests.Greeters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCSamples.Tests.Initialization
{
    [TestClass]
    public class Setup
    {
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            var container = new Container();

            container.Register<IGreeter, HelloTesterGreeter>();

            container.Verify();

            DependencyResolver.SetupContainer(container);
        }
    }
}
