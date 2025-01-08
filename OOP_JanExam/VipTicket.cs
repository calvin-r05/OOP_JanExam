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
    }
}
