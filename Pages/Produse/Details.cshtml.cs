using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MagazinOnline.Data;
using MagazinOnline.Models;

namespace MagazinOnline.Pages.Produse
{
    public class DetailsModel : PageModel
    {
        private readonly MagazinOnline.Data.MagazinOnlineContext _context;

        public DetailsModel(MagazinOnline.Data.MagazinOnlineContext context)
        {
            _context = context;
        }

        public Produs Produs { get; set; } = default!;


        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produs = _context.Produs.Include(p => p.Categorie).FirstOrDefault(m => m.ProdusId == id);

            if (Produs == null)
            {
                return NotFound();
            }

            return Page();
        }


    }
}
