using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CRUD_Sysne_NETCoreWebApp.Models
{
    public partial class CRUDSysne_EstacionamientoDataBaseContext : DbContext
    {
        public CRUDSysne_EstacionamientoDataBaseContext()
        {
        }

        public CRUDSysne_EstacionamientoDataBaseContext(DbContextOptions<CRUDSysne_EstacionamientoDataBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autos> Autos { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=ANTONIO-PC;Database=CRUDSysne_EstacionamientoDataBase;Integrated Security=True");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autos>(entity =>
            {
                entity.HasKey(e => e.IdAuto)
                    .HasName("PK__Autos__B191F5E68259F907");

                entity.Property(e => e.IdAuto).HasColumnName("id_auto");

                entity.Property(e => e.MatriculaAuto)
                    .IsRequired()
                    .HasColumnName("matricula_auto")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.NombreConductor)
                    .IsRequired()
                    .HasColumnName("Nombre_Conductor")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAuto)
                    .IsRequired()
                    .HasColumnName("tipo_auto")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
