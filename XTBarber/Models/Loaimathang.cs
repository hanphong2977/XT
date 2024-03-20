using System;
using System.Collections.Generic;

namespace XTBarber.Models;

public partial class Loaimathang
{
    public string Maloai { get; set; } = null!;

    public string Tenloai { get; set; } = null!;

    public bool Vohieuhoa { get; set; }

    public virtual ICollection<Mathang> Mathangs { get; set; } = new List<Mathang>();
}
