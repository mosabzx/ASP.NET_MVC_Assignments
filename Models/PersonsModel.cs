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

         List<PersonsModel> PeopleList;

        public PersonsModel()
        {
            
            

        }


        public void Peoples()
        {
            PeopleList = new List<PersonsModel>()
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
                    Id = 3, Name = "Tahoo", City = "Oskarström" , Phone = 0987654321
                },

            };
            

        }


        public List<PersonsModel> List()
        {

            return PeopleList;
        }

        public PersonsModel Find(int id)
        {
            var person = PeopleList.SingleOrDefault(p => p.Id == id);

            return person;
        }

        public PersonsModel Filter(string text,PersonsModel person)
        {
            PeopleList.Where (p => p.Name.Contains(text.ToLowerInvariant()));
            PeopleList.Where(p => p.City.Contains(text.ToLowerInvariant()));

            return person;
        }

        public void Add(PersonsModel person)
        {
            PeopleList.Add(person);
            
        }

        public void Erase (int id)
        {
            var person = Find(id);
            PeopleList.Remove(person);
        }


    }
}
