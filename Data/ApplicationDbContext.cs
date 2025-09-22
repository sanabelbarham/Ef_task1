using EF_task1.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_task1.Data
{
    class ApplicationDbContext:DbContext
    {

        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=EF_TASK;Trusted_connection=True;TrustServerCertificate=True");
        }

    








    }
}
