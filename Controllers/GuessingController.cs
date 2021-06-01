using ASP.NET_MVC_Assignments.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_MVC_Assignments.Controllers
{
    public class GuessingController : Controller
    {
        public GuessingGame guess;
        const string RandomSession = "RandomSession";
        const string InputSession = "InputSession";

        public GuessingController(GuessingGame guess)
        {
            this.guess = guess;
            this.guess.Input = guess.Input;
            this.guess.RandNumber = guess.RandNumber;
            this.guess.InfoMessage = guess.InfoMessage;
            
        }





        public IActionResult RandomG()
        {
            //Resetting the sessions on startup or request a new page.
            HttpContext.Session.Clear();

            //Generate random number.
            Random rand = new Random();
            guess.RandomGenerator(guess.RandNumber);

            //Assign random number to a session.
            HttpContext.Session.SetInt32(RandomSession, guess.RandNumber);

            return RedirectToAction("Guessing");
        }




        [Route("GuessingGame")]
        public IActionResult Guessing()
        {
            //Getting a user input value from session.
            guess.Input = Convert.ToInt32(HttpContext.Session.GetInt32(InputSession));
            ViewBag.UserInput = $"Your last gueseing: {guess.Input}";


            //Condition to redirect and generate a new random.
            if (guess.RandNumber == guess.Input)
            {
                return RedirectToAction("RandomG");
            }



            ViewBag.Result = TempData["Result"];
            ViewBag.Error = TempData["Error"];

            ////Just for checkimg the random.
            //guess.RandNumber = Convert.ToInt32(HttpContext.Session.GetInt32(RandomSession));
            //ViewBag.RandomNumber = guess.RandNumber;


            return View();
        }



        [Route("GuessingGame")]
        [HttpPost]
        public IActionResult Guessing(GuessingGame guess)
        {
            //Assign an input value to session.
            HttpContext.Session.SetInt32(InputSession, guess.Input);

            //Getting a random number from session.
            guess.RandNumber= Convert.ToInt32(HttpContext.Session.GetInt32(RandomSession));

            //Handling the guessing value to get the result.
            string result = guess.GetResult(guess.InfoMessage, guess.RandNumber, guess.Input);

            

            //Adding verfication.
            if (guess.Input <= 0)
            {
                ViewBag.Error = "Error! You have to insert a number Between 1-100!";
                TempData["Error"] = ViewBag.Error;
            }
            else if (ModelState.IsValid && guess.Input != 0)
            {
                //Printing the info message.
                result = $" The Result is: {result}";
                ViewBag.Result = result;
                TempData["Result"] = ViewBag.Result;
            }



            return RedirectToAction("Guessing");
        }
    }
}
