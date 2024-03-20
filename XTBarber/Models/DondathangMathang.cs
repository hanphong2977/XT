using System;
using System.Collections.Generic;

namespace XTBarber.Models;

public partial class DondathangMathang
{
    public int Maddh { get; set; }

    public string Mamh { get; set; } = null!;

    public int Soluong { get; set; }

    public double Dongia { get; set; }

    public virtual Dondathang MaddhNavigation { get; set; } = null!;

    public virtual Mathang MamhNavigation { get; set; } = null!;
}
