using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace construccion.Shared.Entities
{
    public class Materiales
    {

       /* Atributos: Nombre, Cantidad Requerida, 
          Proveedor, Fecha de Entrega Estimada.
          Relaciones: Puede estar asociado a muchas Tareas.*/

      public int id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nombre { get; set; }
        [Display(Name = "Cantidad")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int Cantidad { get; set; }
        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        
        public string Proveedor { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        
        public DateTime FechaE { get; set; }


        [JsonIgnore]
        public ProjectConstr ProjectConstrs { get; set; }

        public int ProjectConstrId { get; set; }

        [JsonIgnore]
        public ICollection<AssigmentMats> AssigmentMatss { get; set; }

    }
}
