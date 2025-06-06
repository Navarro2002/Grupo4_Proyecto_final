using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_Proyecto_final.Models.DTOs
{
     class ReporteNotas
    {
        public class ReporteNotaDTO
        {
            public string Materia { get; set; }
            public string Trimestre { get; set; }
            public double Nota { get; set; }
        }
    }
}
