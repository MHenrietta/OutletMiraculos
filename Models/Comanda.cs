namespace MagazinOnline.Models
{
    public class Comanda
    {

        public int ComandaId { get; set; }

        public DateTime ComandaPlasata { get; set; }

        public string StatusComanda { get; set; }

        public int ClientId { get; set; }

        public Client? Client { get; set; } 

        // Navigation property
        public List<ArticolComandat>? ArticoleComandate { get; set; }
    }
}
