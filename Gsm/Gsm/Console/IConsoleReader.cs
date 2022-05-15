using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Inner = System.Console;

namespace Gsm.Console
{
    public interface IConsoleReader
    {
        bool KeyAvailable { get; }
        ConsoleKeyInfo ReadKey(bool intercept);
        string ReadLine();
    }
}
