using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_Proyecto_final.Models.DTOs
{
    internal class UsuarioListadoDTO
    {
        public int Id { get; set; }
        public string UsuarioLogin { get; set; }
        public string NombreCompleto { get; set; }
        public string Contrasenia { get; set; }
        public string RolAsignado { get; set; }
        public int RolId { get; set; }
    }
}
