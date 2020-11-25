using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AuditPoc.Data.Model
{
    public partial class AuditPocContext : DbContext
    {
        public AuditPocContext()
        {
        }

        public AuditPocContext(DbContextOptions<AuditPocContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Data> Data { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("Server=csnmysql.mysql.database.azure.com;Database=aq4dev;user=csnadmin@csnmysql.com;password=Password#1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Data>(entity =>
            {
                entity.ToTable("data", "auditpoc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Age)
                    .HasColumnName("age")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Empno)
                    .HasColumnName("empno")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });
        }
    }
}
