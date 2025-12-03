using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShenmiApp.Models
{
    [Table("usuario")]
    public partial class Usuario
    {
        [Key]
        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }

        [Column("NOMBRE_USUARIO")]
        public string NombreUsuario { get; set; } = null!;

        [Column("APELLIDO_USUARIO")]
        public string ApellidoUsuario { get; set; } = null!;

        [Column("TEL_USUARIO")]
        public string TelUsuario { get; set; } = null!;

        [Column("CORREO_USUARIO")]
        public string CorreoUsuario { get; set; } = null!;

        [Column("CONTRASENA")]
        public string Contrasena { get; set; } = null!;

        [Column("ESTADO_USUARIO")]
        public string EstadoUsuario { get; set; } = null!;

        [Column("FECHA_CREACION")]
        public DateTime FechaCreacion { get; set; }

        [Column("ROL_ID_ROL")]
        public int RolIdRol { get; set; }

        [Column("RESET_TOKEN")]
        public string? ResetToken { get; set; }

        [Column("RESET_TOKEN_EXPIRATION")]
        public DateTime? ResetTokenExpiration { get; set; }
    }
}
