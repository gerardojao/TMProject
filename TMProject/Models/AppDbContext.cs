using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMProject.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> user { get; set; }
        public DbSet<Profile> profile { get; set; }
        public DbSet<Rol> rol { get; set; }
        public DbSet<RolProfile> rol_profile { get; set; }
    }

}
