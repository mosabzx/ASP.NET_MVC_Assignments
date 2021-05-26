using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_MVC_Assignments.Models
{
    public class FormModel
    {
        
        public double tempreature { get; set; }
        public string message { get; set; }


        
        public static string Check( double id, string result )
        {
            

            string noFever = "You are fine you don't have fever";


            if (id >= 39)
            {
                result = "You have high grade fever.";
            }
            else if (id <= 38.9 && id >= 37.6)
            {
                result = "You have low grade fever.";
            }
            else if (id <= 37.5 && id >= 35.1)
            {
                result = noFever;
            }
            else if(id <= 35)
            {
                result = "You have hypothermia it's means you have a too low temperature.";
            }
            else
            {
                result = "Incorrect Value!";
            }

            return result;

      
            
        }

    }
}
