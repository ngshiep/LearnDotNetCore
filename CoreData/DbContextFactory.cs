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
            optionsBuilder.UseSqlServer( "Server=DESKTOP-PSV75U0\\SQLEXPRESS;Database=AppDatabase;Trusted_Connection=True;" );
            return new AppDbContext(optionsBuilder.Options);
        }

    }
}
