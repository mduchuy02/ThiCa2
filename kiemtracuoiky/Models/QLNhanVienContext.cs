using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace kiemtracuoiky.Models
{
    public partial class QLNhanVienContext : DbContext
    {
        public QLNhanVienContext()
        {
        }

        public QLNhanVienContext(DbContextOptions<QLNhanVienContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<PhongBan> PhongBan { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=QLNhanVien;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.Manv);

                entity.Property(e => e.Manv)
                    .HasColumnName("manv")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Gioitinh).HasColumnName("gioitinh");

                entity.Property(e => e.Hoten)
                    .HasColumnName("hoten")
                    .HasMaxLength(50);

                entity.Property(e => e.Hsluong).HasColumnName("hsluong");

                entity.Property(e => e.Luongcb).HasColumnName("luongcb");

                entity.Property(e => e.Mapb)
                    .HasColumnName("mapb")
                    .HasMaxLength(10);

                entity.Property(e => e.Ngaysinh)
                    .HasColumnName("ngaysinh")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.MapbNavigation)
                    .WithMany(p => p.NhanVien)
                    .HasForeignKey(d => d.Mapb)
                    .HasConstraintName("FK_NhanVien_PhongBan");
            });

            modelBuilder.Entity<PhongBan>(entity =>
            {
                entity.HasKey(e => e.Mapb);

                entity.Property(e => e.Mapb)
                    .HasColumnName("mapb")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Tenpb)
                    .HasColumnName("tenpb")
                    .HasMaxLength(50);
            });
        }
    }
}
