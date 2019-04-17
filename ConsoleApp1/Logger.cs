using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Logger 
    {
        private ILogger _logObject;

        //Custom delegate não necessário usa-se custom delegate
        //public delegate void varName(string myData);

        public Logger(ILogger logObject)
        {
            _logObject = logObject;
        }

        public void LogErroMSG(string msg)
        {
            _logObject.LogErrorMsg(msg);
        }

        public void LogWarnMSG(string msg)
        {
            _logObject.LogWarningMsg(msg);
        }

        //public string logType(varName vName)
        public string logType(Action<string> vName)
        {
            var interfType = _logObject.GetType();
            string myData;
            myData = "Aditional info: Data type = " + interfType.ToString();
            vName(myData);
            return interfType.ToString();
        }

    }
}
