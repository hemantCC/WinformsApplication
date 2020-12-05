using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Assignment.Entity.Entities.DataEntities
{
    public partial class DbAssignmentContext : DbContext
    {
        public DbAssignmentContext()
        {
        }

        public DbAssignmentContext(DbContextOptions<DbAssignmentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblFuelType> TblFuelTypes { get; set; }
        public virtual DbSet<TblRole> TblRoles { get; set; }
        public virtual DbSet<TblTransmissionType> TblTransmissionTypes { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<TblVehicle> TblVehicles { get; set; }
        public virtual DbSet<TblVehicleType> TblVehicleTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DSK-992\\SQL2019;Database=DbAssignment;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblFuelType>(entity =>
            {
                entity.ToTable("TblFuelType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FuelTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("TblRole");

                entity.Property(e => e.RoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblTransmissionType>(entity =>
            {
                entity.ToTable("TblTransmissionType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.TransmissionName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.ToTable("TblUser");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_TblUser_TblRole");
            });

            modelBuilder.Entity<TblVehicle>(entity =>
            {
                entity.ToTable("TblVehicle");

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.Color).HasMaxLength(20);

                entity.Property(e => e.EngineSize).HasColumnType("decimal(2, 1)");

                entity.Property(e => e.Make).HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.Plate).HasMaxLength(15);

                entity.Property(e => e.TransmissionTypeId).HasColumnName("TransmissionTypeID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.Vin)
                    .HasMaxLength(20)
                    .HasColumnName("VIN");

                entity.Property(e => e.Year).HasMaxLength(4);

                entity.HasOne(d => d.FuelType)
                    .WithMany(p => p.TblVehicles)
                    .HasForeignKey(d => d.FuelTypeId)
                    .HasConstraintName("FK_TblVehicle_TblFuelType");

                entity.HasOne(d => d.TransmissionType)
                    .WithMany(p => p.TblVehicles)
                    .HasForeignKey(d => d.TransmissionTypeId)
                    .HasConstraintName("FK_TblVehicle_TblTransmissionType");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.TblVehicles)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_TblVehicle_TblVehicleType");
            });

            modelBuilder.Entity<TblVehicleType>(entity =>
            {
                entity.ToTable("TblVehicleType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.VehicleTypeName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
