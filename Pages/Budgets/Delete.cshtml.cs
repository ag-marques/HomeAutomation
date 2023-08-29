using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HomeAutomation.Data;
using HomeAutomation.Models;

namespace HomeAutomation.Budgets
{
    public class DeleteModel : PageModel
    {
        private readonly HomeAutomation.Data.BudgetContext _context;

        public DeleteModel(HomeAutomation.Data.BudgetContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Budget Budget { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Budgets == null)
            {
                return NotFound();
            }

            var budget = await _context.Budgets.FirstOrDefaultAsync(m => m.Id == id);

            if (budget == null)
            {
                return NotFound();
            }
            else 
            {
                Budget = budget;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Budgets == null)
            {
                return NotFound();
            }
            var budget = await _context.Budgets.FindAsync(id);

            if (budget != null)
            {
                Budget = budget;
                _context.Budgets.Remove(Budget);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
