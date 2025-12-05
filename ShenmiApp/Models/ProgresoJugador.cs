using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShenmiApp.Models
{
    [Table("progreso_jugador")]
    public partial class ProgresoJugador
    {
        [Key]
        [Column("ID_PROGRESO_JUGADOR")]
        public int IdProgresoJugador { get; set; }

        [Column("PUNTAJE_NIVEL")]
        public int PuntajeNivel { get; set; }

        [Column("nivel_completado")]
        public int? NivelCompletado { get; set; }

        [Column("TIEMPO_JUGADO")]
        public int TiempoJugado { get; set; }

        [Column("FECHA_COMPLETADO")]
        public DateTime FechaCompletado { get; set; }

        [Column("NIVELES_ID_NIVELES")]
        public int NivelesIdNiveles { get; set; }

        [ForeignKey("NivelesIdNiveles")]
        public virtual Niveles NivelesIdNivelesNavigation { get; set; } = null!;
    }
}
