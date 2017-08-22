using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldLib.Test
{
    [TestFixture]
    public class HellowWorldLibTest
    {
        [Test]
        public void SubstituteFor_CreateHelloWorld()
        {
            HelloWorldFactory factory = Substitute.For<HelloWorldFactory>();
            Assert.IsInstanceOf(typeof(ConsoleApp.HelloWorld), factory.CreateHelloWorldObj());
            
        }
    }
}
