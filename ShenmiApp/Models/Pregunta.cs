using System;
using System.Collections.Generic;

namespace ShenmiApp.Models;

public partial class Pregunta
{
    public int IdPreguntas { get; set; }

    public string? TextoPregunta { get; set; }

    public string? OpcionesRespuesta { get; set; }

    public string? RespuestaCorrecta { get; set; }

    public string? Explicacion { get; set; }

    public int Puntos { get; set; }

    public int RespuestasJugadorIdRespuestasJugador { get; set; }

    public int NivelesIdNiveles { get; set; }

    public virtual Nivele NivelesIdNivelesNavigation { get; set; } = null!;
}
