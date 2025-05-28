using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_Proyecto_final.Models
{
    [Table("mnt_usuarios")]
    public class UsuarioModel
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("usuario")]
        public string Usuario { get; set; }

        [Column("contrasenia")]
        public string Contrasenia { get; set; }

        [Column("id_rol")]
        public int RolId { get; set; }

        [ForeignKey("RolId")]
        public RolModel Rol { get; set; }

    }
}
