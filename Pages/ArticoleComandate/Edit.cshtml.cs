using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MagazinOnline.Data;
using MagazinOnline.Models;

namespace MagazinOnline.Pages.ArticoleComandate
{
    public class EditModel : PageModel
    {
        private readonly MagazinOnline.Data.MagazinOnlineContext _context;

        public EditModel(MagazinOnline.Data.MagazinOnlineContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ArticolComandat ArticolComandat { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articolcomandat =  await _context.ArticolComandat.FirstOrDefaultAsync(m => m.ArticolComandatId == id);
            if (articolcomandat == null)
            {
                return NotFound();
            }
            ArticolComandat = articolcomandat;
           ViewData["ComandaId"] = new SelectList(_context.Comanda, "ComandaId", "ComandaId");
           ViewData["ProdusId"] = new SelectList(_context.Produs, "ProdusId", "Nume");
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

            _context.Attach(ArticolComandat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticolComandatExists(ArticolComandat.ArticolComandatId))
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

        private bool ArticolComandatExists(int id)
        {
            return _context.ArticolComandat.Any(e => e.ArticolComandatId == id);
        }
    }
}
