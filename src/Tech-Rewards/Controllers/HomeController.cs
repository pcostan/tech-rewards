using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;

namespace Tech_Rewards.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [OutputCache(Duration = (60*24))]
        public ActionResult Index()
        {
            return new FilePathResult("~/index.html", "text/html");
        }
	}
}