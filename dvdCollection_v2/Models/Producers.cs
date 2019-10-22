using System.Collections.Generic;
using system.ComponentModel.DataAnnotations;

namespace dvdCollection.Models {

    public class Producers {
        [Key]
        [Display(Name="ID")]
        public int ProducerID {get; set;}
        [Display(Name="Name",Prompt="Nombre completo del Productor")]
        [Required(ErrorMessage="Nombre del productor obligatorio")] //para que el campo sea obligatorio
        [StringLength(80)]
        public string ProducerName {get; set;}
        [Display(Name="Email",Prompt="Correo Electronico")]
        [DataType(DataType.EmailAddress)]
        public string ContactEmailAddress {get; set;}
        [DataTypw(DataType.Url)]
        public string WebSite {get; set;}

        public ICollection<FilmTitlesProducers> FilmTitlesProducers {get; set;}
    }
}