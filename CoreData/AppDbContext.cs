using Core.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
            { }
        public DbSet<SinhVien> SinhViens { get; set; }

        public DbSet<Lop> Lops { get; set; }
    }
}
