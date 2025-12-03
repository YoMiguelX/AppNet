using System;
using System.Collections.Generic;

namespace ShenmiApp.Models;

public partial class Mundo1
{
    public int IdMundo { get; set; }

    public string? Descripcion { get; set; }

    public string Nombre { get; set; } = null!;

    public string? NombreMundo { get; set; }
}
