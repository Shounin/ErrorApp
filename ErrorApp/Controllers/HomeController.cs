using ErrorApp.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErrorApp.Controllers
{
	public class HomeController : Controller
	{
        Random rnd = new Random();
		public ActionResult Index()
		{
			return View();
		}
        public ActionResult ErrorMaybe()
        {
            if (rnd.Next(6) % 5 == 0)
            {
                try
                {
                    throw new ArgumentException("Styrmir made a poopie");
                }
                catch (Exception ex)
                {
                    Logger logInstance = new Logger(ex);
                }
                return View("Error");
            }
            else if(rnd.Next(6) % 5 == 1)
            {
                try
                {
                    throw new MyApplicationException("Styrmir made a poopie");
                }
                catch (Exception ex)
                {
                    Logger logInstance = new Logger(ex);
                }
                return View("Error");
            }
            return View("Index");
        }
	}
}