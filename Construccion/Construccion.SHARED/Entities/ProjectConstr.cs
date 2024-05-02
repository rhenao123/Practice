using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace construccion.Shared.Entities
{
    public class ProjectConstr
    {
       
        public int id { get; set; }

        

        [Display(Name = "Nombre")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; }

        [Display(Name = "Descripcion")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Description { get; set; }


        [Display(Name = "Ubicacion")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Locate { get; set; }



        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}",
        ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public DateTime FechaStart { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}",
        ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public DateTime FechaEnd { get; set; }

        [JsonIgnore]
        public ICollection<AssignmentsTeams> AssignmentsTeamss { get; set; }



    }
}
