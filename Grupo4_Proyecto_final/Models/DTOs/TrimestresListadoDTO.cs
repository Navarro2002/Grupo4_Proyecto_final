using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_Proyecto_final.Models.DTOs
{
    internal class TrimestresListadoDTO
    {
        public int Id { get; set; }

        public string Trimestre { get; set; }

        public double NotaMinima { get; set; }
    }
}
