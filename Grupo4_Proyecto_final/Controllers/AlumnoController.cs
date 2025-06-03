using Grupo4_Proyecto_final.Connection;
using Grupo4_Proyecto_final.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_Proyecto_final.Controllers
{
    internal class AlumnoController
    {
        public AlumnoListadoDTO ObtenerAlumno(int idUsuario)
        {
            using (var context = new AppDbContext())
            {
                var info = context.Alumnos
                    .Where(a => a.UsuarioId == idUsuario)
                    .Select(a => new AlumnoListadoDTO
                    {
                        Id = a.Id,
                        NombreCompleto = a.Nombres + " " + a.Apellidos,
                        Telefono = a.Telefono,
                        Edad = a.Edad,
                        FechaNacimiento = a.FechaNacimiento,
                        IdGrado = a.GradoId,
                        GradoNombre = a.Grado.Nombre,
                        IdSeccion = a.SeccionId,
                        SeccionNombre = a.Seccion.Nombre,
                    })
                    .FirstOrDefault();

                return info;
            }
        }

        public List<PromedioTrimestreDTO> ObtenerPromedioPorTrimestre(int idAlumno)
        {
            using (var context = new AppDbContext())
            {
                return context.Database.SqlQuery<PromedioTrimestreDTO>(
                    $"EXEC sp_PromedioPorTrimestre @id_alumno = {idAlumno}"
                ).ToList();
            }
        }


    }
}
