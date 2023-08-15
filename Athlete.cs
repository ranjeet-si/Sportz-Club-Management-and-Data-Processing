using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sportz_Club_Management_and_Data_Processing
{
    class Athlete
    {
        public int AthleteId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Sport { get; set; }
        public DateTime RegistrationDate { get; set; }

        public static int NextAthleteId = 1;

        public Athlete(string firstName, string lastName, int age, string sport, DateTime registrationDate)
        {
            AthleteId = NextAthleteId++;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Sport = sport;
            RegistrationDate = registrationDate;
        }
    }

   
}
    
