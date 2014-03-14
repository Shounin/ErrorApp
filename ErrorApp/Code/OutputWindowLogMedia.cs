using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace ErrorApp.Code
{
    public class OutputWindowLogMedia : LogMedia
    {
        //RAWR
        public override void LogMessage(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }
    }
}
