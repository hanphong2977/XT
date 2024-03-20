using System;
using System.Collections.Generic;

namespace XTBarber.Models;

public partial class LichHen
{
    public int MaLichHen { get; set; }

    public int MaKh { get; set; }

    public int MaNv { get; set; }

    public DateTime Thoigianhen { get; set; }

    public byte HuyLich { get; set; }

    public string? LyDoHuy { get; set; }

    public virtual Khachhang MaKhNavigation { get; set; } = null!;

    public virtual Booking MaLichHenNavigation { get; set; } = null!;
}
