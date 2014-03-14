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
            m_append = "" + Environment.NewLine + "-------------------------------------------";
            m_prepend = "[" + (DateTime.Now).ToString() + "]" + Environment.NewLine;
            LogException(ex);
        }
        string m_append, m_prepend;
        List<LogMedia> m_loggers = new List<LogMedia> {
        new OutputWindowLogMedia(),
        new EmailLogMedia(),
        new TextFileLogMedia(),
        };
        void LogException(Exception ex)
    {
        foreach (LogMedia log in m_loggers)
        {
            log.LogMessage(m_prepend + ex.ToString() + m_append);
        }
    }
    }
}