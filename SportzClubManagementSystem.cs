using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportz_Club_Management_and_Data_Processing
{
    class SportzClubManagementSystem
    {
        private List<Athlete> athletes;
        private List<Event> events;
        private Dictionary<Tuple<int, int>, string> athletePerformance;

        public SportzClubManagementSystem()
        {
            athletes = new List<Athlete>();
            events = new List<Event>();
            athletePerformance = new Dictionary<Tuple<int, int>, string>();
        }

        public int RegisterAthlete(string firstName, string lastName, int age, string sport, DateTime registrationDate)
        {
            Athlete newAthlete = new Athlete(firstName, lastName, age, sport, registrationDate);
            athletes.Add(newAthlete);
            return newAthlete.AthleteId;
        }

        public string ViewAthleteDetails(int athleteId)
        {
            Athlete athlete = athletes.FirstOrDefault(a => a.AthleteId == athleteId);
            if (athlete != null)
            {
                return $"Athlete Details:\nFirst Name: {athlete.FirstName}\nLast Name: {athlete.LastName}\nAge: {athlete.Age}\nSport: {athlete.Sport}\nRegistration Date: {athlete.RegistrationDate}";
            }
            return "Athlete not found.";
        }

        // Implement UpdateAthleteDetails and RemoveAthlete methods similarly

        public int CreateEvent(string eventName, string eventType, DateTime eventDate)
        {
            Event newEvent = new Event(eventName, eventType, eventDate);
            events.Add(newEvent);
            return newEvent.EventId;
        }

        public string ViewEventDetails(int eventId)
        {
            Event _event = events.FirstOrDefault(e => e.EventId == eventId);
            if (_event != null)
            {
                return $"Event Details:\nEvent Name: {_event.EventName}\nEvent Type: {_event.EventType}\nEvent Date: {_event.EventDate}";
            }
            return "Event not found.";
        }

        // Implement UpdateEventDetails and RemoveEvent methods similarly

        public void RecordAthletePerformance(int athleteId, int eventId, string performanceData)
        {
            athletePerformance[new Tuple<int, int>(athleteId, eventId)] = performanceData;
        }

        public string ViewAthletePerformance(int athleteId, int eventId)
        {
            string performanceData;
            if (athletePerformance.TryGetValue(new Tuple<int, int>(athleteId, eventId), out performanceData))
            {
                return $"Athlete Performance:\nAthlete ID: {athleteId}\nEvent ID: {eventId}\nPerformance Data: {performanceData}";
            }
            return "Performance data not found.";
        }

        public List<Athlete> GetAthletesBySport(string sport)
        {
            return athletes.Where(a => a.Sport == sport).ToList();
        }

        public List<Event> GetEventsByType(string eventType)
        {
            return events.Where(e => e.EventType == eventType).ToList();
        }

        public Dictionary<string, string> GetAthletePerformanceInAllEvents(int athleteId)
        {
            var performanceInAllEvents = athletePerformance
                .Where(kv => kv.Key.Item1 == athleteId)
                .ToDictionary(kv => events.First(e => e.EventId == kv.Key.Item2).EventName, kv => kv.Value);

            return performanceInAllEvents;
        }

        public List<Event> GetUpcomingEvents()
        {
            return events.Where(e => e.EventDate > DateTime.Now).ToList();
        }
    }
}
