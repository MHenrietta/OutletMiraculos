using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MagazinOnline.Data;
using MagazinOnline.Models;

namespace MagazinOnline.Pages.Comenzi
{
    public class DetailsModel : PageModel
    {
        private readonly MagazinOnline.Data.MagazinOnlineContext _context;

        public DetailsModel(MagazinOnline.Data.MagazinOnlineContext context)
        {
            _context = context;
        }

        public Comanda Comanda { get; set; } = default!;

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Comanda = _context.Comanda.Include(p => p.Client).FirstOrDefault(m => m.ComandaId == id);

            if (Comanda == null)
            {
                return NotFound();
            }

            return Page();
        }
    }

}
