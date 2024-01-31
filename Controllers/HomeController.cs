using GitFun.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GitFun.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
