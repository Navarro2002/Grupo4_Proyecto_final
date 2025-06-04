using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_Proyecto_final.Models.DTOs
{
    internal class PromediosMateriasDTO
    {
        public string Materia { get; set; }
        public string Trimestre { get; set; }
        public decimal Promedio { get; set; }
        public string Estado { get; set; }
    }
}
