using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dsw2025Ej15.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dsw2025Ej15.Data;

public class Dsw2025Ej15Context : DbContext
{
    public DbSet<Category> Categories { get; set; }

    public Dsw2025Ej15Context(DbContextOptions<Dsw2025Ej15Context> option) : base(option)
    {
    }
   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Category>()
            .Property(p => p.Name)
            .HasMaxLength(50);

        modelBuilder.Entity<Product>(eb =>
        {
            eb.ToTable("Products");
            eb.Property(p => p.Sku)
                .HasMaxLength(20)
                .IsRequired();
            eb.Property(p => p.Name)
                .HasMaxLength(100);
            eb.Property(p => p.CurrentUnitPrice)
                .HasPrecision(18, 2)
                .IsRequired();

        });
    }
}
