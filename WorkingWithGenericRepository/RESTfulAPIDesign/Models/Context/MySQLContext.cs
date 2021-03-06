﻿// To use DbContext
using Microsoft.EntityFrameworkCore;

namespace RESTfulAPIDesign.Models.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {}

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<Person> Persons { get; set; }
        public DbSet<Book> Book { get; set;  }

    }
}
