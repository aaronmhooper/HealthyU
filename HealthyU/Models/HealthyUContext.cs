using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HealthyU.Models
{
    public class HealthyUContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public DbSet<Activities> Activities { get; set; }

        
    }
}