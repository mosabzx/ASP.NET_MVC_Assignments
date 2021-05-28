using ASP.NET_MVC_Assignments.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_MVC_Assignments.Controllers
{
    public class FormController : Controller
    {
        

        [Route("localhost/FeverCheck")]
        [HttpGet]
        public IActionResult FeverCheck()
        {
            ViewBag.Message = TempData["Message"];
            return View();
        }

        [Route("localhost/FeverCheck")]
        [HttpPost]
        
        public IActionResult FeverCheck(FormModel temp)
        {
            try
            {
                string result = FormModel.Check(temp.tempreature, temp.message);
                string message = $"The Result is : {result}";

                //If the value is not set, the page should not get a message to display, otherwise it should evaluate it and send back the message.

                if (temp.tempreature <= 0 && ModelState.IsValid)
                {
                    
                }
                else
                {
                    ViewBag.Message = message;
                   
                }
                TempData["Message"] = ViewBag.Message;

                return RedirectToAction("FeverCheck");
            }
            catch 
            {

                return View();
            }
            

        }



    }


}
