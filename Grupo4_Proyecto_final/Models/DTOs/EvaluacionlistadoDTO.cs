using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_Proyecto_final.Models.DTOs
{
    internal class EvaluacionlistadoDTO
    {
        public int Id { get; set; }
        public string Evaluacion { get; set; }
        public int AlumnoId { get; set; }
        public int MateriaId { get; set; }
        public string Materia { get; set; }
        public int TrimestreId { get; set; }
        public string Trimestre { get; set; } 
        public double Nota { get; set; }
    }
}
