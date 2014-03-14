using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ErrorApp.Code
{
    public class Logger
    {
        public Logger(Exception ex)
        {
            s = "" + Environment.NewLine + "   Time of error -" + (DateTime.Now).ToString();
            LogException(ex);
        }
        string s;
        List<LogMedia> m_loggers = new List<LogMedia> {
        new OutputWindowLogMedia(),
        new EmailLogMedia(),
        new TextFileLogMedia(),
        };
        void LogException(Exception ex)
    {
        foreach (LogMedia log in m_loggers)
        {
            log.LogMessage(ex.ToString() + s);
        }
    }
    }
}