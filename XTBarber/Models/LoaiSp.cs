using System;
using System.Collections.Generic;

namespace XTBarber.Models;

public partial class LoaiSp
{
    public int MaLoaiSp { get; set; }

    public string LoaiHang { get; set; } = null!;

    public int MaNhaCc { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
