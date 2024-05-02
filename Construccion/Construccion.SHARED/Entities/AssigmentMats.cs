using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace construccion.Shared.Entities
{
    public class AssigmentMats

    {
        public int Id { get; set; }
        public int IdTasks { get; set; }

        public int IdMats { get; set; } 

        [JsonIgnore]
        public Tarea Tareas { get; set; }

        [JsonIgnore]
        public Materiales Materialess { get; set; }

    }
}
