using System;
using System.Collections.Generic;

namespace XTBarber.Models;

public partial class HoaDonMh
{
    public int MaHd { get; set; }

    public int MaKh { get; set; }

    public int MaSp { get; set; }

    public string TenSp { get; set; } = null!;

    public int SoLuong { get; set; }

    public decimal TongTien { get; set; }

    public DateTime NgayMua { get; set; }
}
