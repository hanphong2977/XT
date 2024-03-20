using System;
using System.Collections.Generic;

namespace XTBarber.Models;

public partial class HoadonMathang
{
    public int Mahd { get; set; }

    public string Mamh { get; set; } = null!;

    public int Soluongmua { get; set; }

    public double? Thanhtien { get; set; }

    public virtual Hoadon MahdNavigation { get; set; } = null!;

    public virtual Mathang MamhNavigation { get; set; } = null!;
}
