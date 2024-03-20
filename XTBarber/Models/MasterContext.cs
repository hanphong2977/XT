using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace XTBarber.Models;

public partial class MasterContext : DbContext
{
    public MasterContext()
    {
    }

    public MasterContext(DbContextOptions<MasterContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BarberAdmin> BarberAdmins { get; set; }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<DichVu> DichVus { get; set; }

    public virtual DbSet<Dondathang> Dondathangs { get; set; }

    public virtual DbSet<DondathangMathang> DondathangMathangs { get; set; }

    public virtual DbSet<HoaDonMh> HoaDonMhs { get; set; }

    public virtual DbSet<Hoadon> Hoadons { get; set; }

    public virtual DbSet<HoadonMathang> HoadonMathangs { get; set; }

    public virtual DbSet<Khachhang> Khachhangs { get; set; }

    public virtual DbSet<LichHen> LichHens { get; set; }

    public virtual DbSet<LichLamViec> LichLamViecs { get; set; }

    public virtual DbSet<LoaiDv> LoaiDvs { get; set; }

    public virtual DbSet<LoaiSp> LoaiSps { get; set; }

    public virtual DbSet<Loaimathang> Loaimathangs { get; set; }

    public virtual DbSet<Mathang> Mathangs { get; set; }

    public virtual DbSet<Nhacungcap> Nhacungcaps { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-72E84BVK\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BarberAdmin>(entity =>
        {
            entity.HasKey(e => e.MaAd);

            entity.ToTable("barber_admin");

            entity.Property(e => e.MaAd)
                .ValueGeneratedNever()
                .HasColumnName("MaAD");
            entity.Property(e => e.Emailad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hotenad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MatKhauad)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Sdtad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SDTad");
        });

        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.MaLichHen);

            entity.ToTable("Booking");

            entity.Property(e => e.MaLichHen).ValueGeneratedNever();
            entity.Property(e => e.MaDv).HasColumnName("MaDV");

            entity.HasOne(d => d.MaDvNavigation).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.MaDv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Booking_DichVu");
        });

        modelBuilder.Entity<DichVu>(entity =>
        {
            entity.HasKey(e => e.MaDv);

            entity.ToTable("DichVu");

            entity.Property(e => e.MaDv)
                .ValueGeneratedNever()
                .HasColumnName("MaDV");
            entity.Property(e => e.GiaDv)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("GiaDV");
            entity.Property(e => e.MoTaDv)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("MoTaDV");
            entity.Property(e => e.TenDv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TenDV");
            entity.Property(e => e.ThoiGianDv).HasColumnName("ThoiGianDV");

            entity.HasOne(d => d.MaLoaiNavigation).WithMany(p => p.DichVus)
                .HasForeignKey(d => d.MaLoai)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DichVu_Loai_DV1");
        });

        modelBuilder.Entity<Dondathang>(entity =>
        {
            entity.HasKey(e => e.Maddh).HasName("PK__DONDATHA__77CD19D1689B4FCB");

            entity.ToTable("DONDATHANG");

            entity.Property(e => e.Maddh)
                .ValueGeneratedNever()
                .HasColumnName("MADDH");
            entity.Property(e => e.Mancc)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MANCC");
            entity.Property(e => e.Manv)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("MANV");
            entity.Property(e => e.Ngaydat)
                .HasColumnType("datetime")
                .HasColumnName("NGAYDAT");

            entity.HasOne(d => d.ManccNavigation).WithMany(p => p.Dondathangs)
                .HasForeignKey(d => d.Mancc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DONDATHAN__MANCC__4707859D");

            entity.HasOne(d => d.ManvNavigation).WithMany(p => p.Dondathangs)
                .HasForeignKey(d => d.Manv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DONDATHANG__MANV__47FBA9D6");
        });

        modelBuilder.Entity<DondathangMathang>(entity =>
        {
            entity.HasKey(e => new { e.Maddh, e.Mamh }).HasName("PK__DONDATHA__D1CEEF4F4204219A");

            entity.ToTable("DONDATHANG_MATHANG");

            entity.Property(e => e.Maddh).HasColumnName("MADDH");
            entity.Property(e => e.Mamh)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MAMH");
            entity.Property(e => e.Dongia).HasColumnName("DONGIA");
            entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

            entity.HasOne(d => d.MaddhNavigation).WithMany(p => p.DondathangMathangs)
                .HasForeignKey(d => d.Maddh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DONDATHAN__MADDH__48EFCE0F");

            entity.HasOne(d => d.MamhNavigation).WithMany(p => p.DondathangMathangs)
                .HasForeignKey(d => d.Mamh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DONDATHANG__MAMH__49E3F248");
        });

        modelBuilder.Entity<HoaDonMh>(entity =>
        {
            entity.HasKey(e => e.MaHd);

            entity.ToTable("HoaDonMH");

            entity.Property(e => e.MaHd)
                .ValueGeneratedNever()
                .HasColumnName("MaHD");
            entity.Property(e => e.MaKh).HasColumnName("MaKH");
            entity.Property(e => e.MaSp).HasColumnName("MaSP");
            entity.Property(e => e.NgayMua)
                .HasDefaultValueSql("('0000-00-00 00:00:00')")
                .HasColumnType("datetime");
            entity.Property(e => e.TenSp)
                .HasMaxLength(50)
                .HasColumnName("TenSP");
            entity.Property(e => e.TongTien).HasColumnType("money");
        });

        modelBuilder.Entity<Hoadon>(entity =>
        {
            entity.HasKey(e => e.Mahd).HasName("PK__HOADON__603F20CE16764C8D");

            entity.ToTable("HOADON");

            entity.Property(e => e.Mahd)
                .ValueGeneratedNever()
                .HasColumnName("MAHD");
            entity.Property(e => e.Makh).HasColumnName("MAKH");
            entity.Property(e => e.Manv)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("MANV");
            entity.Property(e => e.Ngaylap)
                .HasColumnType("datetime")
                .HasColumnName("NGAYLAP");

            entity.HasOne(d => d.MakhNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Makh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADON__MAKH__4D94879B");

            entity.HasOne(d => d.ManvNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Manv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADON__MANV__4CA06362");
        });

        modelBuilder.Entity<HoadonMathang>(entity =>
        {
            entity.HasKey(e => new { e.Mahd, e.Mamh }).HasName("PK__HOADON_M__C63CD6507B9A2D39");

            entity.ToTable("HOADON_MATHANG");

            entity.Property(e => e.Mahd).HasColumnName("MAHD");
            entity.Property(e => e.Mamh)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MAMH");
            entity.Property(e => e.Soluongmua).HasColumnName("SOLUONGMUA");
            entity.Property(e => e.Thanhtien).HasColumnName("THANHTIEN");

            entity.HasOne(d => d.MahdNavigation).WithMany(p => p.HoadonMathangs)
                .HasForeignKey(d => d.Mahd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADON_MAT__MAHD__5070F446");

            entity.HasOne(d => d.MamhNavigation).WithMany(p => p.HoadonMathangs)
                .HasForeignKey(d => d.Mamh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADON_MAT__MAMH__4DB4832C");
        });

        modelBuilder.Entity<Khachhang>(entity =>
        {
            entity.HasKey(e => e.Makh).HasName("PK__KHACHHAN__603F592C392499E7");

            entity.ToTable("KHACHHANG");

            entity.Property(e => e.Makh)
                .ValueGeneratedNever()
                .HasColumnName("MAKH");
            entity.Property(e => e.Gioitinh)
                .HasMaxLength(5)
                .HasColumnName("GIOITINH");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.Tenkh)
                .HasMaxLength(30)
                .HasColumnName("TENKH");
            entity.Property(e => e.Vohieuhoa).HasColumnName("VOHIEUHOA");
        });

        modelBuilder.Entity<LichHen>(entity =>
        {
            entity.HasKey(e => e.MaLichHen);

            entity.ToTable("LichHen");

            entity.Property(e => e.MaLichHen).ValueGeneratedNever();
            entity.Property(e => e.LyDoHuy)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("text");
            entity.Property(e => e.MaKh).HasColumnName("MaKH");
            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.Thoigianhen)
                .HasDefaultValueSql("('0000-00-00 00:00:00')")
                .HasColumnType("datetime");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.LichHens)
                .HasForeignKey(d => d.MaKh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LichHen_KhachHang");

            entity.HasOne(d => d.MaLichHenNavigation).WithOne(p => p.LichHen)
                .HasForeignKey<LichHen>(d => d.MaLichHen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LichHen_Booking");
        });

        modelBuilder.Entity<LichLamViec>(entity =>
        {
            entity.HasKey(e => e.MaLichLv);

            entity.ToTable("LichLamViec");

            entity.Property(e => e.MaLichLv)
                .ValueGeneratedNever()
                .HasColumnName("MaLichLV");
            entity.Property(e => e.MaNv).HasColumnName("MaNV");
        });

        modelBuilder.Entity<LoaiDv>(entity =>
        {
            entity.HasKey(e => e.MaLoai);

            entity.ToTable("Loai_DV");

            entity.Property(e => e.MaLoai).ValueGeneratedNever();
            entity.Property(e => e.TenLoai)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LoaiSp>(entity =>
        {
            entity.HasKey(e => e.MaLoaiSp);

            entity.ToTable("LoaiSP");

            entity.Property(e => e.MaLoaiSp)
                .ValueGeneratedNever()
                .HasColumnName("MaLoaiSP");
            entity.Property(e => e.LoaiHang).HasMaxLength(50);
            entity.Property(e => e.MaNhaCc).HasColumnName("MaNhaCC");
        });

        modelBuilder.Entity<Loaimathang>(entity =>
        {
            entity.HasKey(e => e.Maloai).HasName("PK__LOAIMATH__2F633F235BF3D95B");

            entity.ToTable("LOAIMATHANG");

            entity.Property(e => e.Maloai)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MALOAI");
            entity.Property(e => e.Tenloai)
                .HasMaxLength(50)
                .HasColumnName("TENLOAI");
            entity.Property(e => e.Vohieuhoa).HasColumnName("VOHIEUHOA");
        });

        modelBuilder.Entity<Mathang>(entity =>
        {
            entity.HasKey(e => e.Mamh).HasName("PK__MATHANG__603F69EB6D3C5386");

            entity.ToTable("MATHANG");

            entity.Property(e => e.Mamh)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MAMH");
            entity.Property(e => e.Dvt)
                .HasMaxLength(10)
                .HasColumnName("DVT");
            entity.Property(e => e.Giaban).HasColumnName("GIABAN");
            entity.Property(e => e.Maloai)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MALOAI");
            entity.Property(e => e.Mota)
                .HasMaxLength(100)
                .HasColumnName("MOTA");
            entity.Property(e => e.Tenmh)
                .HasMaxLength(50)
                .HasColumnName("TENMH");
            entity.Property(e => e.Vohieuhoa).HasColumnName("VOHIEUHOA");

            entity.HasOne(d => d.MaloaiNavigation).WithMany(p => p.Mathangs)
                .HasForeignKey(d => d.Maloai)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MATHANG__MALOAI__4EA8A765");
        });

        modelBuilder.Entity<Nhacungcap>(entity =>
        {
            entity.HasKey(e => e.Mancc).HasName("PK__NHACUNGC__7ABEA5826F725A64");

            entity.ToTable("NHACUNGCAP");

            entity.Property(e => e.Mancc)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MANCC");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .HasColumnName("DIACHI");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.Tenncc)
                .HasMaxLength(50)
                .HasColumnName("TENNCC");
            entity.Property(e => e.Vohieuhoa).HasColumnName("VOHIEUHOA");
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.Manv).HasName("PK__NHANVIEN__603F51144FA86F87");

            entity.ToTable("NHANVIEN");

            entity.Property(e => e.Manv)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("MANV");
            entity.Property(e => e.CmndCccd)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CMND_CCCD");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .HasColumnName("DIACHI");
            entity.Property(e => e.Gioitinh)
                .HasMaxLength(5)
                .HasColumnName("GIOITINH");
            entity.Property(e => e.Laquanly).HasColumnName("LAQUANLY");
            entity.Property(e => e.Matkhau)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("MATKHAU");
            entity.Property(e => e.Ngaysinh)
                .HasColumnType("datetime")
                .HasColumnName("NGAYSINH");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.Tendangnhap)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TENDANGNHAP");
            entity.Property(e => e.Tennv)
                .HasMaxLength(30)
                .HasColumnName("TENNV");
            entity.Property(e => e.Vohieuhoa).HasColumnName("VOHIEUHOA");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSp);

            entity.ToTable("SanPham");

            entity.Property(e => e.MaSp)
                .ValueGeneratedNever()
                .HasColumnName("MaSP");
            entity.Property(e => e.AnhSp)
                .HasColumnType("image")
                .HasColumnName("AnhSP");
            entity.Property(e => e.GiaSp)
                .HasColumnType("decimal(8, 0)")
                .HasColumnName("GiaSP");
            entity.Property(e => e.LoaiHang).HasMaxLength(50);
            entity.Property(e => e.MaLoaiSp).HasColumnName("MaLoaiSP");
            entity.Property(e => e.MaNhaCc).HasColumnName("MaNhaCC");
            entity.Property(e => e.TenSp)
                .HasMaxLength(50)
                .HasColumnName("TenSP");

            entity.HasOne(d => d.MaLoaiSpNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaLoaiSp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SanPham_LoaiSP");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
