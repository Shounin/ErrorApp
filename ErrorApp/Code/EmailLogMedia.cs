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
				// Code shamelessly stolen from the book
				errorEmail.To.Add( strEmail );
				errorEmail.Subject = "Error Message " + DateTime.Now;
				errorEmail.Body = message;
				using( SmtpClient client = new SmtpClient( ) )
				{
				client.EnableSsl = true;
				client.Send( errorEmail );
				}
			}
		}
    }
}