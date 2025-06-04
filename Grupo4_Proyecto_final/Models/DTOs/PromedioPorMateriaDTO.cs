using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_Proyecto_final.Models.DTOs
{
    internal class PromedioPorMateriaDTO
    {
        public int MateriaId { get; set; }
        public string NombreMateria { get; set; }
        public double PromedioNota { get; set; }
        public string NombreTrimestre { get; set; }
    }
}
