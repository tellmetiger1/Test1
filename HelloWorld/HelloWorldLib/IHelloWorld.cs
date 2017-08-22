using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldLib
{
    public interface IHelloWorld
    {
        /// <summary>
        ///  print hello world to console
        /// </summary>
        /// <param name="str">input str</param>
        void PrintHelloWorldToConsole(string str);

        /// <summary>
        ///  wirte hello world to database
        /// </summary>
        /// <param name="str">input str</param>
        void WriteHelloWorldToDB(string str);

        // add more here...
    }
}
