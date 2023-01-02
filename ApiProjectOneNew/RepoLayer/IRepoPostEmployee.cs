using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsLayer;

namespace RepoLayer
{
    public interface IRepoPostEmployee
    {
        /*
        Ticket ChangeTicketStatus(bool v, TicketStatus newStatus);
        List<Ticket>? GetTicketList(bool v);
        Ticket NewTicket(object ticketID);
        Employee RegisterUser(string email, string emailPassword);
        string UserLogin(string email, string emailPassword);
        */

        public Employee PostEmployee(Employee emp);
    }
}
