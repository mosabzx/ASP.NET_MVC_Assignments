using ASP.NET_MVC_Assignments.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_MVC_Assignments.Controllers
{
    
    public class PersonsController : Controller
    {
        public PersonsModel person;


        static List<PersonsModel> PeopleList = new List<PersonsModel>
        {
            new PersonsModel
            {
                 Id = 1, Name = "Mosab", City = "Halmstad" , Phone = 0737771507
            },
            new PersonsModel
            {
                Id = 2, Name = "Mario", City = "Stockholm" , Phone = 1234567890
            },
            new PersonsModel
            {
                Id = 3, Name = "Zoro", City = "Helsingborg" , Phone = 098432345
            },
        };

        public PersonsController(PersonsModel person)
        {
            this.person = person;
            
            
        }

        


        // GET: PersonsController
        public ActionResult Index()
        {

            var persons = PeopleList;

            return View(persons);
        }
        


        // GET: PersonsController/Details/5
        public ActionResult Details(int id)
        {
            
            var persons = PeopleList.SingleOrDefault(p => p.Id == id);
            return View(persons);
        }





        // GET: PersonsController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: PersonsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonsModel persons)
        {
            try
            {
                
                PeopleList.Add(persons);

               
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }





        //Get:
        public ActionResult Filter()
        {

            return View();
        }

        //Post:
        [HttpPost]
        public ActionResult Filter(string filter)
        {
           var result = PeopleList.Where(p => p.Name.Contains(filter) || p.City.Contains(filter)).ToList();
            

            return View(result);
        }


        // GET: PersonsController/Delete/5
        public ActionResult Delete(int id)
        {
           var persons = PeopleList.SingleOrDefault(p => p.Id == id);
          
            return View(persons);
        }

        // POST: PersonsController/Delete/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Delete(int id,PersonsModel persons)
        {
            try
            {
                
                var person = PeopleList.SingleOrDefault(p => p.Id == id);
                PeopleList.Remove(person);
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }










        //// GET: PersonsController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: PersonsController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}












    }
}
