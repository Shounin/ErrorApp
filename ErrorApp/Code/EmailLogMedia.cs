using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace ErrorApp.Code
{
    public class EmailLogMedia : LogMedia
    {
		public override void LogMessage(string message)
		{
			using ( MailMessage message = new MailMessage( ) )
			{
				// See above, email address should
				// be read from appSettings:
				message.To.Add( strEmail );
				message.Subject = "Email subject line";
				message.Body = "Hello world!";
				using( SmtpClient client = new SmtpClient( ) )
				{
				client.EnableSsl = true; // Not always necessary
				client.Send( message );
				}
			}
		}
    }
}