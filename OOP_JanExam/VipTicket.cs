using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_JanExam
{
    internal class VipTicket : Ticket
    {
        public string AdditionalExtras { get; set; }

        public decimal AdditionalCost { get; set; }

        public VipTicket(string name, decimal price, int availableTickets, string additionalExtras, decimal additionalCost) : base(name, price, availableTickets)
        {
            AdditionalExtras = additionalExtras;
            AdditionalCost = additionalCost;
            Price += AdditionalCost;
        }

        public override string ToString()
        {
            return $"{Name} - {Price.ToString("c")} [AVAILABLE - ({AdditionalExtras}) {AvailableTickets}]";
        }
    }
}
