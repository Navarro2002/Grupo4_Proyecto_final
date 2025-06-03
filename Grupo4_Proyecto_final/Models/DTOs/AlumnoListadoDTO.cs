using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_Proyecto_final.Models.DTOs
{
    internal class AlumnoListadoDTO
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Telefono { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string GradoNombre { get; set; }
        public int IdGrado { get; set; }
        public string SeccionNombre { get; set; }
        public int IdSeccion { get; set; }
        public string Usuario { get; set; }
        public double Promedio { get; set; }

    }
}
