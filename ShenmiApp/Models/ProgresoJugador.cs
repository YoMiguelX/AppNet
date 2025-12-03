using System;
using System.Collections.Generic;

namespace ShenmiApp.Models;

public partial class ProgresoJugador
{
    public int IdProgresoJugador { get; set; }

    public int PuntajeNivel { get; set; }

    public int? NivelCompletado { get; set; }

    public int TiempoJugado { get; set; }

    public DateTime FechaCompletado { get; set; }

    public int NivelesIdNiveles { get; set; }

    public int Experiencia { get; set; }

    public int Nivel { get; set; }

    public virtual ICollection<Jugador> Jugadors { get; set; } = new List<Jugador>();

    public virtual Nivele NivelesIdNivelesNavigation { get; set; } = null!;
}
