using Login2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login2.Data
{
    public class LogınPageContext : DbContext
    {
        public LogınPageContext(DbContextOptions<LogınPageContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=LogınPageContext; Trusted_connection=true");
        }

        public DbSet<Person> Person { get; set; }
    }
}
