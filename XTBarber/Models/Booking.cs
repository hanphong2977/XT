using System;
using System.Collections.Generic;

namespace XTBarber.Models;

public partial class Booking
{
    public int MaLichHen { get; set; }

    public int MaDv { get; set; }

    public virtual LichHen? LichHen { get; set; }

    public virtual DichVu MaDvNavigation { get; set; } = null!;
}
