using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_JanExam
{
    public enum EventType { Music, Comedy, Theatre }
    internal class Event
    {
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public List<Ticket> Tickets { get; set; }
        public EventType TypeOfEvent { get; set; }
    }
}

