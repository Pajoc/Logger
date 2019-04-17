using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LoggerFile : ILogger
    {
        public void LogErrorMsg(string msg)
        {
            Console.WriteLine("Saved in File: {0}", msg);
        }

        public void LogWarningMsg(string msg)
        {
            Console.WriteLine("Saved in File2: {0}", msg);
        }
    }
}
