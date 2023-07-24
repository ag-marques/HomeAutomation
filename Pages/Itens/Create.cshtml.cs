using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HomeAutomation.Data;
using HomeAutomation.Models;

namespace HomeAutomation.Pages.Itens
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
            return Page();
        }

        [BindProperty]
        public Item Item { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Itens == null || Item == null)
            {
                return Page();
            }

            _context.Itens.Add(Item);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
