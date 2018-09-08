using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHomeWebsite.Models;

namespace MyHomeWebsite.Controllers
{

    [Route("[controller]/[action]")]
    public class AboutController : Controller
    {

        public string AboutThisMan()
        {
            return "alpha";
        }

        public string AboutThisMansWork()
        {
            return "mans not hot";
        }
    }
}
