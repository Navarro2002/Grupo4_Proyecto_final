using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_Proyecto_final.Models
{
    [Table("mnt_trimestre")]
    public class TrimestreModel
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("trimestre")]
        public string Trimestre { get; set; }

        [Column("promedio_final")]
        public double? PromedioFinal { get; set; }

        [Column("nota_minima")]
        public double NotaMinima { get; set; }
    }
}
