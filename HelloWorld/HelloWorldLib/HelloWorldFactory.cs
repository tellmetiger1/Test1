using HelloWorldLib.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldLib
{
    /// <summary>
    /// Hello World Factory to create a hellowWorld obj
    /// </summary>
    public class HelloWorldFactory
    {
        /// <summary>
        /// Create a hello world obj based on the configured target platform
        /// </summary>
        /// <returns></returns>
        public IHelloWorld CreateHelloWorldObj()
        {
            IHelloWorld helloWorldObj;
            switch (HelloWorldSettings.Default.TargetPlatform)
            {
                case "ConsoleApp":
                    helloWorldObj = new ConsoleApp.HelloWorld();
                    break;
                case "Mobile":
                    helloWorldObj = new Mobile.HelloWorld();
                    break;
                default:
                    helloWorldObj = new ConsoleApp.HelloWorld();
                    break;
            }
            return helloWorldObj;
        }
    }
}
