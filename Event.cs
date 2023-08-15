using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportz_Club_Management_and_Data_Processing
{
    class Event
    {
        public int EventId { get; private set; }
        public string EventName { get; set; }
        public string EventType { get; set; }
        public DateTime EventDate { get; set; }

        public static int NextEventId = 1;

        public Event(string eventName, string eventType, DateTime eventDate)
        {
            EventId = NextEventId++;
            EventName = eventName;
            EventType = eventType;
            EventDate = eventDate;
        }
    }
}
