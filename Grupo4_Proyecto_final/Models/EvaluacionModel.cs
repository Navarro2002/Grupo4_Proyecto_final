using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_Proyecto_final.Models
{
    [Table("mnt_evaluaciones")]
    public class EvaluacionModel
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("evaluacion")]
        public string Evaluacion { get; set; }

        [Column("id_alumno")]
        public int AlumnoId { get; set; }

        [ForeignKey("AlumnoId")]
        public AlumnoModel Alumno { get; set; }

        [Column("id_materia")]
        public int MateriaId { get; set; }

        [ForeignKey("MateriaId")]
        public MateriaModel Materia { get; set; }

        [Column("id_trimestre")]
        public int TrimestreId { get; set; }

        [ForeignKey("TrimestreId")]
        public TrimestreModel Trimestre { get; set; }

        [Column("nota")]
        public float Nota { get; set; }
    }

}
