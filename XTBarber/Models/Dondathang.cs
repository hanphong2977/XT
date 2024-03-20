using System;
using System.Collections.Generic;

namespace XTBarber.Models;

public partial class Dondathang
{
    public int Maddh { get; set; }

    public string Mancc { get; set; } = null!;

    public DateTime Ngaydat { get; set; }

    public string Manv { get; set; } = null!;

    public virtual ICollection<DondathangMathang> DondathangMathangs { get; set; } = new List<DondathangMathang>();

    public virtual Nhacungcap ManccNavigation { get; set; } = null!;

    public virtual Nhanvien ManvNavigation { get; set; } = null!;
}
