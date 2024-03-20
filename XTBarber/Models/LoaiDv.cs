using System;
using System.Collections.Generic;

namespace XTBarber.Models;

public partial class LoaiDv
{
    public int MaLoai { get; set; }

    public string TenLoai { get; set; } = null!;

    public virtual ICollection<DichVu> DichVus { get; set; } = new List<DichVu>();
}
