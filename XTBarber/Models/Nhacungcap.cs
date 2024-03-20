using System;
using System.Collections.Generic;

namespace XTBarber.Models;

public partial class Nhacungcap
{
    public string Mancc { get; set; } = null!;

    public string Tenncc { get; set; } = null!;

    public string Diachi { get; set; } = null!;

    public string? Sdt { get; set; }

    public string Email { get; set; } = null!;

    public bool Vohieuhoa { get; set; }

    public virtual ICollection<Dondathang> Dondathangs { get; set; } = new List<Dondathang>();
}
