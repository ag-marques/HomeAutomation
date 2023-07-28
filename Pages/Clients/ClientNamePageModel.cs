using HomeAutomation.Data;
using HomeAutomation.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HomeAutomation.Pages.Clients
{
    public class ClientNamePageModel
    {
        public SelectList? ClientNameSL { get; set; }

        public void PopulateClientsDropDownList(BudgetContext _context, object selectedClient = null)
        {
            var clientsQuery = from d in _context.Client
                                   orderby d.Name // Sort by name.
                                   select d;

            ClientNameSL = new SelectList(clientsQuery.AsNoTracking(),
                nameof(Client.Id),
                nameof(Client.Name),
                selectedClient);    
        }
        
    }
}