using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MagazinOnline.Data;
using MagazinOnline.Models;

namespace MagazinOnline.Pages.ArticoleComandate
{
    public class DetailsModel : PageModel
    {
        private readonly MagazinOnline.Data.MagazinOnlineContext _context;

        public DetailsModel(MagazinOnline.Data.MagazinOnlineContext context)
        {
            _context = context;
        }

        public ArticolComandat ArticolComandat { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articolComandat = await _context.ArticolComandat
                .Include(ac => ac.Produs)
                    .ThenInclude(p => p.Categorie)
                .Include(ac => ac.Comanda)
                    .ThenInclude(c => c.Client)
                .FirstOrDefaultAsync(m => m.ArticolComandatId == id);

            if (articolComandat == null)
            {
                return NotFound();
            }
            else
            {
                ArticolComandat = articolComandat;
            }
            return Page();
        }

    }
}
