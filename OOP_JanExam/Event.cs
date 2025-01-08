using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_JanExam
{
    public enum EventType { Music, Comedy, Theatre }
    internal class Event : IComparable<Event>
    {
        #region properties
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public List<Ticket> Tickets { get; set; }
        public EventType TypeOfEvent { get; set; }
        #endregion properties

        public Event(string name, DateTime eventDate, List<Ticket> tickets, EventType typeOfEvent) 
        {
            Name = name;
            EventDate = eventDate;
            Tickets = tickets;
            TypeOfEvent = typeOfEvent;
        }

        //Used to sort a list of Event items by day of month
        public int CompareTo(Event other)
        {
            return this.EventDate.Day.CompareTo(other.EventDate.Day);
        }

        public override string ToString()
        {
            return $"{Name} - {EventDate}";
        }
    }
}

