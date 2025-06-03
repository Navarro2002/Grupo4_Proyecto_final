using Grupo4_Proyecto_final.Connection;
using Grupo4_Proyecto_final.Controllers.Auth;
using Grupo4_Proyecto_final.Models;
using Grupo4_Proyecto_final.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_Proyecto_final.Controllers
{
    internal class DocenteController
    {
        public DocenteListadoDTO ObtenerDocente(int idUsuario)
        {
            using (var context = new AppDbContext())
            {
                var info = context.Docentes
                    .Where(d => d.UsuarioId == idUsuario)
                    .Select(d => new DocenteListadoDTO
                    {
                        Id = d.Id,
                        NombreCompleto = d.Nombres + " " + d.Apellidos,
                        Telefono = d.Telefono,
                        Edad = d.Edad,
                        FechaNacimiento = d.FechaNacimiento,
                        IdGrado = d.GradoId,
                        GradoNombre = d.Grado.Nombre,
                        IdSeccion = d.SeccionId,
                        SeccionNombre = d.Seccion.Nombre,
                    })
                    .FirstOrDefault();

                return info;
            }
        }

        public int cantidadAlumnos(int idUsuario)
        {
            using (var context = new AppDbContext())
            {
                var docente = context.Docentes
                    .FirstOrDefault(d => d.UsuarioId == idUsuario);

                if (docente == null)
                    return 0;

                int cantidadEstudiantes = context.Alumnos
                    .Count(alumno => alumno.GradoId == docente.GradoId && alumno.SeccionId == docente.SeccionId);

                return cantidadEstudiantes;
            }
        }

        public bool CrearAlumno(
            string usuarioLogin, string clave,
            string nombres, string apellidos, string telefono, int edad, DateTime fechaNacimiento,
            int gradoId, int seccionId)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    if (context.Usuarios.Any(u => u.Usuario == usuarioLogin))
                        return false;

                    var nuevoUsuario = new UsuarioModel
                    {
                        Usuario = usuarioLogin,
                        Contrasenia = HashHelper.Sha256(clave),
                        RolId = 3
                    };

                    context.Usuarios.Add(nuevoUsuario);
                    context.SaveChanges();

                    var nuevoAlumnno = new AlumnoModel
                    {
                        Nombres = nombres,
                        Apellidos = apellidos,
                        Telefono = telefono,
                        Edad = edad,
                        FechaNacimiento = fechaNacimiento,
                        GradoId = gradoId,
                        SeccionId = seccionId,
                        UsuarioId = nuevoUsuario.Id
                    };

                    context.Alumnos.Add(nuevoAlumnno);
                    context.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public List<AlumnoListadoDTO> ListarAlumnos(int idGrado, int idSeccion)
        {
            using (var context = new AppDbContext())
            {
                return (from a in context.Alumnos
                        join g in context.Grados on a.GradoId equals g.Id into gradoJoin
                        from g in gradoJoin.DefaultIfEmpty()

                        join s in context.Secciones on a.SeccionId equals s.Id into seccionJoin
                        from s in seccionJoin.DefaultIfEmpty()

                        join u in context.Usuarios on a.UsuarioId equals u.Id into usuarioJoin
                        from u in usuarioJoin.DefaultIfEmpty()

                        where a.GradoId == idGrado && a.SeccionId == idSeccion

                        select new AlumnoListadoDTO
                        {
                            Id = a.Id,
                            NombreCompleto = a.Nombres + " " + a.Apellidos,
                            Edad = a.Edad,
                            FechaNacimiento = a.FechaNacimiento,
                            GradoNombre = g != null ? g.Nombre : " ",
                            IdGrado = a.GradoId,
                            SeccionNombre = s != null ? s.Nombre : "",
                            IdSeccion = a.SeccionId,
                            Telefono = a.Telefono,
                            Usuario = u != null ? u.Usuario : ""
                        }).ToList();
            }
        }

        // Asignar calificación
        public bool AsignarCalificacion(int idAlumno, int idMateria, int idTrimestre, double calificacion, string evaluacion)
        {
            try
            {
                using (var context = new AppDbContext())
                {

                    var nuevaEvaluacion = new EvaluacionModel
                    {
                        AlumnoId = idAlumno,
                        MateriaId = idMateria,
                        TrimestreId = idTrimestre,
                        Evaluacion = evaluacion,
                        Nota = (float)calificacion 
                    };

                    context.Evaluaciones.Add(nuevaEvaluacion);
                    context.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
