using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Add_Edit_Delete
{
    class MyDetailsDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-SNRF64I;Database=TestDog;Trusted_Connection=True;");
        }

        public DbSet<MyDetails> MyDetails { get; set; }
    }
}
