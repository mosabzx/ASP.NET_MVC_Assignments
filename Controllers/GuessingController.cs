using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_MVC_Assignments.Controllers
{
    public class GuessingController : Controller
    {
        public IActionResult Guessing()
        {
            return View();
        }
    }
}
