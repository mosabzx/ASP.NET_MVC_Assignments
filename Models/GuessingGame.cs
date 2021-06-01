using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_MVC_Assignments.Models
{
    public class GuessingGame
    {
        public int Input { get; set; }
        public int RandNumber { get; set; }
        public string InfoMessage { get; set; }
        public List<int> ListOfGuess { get; set; }


        public int RandomGenerator(int randNum)
        {
            Random rand = new Random();
            randNum = rand.Next(1, 101);
            RandNumber = randNum;
            return randNum;
        }

        public string GetResult(string info, int randNum, int input)
        {


            if (randNum == input)
            {
                info = "Congratulating you on your success. A new random number has been generated!";

            }
            else if (randNum < input)
            {
                info = "Your guess is too high.";
            }
            else if (randNum > input)
            {
                info = "Your guess is too low";
            }

            return info;
        }






    }



}
