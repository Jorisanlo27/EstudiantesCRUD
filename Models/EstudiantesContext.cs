using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EstudiantesCRUD.Models;

public partial class EstudiantesContext : DbContext
{
    public EstudiantesContext()
    {
    }

    public EstudiantesContext(DbContextOptions<EstudiantesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Estudiante> Estudiantes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=DELLG5JORISANLO\\APDB;Database=ESTUDIANTES;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Estudiante>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ESTUDIAN__3214EC27DD2988AD");

            entity.ToTable("ESTUDIANTES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APELLIDO");
            entity.Property(e => e.Asignatura)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ASIGNATURA");
            entity.Property(e => e.Carrera)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CARRERA");
            entity.Property(e => e.Cuatrimestre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CUATRIMESTRE");
            entity.Property(e => e.Matricula)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MATRICULA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Nota)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("NOTA");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
