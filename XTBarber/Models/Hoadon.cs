using System;
using System.Collections.Generic;

namespace XTBarber.Models;

public partial class Hoadon
{
    public int Mahd { get; set; }

    public DateTime Ngaylap { get; set; }

    public string Manv { get; set; } = null!;

    public int Makh { get; set; }

    public virtual ICollection<HoadonMathang> HoadonMathangs { get; set; } = new List<HoadonMathang>();

    public virtual Khachhang MakhNavigation { get; set; } = null!;

    public virtual Nhanvien ManvNavigation { get; set; } = null!;
}
