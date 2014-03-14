using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Configuration;

namespace ErrorApp.Code
{
    public class EmailLogMedia : LogMedia
    {
		public override void LogMessage(string message)
		{
			using ( MailMessage errorEmail = new MailMessage( ) )
			{
				string strEmail = ConfigurationManager.AppSettings["Email"];
				// See above, email address should
				// be read from appSettings:
				errorEmail.To.Add( strEmail );
				errorEmail.Subject = "Error Message " + DateTime.Now;
				errorEmail.Body = message;
				using( SmtpClient client = new SmtpClient( ) )
				{
				client.EnableSsl = true; // Not always necessary
				client.Send( errorEmail );
				}
			}
		}
    }
}