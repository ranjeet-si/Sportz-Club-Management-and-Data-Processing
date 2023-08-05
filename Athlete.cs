using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sportz_Club_Management_and_Data_Processing
{
    public class Athlete
    {
        public int AthleteId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Sport { get; set; }
        public DateTime RegistrationDate { get; set; }

     
        public Athlete(int athleteId, string firstName, string lastName, int age, string sport, DateTime registrationDate)
        {
            AthleteId = athleteId;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Sport = sport;
            RegistrationDate = registrationDate;
        }

        public override bool Equals(object obj)
        {
            if (obj is Athlete otherAthlete)
            {
                return this.AthleteId == otherAthlete.AthleteId;
            }

            return false;
        }


        public override int GetHashCode()
        {
            return this.AthleteId.GetHashCode();
        }
    }
}
    
