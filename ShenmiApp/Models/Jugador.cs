using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShenmiApp.Models
{
    [Table("jugador")]
    public partial class Jugador
    {
        [Key]
        [Column("ID_JUGADOR")]
        public int IdJugador { get; set; }

        [Column("NOMBRE")]
        public string? Nombre { get; set; }

        [Column("FECHA_REGISTRO")]
        public DateTime? FechaRegistro { get; set; }

        [Column("ULTIMA_CONEXION")]
        public DateTime? UltimaConexion { get; set; }

        [Column("PROGRESO_JUGADOR_ID_PROGRESO_JUGADOR")]
        public int ProgresoJugadorIdProgresoJugador { get; set; }

        [Column("usuario_ID_USUARIO")]
        public int UsuarioIdUsuario { get; set; }

    

        [ForeignKey("ProgresoJugadorIdProgresoJugador")]
        public virtual ProgresoJugador ProgresoJugadorIdProgresoJugadorNavigation { get; set; } = null!;
    }
}
