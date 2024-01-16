using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MagazinOnline.Models
{
    public class Produs
    {
        public int ProdusId { get; set; }
        [Required(ErrorMessage = "Numele produsului este obligatoriu.")]
        [Display(Name = "NumeProdus")]
        public string Nume { get; set; }

        [Required(ErrorMessage = "O scurta descriere este obligatorie.")]
        public string Descriere { get; set; }

        // Cheie primara
        public int CategorieId { get; set; }

        // Proprietate de navigare
        public Categorie? Categorie { get; set; }

        

   
    }
}
