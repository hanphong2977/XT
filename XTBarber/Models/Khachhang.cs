using System;
using System.Collections.Generic;

namespace XTBarber.Models;

public partial class Khachhang
{
    public int Makh { get; set; }

    public string Tenkh { get; set; } = null!;

    public string Gioitinh { get; set; } = null!;

    public string Sdt { get; set; } = null!;

    public bool Vohieuhoa { get; set; }

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    public virtual ICollection<LichHen> LichHens { get; set; } = new List<LichHen>();
}
