using System;
using System.Collections.Generic;

namespace XTBarber.Models;

public partial class SanPham
{
    public int MaSp { get; set; }

    public string TenSp { get; set; } = null!;

    public decimal GiaSp { get; set; }

    public string LoaiHang { get; set; } = null!;

    public int SoLuong { get; set; }

    public int MaNhaCc { get; set; }

    public int MaLoaiSp { get; set; }

    public byte[] AnhSp { get; set; } = null!;

    public virtual LoaiSp MaLoaiSpNavigation { get; set; } = null!;
}
