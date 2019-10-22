using System.Collections.Generic;
using system.ComponentModel.DataAnnotations;

namespace dvdCollection.Models {

    public class Certificates {
        [Key]
        [Display(Name="ID")]
        public int CertificateID { get; set;}
        [Display(Name="Description",Prompt="Descripcon del certificado")]
        [Required(ErrorMessage="La descripcion del certificado es obligatoria")] //para que el campo sea obligatorio
        [StringLength(10)]
        public string Certificate { get; set;}

        public ICollection<FilmTitles> FilmTitles { get; set;}

    }
}