using System;
using System.Collections.Generic;

namespace ShenmiApp.Models;

public partial class Nivele
{
    public int IdNiveles { get; set; }

    public string? NombreNivel { get; set; }

    public string? Descripcion { get; set; }

    public int PuntajeMinimo { get; set; }

    public int PuntajeMaximo { get; set; }

    public int? Completado { get; set; }

    public int MundosIdMundos { get; set; }

    public int PreguntasIdPreguntas { get; set; }

    public virtual Mundo MundosIdMundosNavigation { get; set; } = null!;

    public virtual ICollection<Pregunta> Pregunta { get; set; } = new List<Pregunta>();

    public virtual ICollection<ProgresoJugador> ProgresoJugadors { get; set; } = new List<ProgresoJugador>();
}
