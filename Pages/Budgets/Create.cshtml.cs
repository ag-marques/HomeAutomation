using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HomeAutomation.Data;
using HomeAutomation.Models;

namespace HomeAutomation.Budgets
{
    public class CreateModel : PageModel
    {
        private readonly HomeAutomation.Data.BudgetContext _context;

        public CreateModel(HomeAutomation.Data.BudgetContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ClientId"] = new SelectList(_context.Client, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Budget Budget { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Budgets == null || Budget == null)
            {
                return Page();
            }

            _context.Budgets.Add(Budget);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
