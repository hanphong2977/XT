using System;
using System.Collections.Generic;

namespace XTBarber.Models;

public partial class LichLamViec
{
    public int MaLichLv { get; set; }

    public int MaNv { get; set; }

    public TimeOnly BatDauCa { get; set; }

    public TimeOnly KetThucCa { get; set; }
}
