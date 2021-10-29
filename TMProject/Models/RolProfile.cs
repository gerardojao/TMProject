using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TMProject.Models
{
    public class RolProfile
    {
        public int RpId { get; set; }
        public int RolId { get; set; }
        public int ProfileId { get; set; }

        public virtual Profile Profile { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
