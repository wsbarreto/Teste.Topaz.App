using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Teste.Topaz.App.DTO;
using Teste.Topaz.App.Data.Context;

namespace Teste.Topaz.App.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Teste.Topaz.App.Data.Context.DataContext _context;

        public DetailsModel(Teste.Topaz.App.Data.Context.DataContext context)
        {
            _context = context;
        }

      public CompactDiscDTO CompactDiscDTO { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.CompactDiscDTO == null)
            {
                return NotFound();
            }

            var compactdiscdto = await _context.CompactDiscDTO.FirstOrDefaultAsync(m => m.ID == id);
            if (compactdiscdto == null)
            {
                return NotFound();
            }
            else 
            {
                CompactDiscDTO = compactdiscdto;
            }
            return Page();
        }
    }
}
