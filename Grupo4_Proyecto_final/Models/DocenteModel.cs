using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_Proyecto_final.Models
{
    [Table("mnt_docente")]
    public class DocenteModel
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nombres")]
        public string Nombres { get; set; }

        [Column("apellidos")]
        public string Apellidos { get; set; }

        [Column("telefono")]
        public string Telefono { get; set; }

        [Column("edad")]
        public int Edad { get; set; }

        [Column("fecha_nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Column("id_grado")]
        public int GradoId { get; set; }

        [ForeignKey("GradoId")]
        public GradoModel Grado { get; set; }

        [Column("id_seccion")]
        public int SeccionId { get; set; }

        [ForeignKey("SeccionId")]
        public SeccionModel Seccion { get; set; }

        [Column("id_usuario")]
        public int? UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public UsuarioModel Usuario { get; set; }
    }
}
