using System.ComponentModel.DataAnnotations.Schema;

namespace MagazinOnline.Models
{
    public class ArticolComandat
    {

        public int ArticolComandatId { get; set; }
        public int ProdusId { get; set; }
        public int Cantitate { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }

        // Foreign keys
        public int ComandaId { get; set; }

        // Navigation properties
        public Produs? Produs { get; set; }
        public Comanda? Comanda { get; set; }

        
    }
}