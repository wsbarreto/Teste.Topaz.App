using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Teste.Topaz.App.DTO;
using Teste.Topaz.App.Data.Context;

namespace Teste.Topaz.App.Pages
{
    public class EditModel : PageModel
    {
        private readonly Teste.Topaz.App.Data.Context.DataContext _context;

        public EditModel(Teste.Topaz.App.Data.Context.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CompactDiscDTO CompactDiscDTO { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.CompactDiscDTO == null)
            {
                return NotFound();
            }

            var compactdiscdto =  await _context.CompactDiscDTO.FirstOrDefaultAsync(m => m.ID == id);
            if (compactdiscdto == null)
            {
                return NotFound();
            }
            CompactDiscDTO = compactdiscdto;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CompactDiscDTO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompactDiscDTOExists(CompactDiscDTO.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CompactDiscDTOExists(Guid id)
        {
          return (_context.CompactDiscDTO?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
