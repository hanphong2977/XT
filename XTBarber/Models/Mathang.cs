using System;
using System.Collections.Generic;

namespace XTBarber.Models;

public partial class Mathang
{
    public string Mamh { get; set; } = null!;

    public string Tenmh { get; set; } = null!;

    public long Giaban { get; set; }

    public string Dvt { get; set; } = null!;

    public string Maloai { get; set; } = null!;

    public string Mota { get; set; } = null!;

    public bool Vohieuhoa { get; set; }

    public virtual ICollection<DondathangMathang> DondathangMathangs { get; set; } = new List<DondathangMathang>();

    public virtual ICollection<HoadonMathang> HoadonMathangs { get; set; } = new List<HoadonMathang>();

    public virtual Loaimathang MaloaiNavigation { get; set; } = null!;
}
