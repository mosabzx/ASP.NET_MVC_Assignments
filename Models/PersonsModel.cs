using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_MVC_Assignments.Models
{
    public class PersonsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Phone { get; set; }


        static List<PersonsModel> PeopleList;
        






        


        public List<PersonsModel> List()
        {

            return PersonsModel.PeopleList;
        }





        //public void Add(PersonsModel person)
        //{
            
        //    PersonsModel.PeopleList.Add(person);
            
           
        //}

       
        public PersonsModel Find(int id)
        {
            var person = PersonsModel.PeopleList.SingleOrDefault(p => p.Id == id);

            return person;
        }

        //public PersonsModel Filter(string text,PersonsModel person)
        //{
        //    PersonsModel.PeopleList.Where (p => p.Name.Contains(text.ToLowerInvariant()));
        //    PersonsModel.PeopleList.Where(p => p.City.Contains(text.ToLowerInvariant()));

        //    return person;
        //}

        

        //public void Erase (int id)
        //{
        //    var person = Find(id);
        //    PersonsModel.PeopleList.Remove(person);

        //    //PeopleList.Remove(Find(id));

        //    //foreach (var item in PeopleList)
        //    //{
        //    //    if (item == person)
        //    //    {
        //    //        PeopleList.Remove(item);
        //    //    }
        //    //}


        //}


    }
}
