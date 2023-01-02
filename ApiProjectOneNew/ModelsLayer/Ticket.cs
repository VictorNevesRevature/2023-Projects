using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsLayer;

namespace ModelsLayer
{

    public enum TicketStatus 
        {
            PENDING = 1,
            APPROVED = 2,

            REJECTED = 3

        }
    public class Ticket
    {

        
        public Ticket(int ticketID=-1, string ticketType="default", double ticketAmount=0, string ticketDescription="default", int UserID=-1, TicketStatus TicketStat = TicketStatus.PENDING )
        {
            this.ticketID = ticketID;
            this.ticketType = ticketType;
            this.ticketAmount = ticketAmount;
            this.ticketDescription = ticketDescription;
            this.UserID = UserID;
            this.TicketStat = TicketStat;
        }

        public int ticketID {get;set;}
        public string ticketType {get; set;}
        public double ticketAmount{get;set;}

        public string ticketDescription{get;set;}

        public int UserID{get;set;}

        public TicketStatus TicketStat {get;set;}

        

    }
}