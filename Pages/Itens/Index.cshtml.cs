using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HomeAutomation.Data;
using HomeAutomation.Models;

namespace HomeAutomation.Pages.Itens
{
    public class IndexModel : PageModel
    {
        private readonly HomeAutomation.Data.BudgetContext _context;

        public IndexModel(HomeAutomation.Data.BudgetContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Itens != null)
            {
                Item = await _context.Itens.Take(20).ToListAsync();
            }
        }
    }
}
