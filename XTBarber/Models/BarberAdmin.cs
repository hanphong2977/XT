using System;
using System.Collections.Generic;

namespace XTBarber.Models;

public partial class BarberAdmin
{
    public int MaAd { get; set; }

    public string Sdtad { get; set; } = null!;

    public string Emailad { get; set; } = null!;

    public string Hotenad { get; set; } = null!;

    public string MatKhauad { get; set; } = null!;
}
