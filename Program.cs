
namespace Sportz_Club_Management_and_Data_Processing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AthleteManagement athleteManagement = new AthleteManagement();

           
            int athleteId = athleteManagement.RegisterAthlete("Ranjeet", "Yadav", 21, "kabaddi", DateTime.Now);

            
            string athleteDetails = athleteManagement.ViewAthleteDetails(athleteId);
            Console.WriteLine("Athlete Details:");
            Console.WriteLine(athleteDetails);
        }
    }
}