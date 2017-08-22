using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldLib.ConsoleApp
{
    public class HelloWorld : IHelloWorld
    {
        public void PrintHelloWorldToConsole(string str)
        {
            Console.WriteLine(str);
        }

        public void WriteHelloWorldToDB(string str)
        {
            // TODO: write hello world to db
            throw new NotImplementedException();
        }
    }
}
