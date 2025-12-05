using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShenmiApp.Models
{
    [Table("niveles")]
    public partial class Niveles
    {
        [Key]
        [Column("ID_NIVELES")]
        public int IdNiveles { get; set; }

        [Column("nombre_nivel")]
        public string? NombreNivel { get; set; }

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Column("PUNTAJE_MINIMO")]
        public int PuntajeMinimo { get; set; }

        [Column("PUNTAJE_MAXIMO")]
        public int PuntajeMaximo { get; set; }

        [Column("completado")]
        public int? Completado { get; set; }

        [Column("mundos_id_mundos")]
        public int MundosIdMundos { get; set; }

        [Column("PREGUNTAS_ID_PREGUNTAS")]
        public int PreguntasIdPreguntas { get; set; }

        [ForeignKey("MundosIdMundos")]
        public virtual Mundos MundosIdMundosNavigation { get; set; } = null!;

        [InverseProperty(nameof(Preguntas.NivelesIdNivelesNavigation))]
        public virtual ICollection<Preguntas> Pregunta { get; set; } = new List<Preguntas>();

        [InverseProperty(nameof(ProgresoJugador.NivelesIdNivelesNavigation))]
        public virtual ICollection<ProgresoJugador> ProgresoJugadors { get; set; } = new List<ProgresoJugador>();

    }
}