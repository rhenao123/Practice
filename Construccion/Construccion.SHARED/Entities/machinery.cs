using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace construccion.Shared.Entities
{
    public class machinery
    {
        public int id { get; set; }
        [Display(Name = "Nombre")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        string name { get; set; }
        [Display(Name = "Cantidad Requerida")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string CantReque { get; set; }

        [Display(Name = "Proveedor")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Proveed { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd }",
            ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public DateOnly FechaEntrga { get; set; }


        [JsonIgnore]
        public Tarea tareas { get; set; }

        public int ProjectTareas { get; set; }


        [JsonIgnore]

        public ProjectConstr ProjectConstrs { get; set; }

        public int ProjectConstrId { get; set; }





    }
}
