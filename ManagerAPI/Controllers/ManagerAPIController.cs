using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManagerAPI.Controllers
{
    public class ManagerAPIController : Controller
    {
        // GET: ManagerAPI
        public ActionResult Index()
        {
            return View();
        }
    }
}