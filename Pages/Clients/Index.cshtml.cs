using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HomeAutomation.Data;
using HomeAutomation.Models;

namespace HomeAutomation.Pages.Clients
{
    public class IndexModel : PageModel
    {
        private readonly HomeAutomation.Data.BudgetContext _context;

        public IndexModel(HomeAutomation.Data.BudgetContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Client != null)
            {
                Client = await _context.Client.Take(20).ToListAsync();
            }
        }
    }
}
