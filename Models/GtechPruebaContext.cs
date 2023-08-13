using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace gtech_adminltev1.Models;

public partial class GtechPruebaContext : DbContext
{
    public GtechPruebaContext()
    {
    }

    public GtechPruebaContext(DbContextOptions<GtechPruebaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.ToTable("categorias");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("INTEGER_AUTOINCREMENT")
                .HasColumnName("id");
            entity.Property(e => e.NombreCat)
                .HasColumnType("VARCHAR(50)")
                .HasColumnName("nombre_cat");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.ToTable("clientes");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("INTEGER AUTO_INCREMENT")
                .HasColumnName("id");
            entity.Property(e => e.CorreoE)
                .HasColumnType("VARCHAR(30)")
                .HasColumnName("correo_e");
            entity.Property(e => e.Domicilio)
                .HasColumnType("VARCHAR(30)")
                .HasColumnName("domicilio");
            entity.Property(e => e.FechaIng)
                .HasColumnType("DATE")
                .HasColumnName("fecha_ing");
            entity.Property(e => e.Nombre)
                .HasColumnType("VARCHAR(30)")
                .HasColumnName("nombre");
            entity.Property(e => e.Rut)
                .HasColumnType("VARCHAR(30)")
                .HasColumnName("rut");
            entity.Property(e => e.Telefono)
                .HasColumnType("VARCHAR(30)")
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.ToTable("productos");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("INTEGER AUTO_INCREMENT")
                .HasColumnName("id");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Categoria).HasColumnName("categoria");
            entity.Property(e => e.Costo)
                .HasColumnType("DOUBLE")
                .HasColumnName("costo");
            entity.Property(e => e.Descripcion)
                .HasColumnType("VARCHAR(200)")
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasColumnType("VARCHAR(30)")
                .HasColumnName("estado");
            entity.Property(e => e.FechaCompra)
                .HasColumnType("DATE")
                .HasColumnName("fecha_compra");
            entity.Property(e => e.FechaRecepcion)
                .HasColumnType("DATE")
                .HasColumnName("fecha_recepcion");
            entity.Property(e => e.NombreP)
                .HasColumnType("VARCHAR(30)")
                .HasColumnName("nombre_p");
            entity.Property(e => e.Precio)
                .HasColumnType("DOUBLE")
                .HasColumnName("precio");

            entity.HasOne(d => d.CategoriaNavigation).WithMany(p => p.Productos).HasForeignKey(d => d.Categoria);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
