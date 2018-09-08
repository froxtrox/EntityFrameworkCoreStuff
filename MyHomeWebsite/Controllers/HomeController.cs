using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHomeWebsite.Models;
using MyHomeWebsite.Services;

namespace MyHomeWebsite.Controllers
{
    public class HomeController : Controller
    {

        IWorkExperienceData _workExperience;
        IGreeter _greeter;

        public HomeController(IWorkExperienceData workExperienceData, IGreeter greeter)
        {
            _workExperience = workExperienceData;
            _greeter = greeter;
        }

        public IActionResult Index()
        {
            var exp = _workExperience.GetAll().First();
            return View(exp);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
