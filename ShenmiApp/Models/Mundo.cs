using System;
using System.Collections.Generic;

namespace ShenmiApp.Models;

public partial class Mundo
{
    public int IdMundos { get; set; }

    public string? NombreMundo { get; set; }

    public virtual ICollection<Nivele> Niveles { get; set; } = new List<Nivele>();
}
