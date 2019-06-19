using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AuthLogger : ILogger
    {
        private ILogger _Logger;
        private readonly string _Credential;

        public AuthLogger(ILogger Logger, string Credential)
        {
            _Logger = Logger;
            _Credential = Credential;
        }

        public void LogErrorMsg(string msg)
        {
            if (IsValidCred())
            {
                _Logger.LogErrorMsg("Log the error");
            }
            else
            {
                _Logger.LogErrorMsg("Autentication falied!");
            }
        }

        public void LogWarningMsg(string msg)
        {
            if (IsValidCred())
            {
                _Logger.LogErrorMsg("Lof the warning");
            }
            else
            {
                _Logger.LogErrorMsg("Autentication failed!");
            }
        }

        private bool IsValidCred()
        {
            if (!string.IsNullOrEmpty(_Credential))
            {
                return true;
            }
            return false;
        }

    }
}
