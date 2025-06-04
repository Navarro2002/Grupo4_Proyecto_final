using Grupo4_Proyecto_final.Connection;
using Grupo4_Proyecto_final.Controllers.Auth;
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


        public List<EvaluacionlistadoDTO> ListarEvaluaciones(int alumnoId, int? materiaId = null, int? trimestreId = null)
        {
            using (var context = new AppDbContext())
            {
                var query = context.Evaluaciones
                                   .Include(e => e.Materia)
                                   .Include(e => e.Trimestre)
                                   .Where(e => e.AlumnoId == alumnoId);

                if (materiaId.HasValue)
                {
                    query = query.Where(e => e.MateriaId == materiaId.Value);
                }

                if (trimestreId.HasValue)
                {
                    query = query.Where(e => e.TrimestreId == trimestreId.Value);
                }

                var result = query.Select(e => new EvaluacionlistadoDTO
                {
                    Id = e.Id,
                    Evaluacion = e.Evaluacion,
                    AlumnoId = e.AlumnoId,
                    MateriaId = e.MateriaId,
                    Materia = e.Materia.Nombre,
                    TrimestreId = e.TrimestreId,
                    Trimestre = e.Trimestre.Trimestre,
                    Nota = e.Nota
                });

                return result.ToList();
            }
        }

        public List<PromedioPorMateriaDTO> ObtenerPromediosPorMateria(int alumnoId, int? trimestreId = null)
        {
            using (var context = new AppDbContext())
            {
                {
                    var query = context.Evaluaciones
                                       .Include(e => e.Materia)
                                       .Include(e => e.Trimestre)
                                       .Where(e => e.AlumnoId == alumnoId);

                    if (trimestreId != null)
                        query = query.Where(e => e.TrimestreId == trimestreId);

                    var resultado = query
                        .GroupBy(e => new
                        {
                            e.MateriaId,
                            MateriaNombre = e.Materia.Nombre,
                            TrimestreNombre = e.Trimestre.Trimestre
                        })
                        .Select(g => new PromedioPorMateriaDTO
                        {
                            NombreMateria = g.Key.MateriaNombre,
                            NombreTrimestre = g.Key.TrimestreNombre,
                            PromedioNota = Math.Round(g.Average(e => e.Nota), 2)
                        })
                        .ToList();

                    return resultado;
                }
            }
        }

        public bool ActualizarContresenia(int id, string contrasenia)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var usuarioExistente = context.Usuarios.Find(id);
                    if (usuarioExistente == null)
                        return false;
                    usuarioExistente.Contrasenia = HashHelper.Sha256(contrasenia);
                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public List<PorcentajeAlumnosDTO> ObtenerPorcentajeAlumnos()
        {
            using (var context = new AppDbContext())
            {
                return context.Database.SqlQuery<PorcentajeAlumnosDTO>(
                    $"EXEC sp_PorcentajeAprobacion"
                ).ToList();
            }
        }

        public List<PromediosMateriasDTO> ObtenerMateriasAprobadasReprobadas(int idAlumno, int? idTrimestre = null)
        {
            using (var context = new AppDbContext())
            {
                return context.Database.SqlQuery<PromediosMateriasDTO>(
                    $"EXEC sp_MateriasAprobadasReprobadas @id_alumno = {idAlumno}, @id_trimestre = {idTrimestre}"
                ).ToList();
            }
        }

    }
}
