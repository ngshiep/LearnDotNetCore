using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data
{
    public class DbContextFactory :IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=C_DES028\\SQLEXPRESS;Database=myDb;Trusted_Connection=True;");
            return new AppDbContext(optionsBuilder.Options);
        }

    }
}
