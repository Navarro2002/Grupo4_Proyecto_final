using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_Proyecto_final.Models
{
    [Table("mnt_grado")]
    public class GradoModel
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("id_seccion")]
        public int SeccionId { get; set; }

        [ForeignKey("SeccionId")]
        public SeccionModel Seccion { get; set; }

        [Column("cantidad_materias")]
        public int CantidadMaterias { get; set; }
    }
}
