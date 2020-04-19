using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Consulting_Portal
{
    #region Factory Context Database Class
    /// <summary>
    /// Database Class
    /// </summary>
    class FactoryContext : DbContext
    {
        //Creation of Entities Table
        public DbSet<Entity> Entities { get; set; }
        
        //Creation of Transactions Table
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connection String to Datebase
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CosultingPortal;Integrated Security=True;Connect Timeout=30");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entity>(entity => 
            {
                entity.ToTable("Entities");
                entity.HasKey( e => e.EntityIdentifier);
                
                entity.Property(e => e.EntityIdentifier)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.AccountBalance)
                    .IsRequired();
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("Transactions");
                entity.HasKey(t => t.Id);

                entity.Property(t => t.Id)
                      .ValueGeneratedOnAdd();

                entity.Property(t => t.Amount)
                      .IsRequired();
            });
        }

    }
    #endregion
}
