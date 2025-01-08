using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_JanExam
{
    internal class Ticket
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int AvailableTickets { get; set; }

        public Ticket(string name, decimal price, int availableTickets)
        {
            Name = name;
            Price = price;
            AvailableTickets = availableTickets;
        }
    }
}
