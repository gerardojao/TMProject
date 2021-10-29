using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TMProject.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string email { get; set; }

        public string telefono { get; set; }

        public string cargo { get; set; }

        public int rolId { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
