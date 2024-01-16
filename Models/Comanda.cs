using System.ComponentModel.DataAnnotations;

namespace MagazinOnline.Models
{
    public class Comanda
    {

        public int ComandaId { get; set; }

        public DateTime ComandaPlasata { get; set; }

        public string StatusComanda { get; set; }

        [Display(Name = "ClientNume")]
        public int ClientId { get; set; }

        public Client? Client { get; set; } 

        // proprietate de navigare
        public List<ArticolComandat>? ArticoleComandate { get; set; }
    }
}
