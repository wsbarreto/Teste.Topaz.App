using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Teste.Topaz.App.DTO;
using Teste.Topaz.App.Data.Context;

namespace Teste.Topaz.App.Pages
{
    public class CreateModel : PageModel
    {
        private readonly Teste.Topaz.App.Data.Context.DataContext _context;

        public CreateModel(Teste.Topaz.App.Data.Context.DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CompactDiscDTO CompactDiscDTO { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.CompactDiscDTO == null || CompactDiscDTO == null)
            {
                return Page();
            }

            _context.CompactDiscDTO.Add(CompactDiscDTO);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
