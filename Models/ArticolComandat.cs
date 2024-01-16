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

        // cheie primara
        public int ComandaId { get; set; }

        // Proprietate de navigare
        public Produs? Produs { get; set; }
        public Comanda? Comanda { get; set; }

        
    }
}