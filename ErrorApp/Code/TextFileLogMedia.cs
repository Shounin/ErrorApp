using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.IO;

namespace ErrorApp.Code
{
    public class TextFileLogMedia :LogMedia
    {
        string LogFilePath = ConfigurationManager.AppSettings["LogFile"];
        public override void LogMessage(string message)
        {
            using (StreamWriter writer = File.AppendText(LogFilePath))
            {
                writer.WriteLine(message);
            }
        }
    }
}