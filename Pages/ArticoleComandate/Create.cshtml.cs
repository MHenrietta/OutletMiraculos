using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MagazinOnline.Data;
using MagazinOnline.Models;

namespace MagazinOnline.Pages.ArticoleComandate
{
    public class CreateModel : PageModel
    {
        private readonly MagazinOnline.Data.MagazinOnlineContext _context;

        public CreateModel(MagazinOnline.Data.MagazinOnlineContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ComandaId"] = new SelectList(_context.Comanda, "ComandaId", "ComandaId");
        ViewData["ProdusId"] = new SelectList(_context.Produs, "ProdusId", "Nume");
            return Page();
        }

        [BindProperty]
        public ArticolComandat ArticolComandat { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ArticolComandat.Add(ArticolComandat);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
