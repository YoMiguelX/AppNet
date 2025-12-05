using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShenmiApp.Models
{
    [Table("mundos")]
    public partial class Mundos
    {
        [Key]
        [Column("ID_MUNDOS")]
        public int IdMundos { get; set; }

        [Column("NOMBRE_MUNDO")]
        public string? NombreMundo { get; set; }

        // Relación con niveles
        [InverseProperty("MundosIdMundosNavigation")]
        public virtual ICollection<Niveles> Niveles { get; set; } = new List<Niveles>();
    }
}
