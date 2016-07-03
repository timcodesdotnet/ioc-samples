using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IoCSamples.DependencyInjection;

namespace IoCSamples.Tests
{
    [TestClass]
    public class MessengerTests
    {
        [TestMethod]
        public void MessengerDisplaysCorrectMessage()
        {
            var messenger = DependencyResolver.Get<Messenger>();
            Assert.AreEqual("Hello Tester!", messenger.GetWelcomeMessage());
        }
    }
}
