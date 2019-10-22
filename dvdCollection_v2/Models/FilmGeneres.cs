using System.Collections.Generic;
using system.ComponentModel.DataAnnotations;

namespace dvdCollection.Models {

    public class FilmGeneres {
        [Key]
        [Display(nameof="ID")]
        public int GenereID { get; set;}
        [Display(Name="Description",Prompt="Descripcion del genero")]
        [Required(ErrorMessage="Descripcion del genero obligatoria")] //para que el campo sea obligatorio
        [StringLength(60)]
        public string GenreDesc { get; set;}

        public ICollection<FilmTitles> FilmTitles { get; set;}

    }
}