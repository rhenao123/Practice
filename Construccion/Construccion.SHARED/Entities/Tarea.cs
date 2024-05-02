using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace construccion.Shared.Entities
{
    public class Tarea
    {

        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; }

        [Display(Name = "Descripcion")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}",
        ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public DateTime FechaStart { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd }",
        ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]


        public DateTime FechaEnd { get; set; }

        [JsonIgnore]
        public ICollection<AssigmentMats> assigmentMatss { get; set; }

        [JsonIgnore]
        public ProjectConstr ProjectConstrs { get; set; }

        public int ProjectConstrId { get; set; }

    }
}
