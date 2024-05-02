using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace construccion.Shared.Entities
{
    public class Presupuesto
    {
        //Atributos: Desglose por Categorías (mano de obra, materiales, maquinaria, etc.).
        //Relaciones: Puede estar asociado a un Proyecto de Construcción. 
        public int id { get; set; }

        //Se crean atributos que guarden el presupuesto de cada categoria
        [Display(Name = "Mano de obra")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
     
        public double ManoObra { get; set; }


        [Display(Name = "Materiales")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public double Material { get; set; }

        [Display(Name = "Maquinaria")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public double Maquinaria { get; set; }


        [Display(Name = "Otros")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public double Otros { get; set; }


        [JsonIgnore]
        public ProjectConstr ProjectConstrs { get; set; }

        public int ProjectConstrId { get; set; }

    }

}
