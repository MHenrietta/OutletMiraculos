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
    public class IndexModel : PageModel
    {
        private readonly MagazinOnline.Data.MagazinOnlineContext _context;

        public IndexModel(MagazinOnline.Data.MagazinOnlineContext context)
        {
            _context = context;
        }

        public IList<ArticolComandat> ArticolComandat { get;set; } = default!;

        public async Task OnGetAsync()
        {
            ArticolComandat = await _context.ArticolComandat
                .Include(a => a.Comanda)
                .Include(a => a.Produs)
                .ToListAsync();
        }
    }
}
