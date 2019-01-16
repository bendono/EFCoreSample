using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Foo
{
    public class Foo
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }

    public class Bar
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }

    public class FooContext : DbContext
    {
        public DbSet<Foo> Foos { get; set; }
        public DbSet<Bar> Bars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=foo.db");
        }
    }
}
