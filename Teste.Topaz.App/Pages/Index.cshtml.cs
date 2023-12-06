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
    public class IndexModel : PageModel
    {
        private readonly Teste.Topaz.App.Data.Context.DataContext _context;

        public IndexModel(Teste.Topaz.App.Data.Context.DataContext context)
        {
            _context = context;
        }

        public IList<CompactDiscDTO> CompactDiscDTO { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.CompactDiscDTO != null)
            {
                CompactDiscDTO = await _context.CompactDiscDTO.ToListAsync();
            }
        }
    }
}
