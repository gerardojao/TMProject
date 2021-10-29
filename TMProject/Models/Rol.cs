using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TMProject.Models
{
    public class Rol
    {
        
        public Rol()
        {
            Users = new HashSet<User>();
        }

        public int IdRol { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<RolProfile> RolProfiles { get; set; }
    }
}
