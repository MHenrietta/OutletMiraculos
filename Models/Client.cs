using System.ComponentModel.DataAnnotations;

namespace MagazinOnline.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientNume { get; set; }

        [Display(Name = "ClientPrenume")]
        public string Prenume { get; set; }
        public string Email { get; set; }

        public string Adresa { get; set; }

        public string NumarTelefon { get; set; }

        public List<Comanda>? Comenzi { get; set; }

    }
}