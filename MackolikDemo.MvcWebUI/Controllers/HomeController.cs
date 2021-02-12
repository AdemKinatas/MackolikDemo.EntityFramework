using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MackolikDemo.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        ITeamService _teamService;

        public HomeController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddTeam()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}