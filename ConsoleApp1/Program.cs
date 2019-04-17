using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        private static void GetadtData(string adtInfo)
        {
            Console.WriteLine(adtInfo);
        }
        

        static void Main(string[] args)
        {
            var error = new LoggerFile();
            var error2 = new LoggerConsole();
            var myLogger = new Logger(error);

            var authLogger = new AuthLogger(error2, "");

            myLogger.LogWarnMSG("Not declared");

            Logger myLogger2 = new Logger(error2);
            myLogger2.LogWarnMSG("Warning");


            authLogger.LogErrorMsg("; missing");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(myLogger.logType(GetadtData));

            string firstName = "Paulo";
            string lastName = "Costa";

            Func<string,string,string> Concat = (f,l) => $"Concatened: {f} {l}";

            Console.WriteLine(Concat(firstName, lastName));



            Console.ReadKey();
        }
    }
}
