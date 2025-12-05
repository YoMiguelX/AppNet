using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShenmiApp.Models;

public partial class RespuestasJugador
{
    [Key]
    public int IdRespuestasJugador { get; set; }

    public string RespuestasJugador1 { get; set; } = null!;

    public sbyte Correcta { get; set; }

    public int? TiempoRespuesta { get; set; }

    public int JugadorIdJugador { get; set; }

    public int PreguntasIdPreguntas { get; set; }
}
