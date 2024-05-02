using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace construccion.Shared.Entities
{
    public class EquiCons
    {
        //Atributos: Nombre, Especialidades, Lista de Miembros
        //Relaciones: Puede estar asignado a varios Proyectos de Construcción.
        public int id { get; set; }
        
        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nombre { get; set; }

        [Display(Name = "Especialidades")]
        [MaxLength(400, ErrorMessage = "No se permiten más de 400 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Especialidades { get; set; }

        [Display(Name = "Lista de miembros")]
        [MaxLength(400, ErrorMessage = "No se permiten más de 400 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Lista_Miembros { get; set; }

        [JsonIgnore]
        public ICollection<AssignmentsTeams> AssignmentsTeamss { get; set; }

    }
}
