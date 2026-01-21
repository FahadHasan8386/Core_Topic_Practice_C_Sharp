using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework_Migration_Example1
{
    public class TranningDbContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
                 optionsBuilder.UseSqlServer("Server=Fahad\\SQLEXPRESS;Database=CSharp;User Id=csharpb22;password=123456;Trust Server Certificate=True;");
        }
     }
}
