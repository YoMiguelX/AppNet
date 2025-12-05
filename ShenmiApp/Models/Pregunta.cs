using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShenmiApp.Models
{
    [Table("preguntas")]
    public partial class Preguntas
    {
        [Key]
        [Column("ID_PREGUNTAS")]
        public int IdPreguntas { get; set; }

        [Column("TEXTO_PREGUNTA")]
        public string? TextoPregunta { get; set; }

        [Column("opciones_respuesta")]
        public string? OpcionesRespuesta { get; set; }

        [Column("respuesta_correcta")]
        public string? RespuestaCorrecta { get; set; }

        [Column("EXPLICACION")]
        public string? Explicacion { get; set; }

        [Column("PUNTOS")]
        public int Puntos { get; set; }

        [Column("RESPUESTAS_JUGADOR_ID_RESPUESTAS_JUGADOR")]
        public int RespuestasJugadorIdRespuestasJugador { get; set; }

        // 👉 ESTA PROPIEDAD ES OBLIGATORIA PARA EL FK
        [Column("NIVELES_ID_NIVELES")]
        public int NivelesIdNiveles { get; set; }

        [ForeignKey("NivelesIdNiveles")]
        public virtual Niveles NivelesIdNivelesNavigation { get; set; } = null!;
    }
}
