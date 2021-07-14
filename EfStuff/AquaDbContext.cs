using AquaHobby.EfStuff.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaHobby.EfStuff
{
    public class AquaDbContext : DbContext
    {
        public AquaDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Fish> Fish{ get; set; }

    }
}
