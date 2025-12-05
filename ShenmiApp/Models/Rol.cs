using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShenmiApp.Models;

public partial class Rol
{
    [Key]
    public int IdRol { get; set; }

    public string NombreRol { get; set; } = null!;
}
