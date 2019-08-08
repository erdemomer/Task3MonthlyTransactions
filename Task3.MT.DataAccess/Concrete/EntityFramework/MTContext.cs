using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Task3.MT.Entities.Concrete;
using Task3.MT.Entities.Mapping.EntityFramework;

namespace Task3.MT.DataAccess.Concrete.EntityFramework
{
    public class MTContext : DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-JR1TBFU\SQLEXPRESS;Database=MonthlyTransactions; Trusted_Connection=True");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)

        {

            base.OnModelCreating(builder);

            new TransactionMapping(builder.Entity<Transaction>());

            new CategoryMapping(builder.Entity<Category>());

        }
    }
}
