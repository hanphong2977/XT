using System;
using System.Collections.Generic;

namespace XTBarber.Models;

public partial class Nhanvien
{
    public string Manv { get; set; } = null!;

    public string Tennv { get; set; } = null!;

    public string Diachi { get; set; } = null!;

    public string? Sdt { get; set; }

    public string Gioitinh { get; set; } = null!;

    public DateTime Ngaysinh { get; set; }

    public string CmndCccd { get; set; } = null!;

    public string Tendangnhap { get; set; } = null!;

    public string Matkhau { get; set; } = null!;

    public bool Vohieuhoa { get; set; }

    public bool Laquanly { get; set; }

    public virtual ICollection<Dondathang> Dondathangs { get; set; } = new List<Dondathang>();

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
