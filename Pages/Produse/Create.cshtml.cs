using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MagazinOnline.Data;
using MagazinOnline.Models;
using Microsoft.AspNetCore.Authorization;

namespace MagazinOnline.Pages.Produse
{
    [Authorize(Roles = "Admin")]
    public class CreateModel : PageModel
    {
        private readonly MagazinOnline.Data.MagazinOnlineContext _context;

        public CreateModel(MagazinOnline.Data.MagazinOnlineContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CategorieId"] = new SelectList(_context.Set<Categorie>(), "CategorieId", "Nume");
            return Page();
        }

        [BindProperty]
        public Produs Produs { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Produs.Add(Produs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
