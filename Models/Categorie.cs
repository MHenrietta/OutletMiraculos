using System.ComponentModel.DataAnnotations;

namespace MagazinOnline.Models
{
    public class Categorie
    {

        public int CategorieId { get; set; }

        [Display(Name = "NumeCategorie")]
        public string Nume { get; set; }

        [Required(ErrorMessage = "O scurta descriere este obligatorie.")]
        public string Descriere { get; set; }

        // Proprietate de navigare
        public List<Produs>? Produse { get; set; }
    }
}