using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MagazinOnline.Models;

namespace MagazinOnline.Data
{
    public class MagazinOnlineContext : DbContext
    {
        public MagazinOnlineContext (DbContextOptions<MagazinOnlineContext> options)
            : base(options)
        {
        }

        public DbSet<MagazinOnline.Models.Produs> Produs { get; set; } = default!;
        public DbSet<MagazinOnline.Models.Comanda> Comanda { get; set; } = default!;
        public DbSet<MagazinOnline.Models.Client> Client { get; set; } = default!;
        public DbSet<MagazinOnline.Models.Categorie> Categorie { get; set; } = default!;
        public DbSet<MagazinOnline.Models.ArticolComandat> ArticolComandat { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>()
                .Property(c => c.Adresa)
                .IsRequired(false);

        }

    }

}
