using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MagazinOnline.Data;
using MagazinOnline.Models;
using Microsoft.AspNetCore.Authorization;

namespace MagazinOnline.Pages.Clienti
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly MagazinOnline.Data.MagazinOnlineContext _context;

        public IndexModel(MagazinOnline.Data.MagazinOnlineContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Client = await _context.Client.ToListAsync();
        }
    }
}
