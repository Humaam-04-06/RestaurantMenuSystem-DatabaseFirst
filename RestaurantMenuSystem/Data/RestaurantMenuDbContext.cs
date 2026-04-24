using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RestaurantMenuSystem.Models;

namespace RestaurantMenuSystem.Data;

public partial class RestaurantMenuDbContext : DbContext
{
    public RestaurantMenuDbContext()
    {
    }

    public RestaurantMenuDbContext(DbContextOptions<RestaurantMenuDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MenuItem> MenuItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-JP1L9J2\\SQLEXPRESS;Database=RestaurantMenuDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MenuItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MenuItem__3214EC0756BA0EB5");

            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
