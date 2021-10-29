using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TMProject.Models
{
    public class Profile
    {
        public int IdProfile { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<RolProfile> RolProfiles { get; set; }
    }
}
