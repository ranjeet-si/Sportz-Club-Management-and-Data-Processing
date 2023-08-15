
namespace Sportz_Club_Management_and_Data_Processing
{
    internal class Program
    {

        static void Main(string[] args)
        {
            SportzClubManagementSystem clubManagement = new SportzClubManagementSystem();

            while (true)
            {
                Console.WriteLine("Sportz Club Management System and Data Processing");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1. Register Athlete");
                Console.WriteLine("2. View Athlete Details");
                Console.WriteLine("3. Create Event");
                Console.WriteLine("4. View Event Details");
                Console.WriteLine("5. Record Athlete's Performance");
                Console.WriteLine("6. View Athlete's Performance");
                Console.WriteLine("7. Exit");
                Console.Write("Select an option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter First Name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Enter Last Name: ");
                        string lastName = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Sport: ");
                        string sport = Console.ReadLine();
                        DateTime registrationDate = DateTime.Now;
                        int athleteId = clubManagement.RegisterAthlete(firstName, lastName, age, sport, registrationDate);
                        Console.WriteLine($"Athlete registered with ID: {athleteId}");
                        break;

                    case 2:
                        Console.Write("Enter Athlete ID: ");
                        int athleteIdToView = Convert.ToInt32(Console.ReadLine());
                        string athleteDetails = clubManagement.ViewAthleteDetails(athleteIdToView);
                        Console.WriteLine(athleteDetails);
                        break;

                   
                    case 7:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}