using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShenmiApp.Models;

public partial class RolHasAccione
{
    [Key]
    public int IdRolAccion { get; set; }

    public int RolIdRol { get; set; }

    public int AccionesIdAccion { get; set; }
}
