using System;
using System.Collections.Generic;

namespace ShenmiApp.Models;

public partial class RolHasAccione
{
    public int IdRolAccion { get; set; }

    public int RolIdRol { get; set; }

    public int AccionesIdAccion { get; set; }
}
