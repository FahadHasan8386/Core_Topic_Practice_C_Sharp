using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=Assignment;User ID=developer; Password=123456;TrustServerCertificate=True"
                );
        }
    }
}
