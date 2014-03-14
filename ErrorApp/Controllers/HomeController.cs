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
                Logger logInstance = new Logger(new ArgumentException("Styrmir made a poopie"));
                return View("Error");
            }
            return View("Index");
        }
	}
}