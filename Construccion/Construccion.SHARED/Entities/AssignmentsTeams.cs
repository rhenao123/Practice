using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace construccion.Shared.Entities
{
    public class AssignmentsTeams

    {

        public int Id { get; set; } 
        public int IdConstr { get; set; }

        public int idTeams { get; set; }

        [JsonIgnore]
        public ProjectConstr ProjectConstrs { get; set; }

     
        [JsonIgnore]
        public EquiCons EquiConss { get; set; } 




    }
}
