using System;
using System.Collections.Generic;

namespace XTBarber.Models;

public partial class DichVu
{
    public int MaDv { get; set; }

    public string TenDv { get; set; } = null!;

    public string MoTaDv { get; set; } = null!;

    public decimal GiaDv { get; set; }

    public int ThoiGianDv { get; set; }

    public int MaLoai { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual LoaiDv MaLoaiNavigation { get; set; } = null!;
}
