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
            return View();
        }

        [Route("localhost/FeverCheck")]
        [HttpPost]
        
        public IActionResult FeverCheck(FormModel temp)
        {
            try
            {
                string result = FormModel.Check(temp.tempreature, temp.message);

                //If the value is not set, the page should not get a message to display, otherwise it should evaluate it and send back the message.

                if (temp.tempreature <= 0)
                {
                    //ViewBag.Message = "Please enter a value."; 
                }
                else
                {
                    ViewBag.Message = $"The Result is : {result}";
                }
                
                return View();
            }
            catch 
            {

                return View();
            }
            
        }



    }


}
