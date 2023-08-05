using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sportz_Club_Management_and_Data_Processing
{
    public class AthleteManagement
    {
        private List<Athlete> athletes;
        private int nextAthleteId;

        public AthleteManagement()
        {
            athletes = new List<Athlete>();
            nextAthleteId = 1;
        }

        public int RegisterAthlete(string firstName, string lastName, int age, string sport, DateTime registrationDate)
        {
            int athleteId = nextAthleteId;
            Athlete athlete = new Athlete(athleteId, firstName, lastName, age, sport, registrationDate);
            athletes.Add(athlete);
            nextAthleteId++;
            return athleteId;
        }

        public string ViewAthleteDetails(int athleteId)
        {
            Athlete athlete = athletes.Find(a => a.AthleteId == athleteId);
            if (athlete != null)
            {
                return $" FirstName: {athlete.FirstName}, LastName: {athlete.LastName}, Age: {athlete.Age}, Sport: {athlete.Sport}, RegistrationDate: {athlete.RegistrationDate}";
            }
            else
            {
                return "Athlete not found.";
            }
        }

        public string UpdateAthleteDetails(int athleteId, string firstName, string lastName, int age, string sport)
        {
            Athlete athlete = athletes.Find(a => a.AthleteId == athleteId);
            if (athlete != null)
            {
                athlete.FirstName = firstName;
                athlete.LastName = lastName;
                athlete.Age = age;
                athlete.Sport = sport;
                return "Update successful.";
            }
            else
            {
                return "Athlete not found.";
            }
        }

        public string RemoveAthlete(int athleteId)
        {
            int index = athletes.FindIndex(a => a.AthleteId == athleteId);
            if (index != -1)
            {
                athletes.RemoveAt(index);
                return "Athlete removed successfully.";
            }
            else
            {
                return "Athlete not found.";
            }
        }
    }
}

