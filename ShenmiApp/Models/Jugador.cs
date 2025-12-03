using System;
using System.Collections.Generic;

namespace ShenmiApp.Models;

public partial class Jugador
{
    public int IdJugador { get; set; }

    public string? Nombre { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public DateTime? UltimaConexion { get; set; }

    public int ProgresoJugadorIdProgresoJugador { get; set; }

    public int UsuarioIdUsuario { get; set; }

    public string? Estado { get; set; }

    public string? Progreso { get; set; }

    public string? Equipo { get; set; }

    public int Numero { get; set; }

    public string? Posicion { get; set; }

    public virtual ProgresoJugador ProgresoJugadorIdProgresoJugadorNavigation { get; set; } = null!;
}
