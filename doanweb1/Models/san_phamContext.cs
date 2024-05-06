using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace doanweb1.Models
{
    public partial class san_phamContext : DbContext
    {
        public san_phamContext()
        {
        }

        public san_phamContext(DbContextOptions<san_phamContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; } = null!;
        public virtual DbSet<HinhAnh> HinhAnhs { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;
        public virtual DbSet<SanPhamSize> SanPhamSizes { get; set; } = null!;
        public virtual DbSet<Size> Sizes { get; set; } = null!;
        public virtual DbSet<SlideBar> SlideBars { get; set; } = null!;
        public virtual DbSet<Table2> Table2s { get; set; } = null!;
        public virtual DbSet<TrangThaiHoaDon> TrangThaiHoaDons { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=ADMIN;Initial Catalog=san_pham;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietHoaDon>(entity =>
            {
                entity.ToTable("chi_tiet_hoa_don");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DonGia).HasColumnName("don_gia");

                entity.Property(e => e.IdHoaDon).HasColumnName("id_hoa_don");

                entity.Property(e => e.IdSanPhamSize).HasColumnName("id_san_pham,size");

                entity.Property(e => e.SoLuongMua)
                    .HasMaxLength(50)
                    .HasColumnName("so_luong_mua");

                entity.HasOne(d => d.IdHoaDonNavigation)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.IdHoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_chi_tiet_hoa_don_hoa_don");

                entity.HasOne(d => d.IdSanPhamSizeNavigation)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.IdSanPhamSize)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_chi_tiet_hoa_don_san_pham,size");
            });

            modelBuilder.Entity<HinhAnh>(entity =>
            {
                entity.ToTable("HinhAnh");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdSanPham).HasColumnName("id_san_pham");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.HasOne(d => d.IdSanPhamNavigation)
                    .WithMany(p => p.HinhAnhs)
                    .HasForeignKey(d => d.IdSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HinhAnh_san_pham1");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.ToTable("hoa_don");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DiaChiGiaoHang)
                    .HasMaxLength(50)
                    .HasColumnName("dia_chi_giao_hang");

                entity.Property(e => e.IdKhachHang).HasColumnName("id_khach_hang");

                entity.Property(e => e.IdTrangThaiHoaDon).HasColumnName("id_trang_thai_hoa_don");

                entity.Property(e => e.NgayHoanThanh)
                    .HasColumnType("datetime")
                    .HasColumnName("ngay_hoan_thanh");

                entity.Property(e => e.NgayMua)
                    .HasColumnType("datetime")
                    .HasColumnName("ngay_mua");

                entity.Property(e => e.TongGia).HasColumnName("tong_gia");

                entity.HasOne(d => d.IdKhachHangNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdKhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_hoa_don_khach_hang");

                entity.HasOne(d => d.IdTrangThaiHoaDonNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdTrangThaiHoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_hoa_don_trang_thai_hoa_don");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.ToTable("khach_hang");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(50)
                    .HasColumnName("dia_chi");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(50)
                    .HasColumnName("mat_khau");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(20)
                    .HasColumnName("sdt");

                entity.Property(e => e.TenDangNhap)
                    .HasMaxLength(50)
                    .HasColumnName("ten_dang_nhap");
            });

            modelBuilder.Entity<LoaiSanPham>(entity =>
            {
                entity.ToTable("loai_san_pham");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoaiSanPham1)
                    .HasMaxLength(50)
                    .HasColumnName("loai_san_pham");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.ToTable("san_pham");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Chitietsanpham).HasColumnName("chitietsanpham");

                entity.Property(e => e.GiaSp)
                    .HasMaxLength(50)
                    .HasColumnName("gia_sp");

                entity.Property(e => e.LoaiSp).HasColumnName("loai_sp");

                entity.Property(e => e.TenSp)
                    .HasMaxLength(50)
                    .HasColumnName("ten_sp");

                entity.HasOne(d => d.LoaiSpNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.LoaiSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_san_pham_loai_san_pham");
            });

            modelBuilder.Entity<SanPhamSize>(entity =>
            {
                entity.ToTable("san_pham,size");

                entity.HasIndex(e => new { e.Id, e.IdSanPham, e.IdSize }, "IX_san_pham,size")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdSanPham).HasColumnName("id_san_pham");

                entity.Property(e => e.IdSize).HasColumnName("id_size");

                entity.Property(e => e.SoLuongConLai)
                    .HasMaxLength(10)
                    .HasColumnName("so_luong_con_lai")
                    .IsFixedLength();

                entity.HasOne(d => d.IdSanPhamNavigation)
                    .WithMany(p => p.SanPhamSizes)
                    .HasForeignKey(d => d.IdSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_san_pham,size_san_pham");

                entity.HasOne(d => d.IdSizeNavigation)
                    .WithMany(p => p.SanPhamSizes)
                    .HasForeignKey(d => d.IdSize)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_san_pham,size_size");
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.ToTable("size");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Size1)
                    .HasMaxLength(10)
                    .HasColumnName("size")
                    .IsFixedLength();
            });

            modelBuilder.Entity<SlideBar>(entity =>
            {
                entity.ToTable("slide_bar");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<Table2>(entity =>
            {
                entity.ToTable("Table_2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoaiSanPham)
                    .HasMaxLength(50)
                    .HasColumnName("loai_san_pham");
            });

            modelBuilder.Entity<TrangThaiHoaDon>(entity =>
            {
                entity.ToTable("trang_thai_hoa_don");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.TrangThai)
                    .HasMaxLength(50)
                    .HasColumnName("trang_thai");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
