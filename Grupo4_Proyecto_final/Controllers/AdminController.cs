using Grupo4_Proyecto_final.Connection;
using Grupo4_Proyecto_final.Controllers.Auth;
using Grupo4_Proyecto_final.Models;
using Grupo4_Proyecto_final.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Grupo4_Proyecto_final.Controllers
{
    internal class AdminController
    {
        public int ObtenerTotalAlumnos()
        {
            using (var context = new AppDbContext())
            {
                return context.Alumnos.Count();
            }
        }

        public int ObtenerTotalDocentes()
        {
            using (var context = new AppDbContext())
            {
                return context.Docentes.Count();
            }
        }

        public int ObtenerTotalUsuarios()
        {
            using (var context = new AppDbContext())
            {
                return context.Usuarios.Count();
            }
        }

        public List<UsuarioListadoDTO> ListarUsuarios()
        {
            using (var context = new AppDbContext())
            {
                return (from u in context.Usuarios
                        join r in context.Rol on u.RolId equals r.id
                        select new UsuarioListadoDTO
                        {
                            Id = u.Id,
                            UsuarioLogin = u.Usuario,
                            Contrasenia = u.Contrasenia,
                            RolAsignado = r.nombre,
                            RolId = r.id
                        }).ToList();
            }
        }

        public bool CrearUsuario(string usuario, string clave, int rolId)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    if (context.Usuarios.Any(u => u.Usuario == usuario))
                        return false;

                    var nuevoUsuario = new UsuarioModel
                    {
                        Usuario = usuario,
                        Contrasenia = HashHelper.Sha256(clave),
                        RolId = rolId
                    };

                    context.Usuarios.Add(nuevoUsuario);
                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool EditarUsuario(int id, string usuario, int rolId)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var usuarioExistente = context.Usuarios.Find(id);
                    if (usuarioExistente == null)
                        return false;

                    if (usuarioExistente.Usuario != usuario && context.Usuarios.Any(u => u.Usuario == usuario))
                        return false;

                    usuarioExistente.Usuario = usuario;
                    //if (!string.IsNullOrEmpty(clave))
                    //{
                    //    usuarioExistente.Contrasenia = HashHelper.Sha256(clave);
                    //}
                    usuarioExistente.RolId = rolId;

                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarUsuario(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var usuario = context.Usuarios.Find(id);
                    if (usuario == null)
                        return false;

                    context.Usuarios.Remove(usuario);
                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        // Docentes 
        public List<DocenteListadoDTO> ListarDocentes()
        {
            using (var context = new AppDbContext())
            {
                return (from d in context.Docentes
                        join g in context.Grados on d.GradoId equals g.Id
                        join s in context.Secciones on d.SeccionId equals s.Id
                        join u in context.Usuarios on d.UsuarioId equals u.Id
                        select new DocenteListadoDTO
                        {
                            Id = d.Id,
                            NombreCompleto = d.Nombres + " " + d.Apellidos,
                            Edad = d.Edad,
                            FechaNacimiento = d.FechaNacimiento,
                            GradoNombre = g.Nombre,
                            IdGrado = d.GradoId,
                            SeccionNombre = s.Nombre, 
                            IdSeccion = d.SeccionId,
                            Telefono = d.Telefono,
                            Usuario = u.Usuario,

                        }).ToList();
            }
        }

        public bool CrearDocente(
                    string usuarioLogin, string clave,
                    string nombres, string apellidos, string telefono, int edad, DateTime fechaNacimiento,
                    int gradoId, int seccionId)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    // Verificar si el usuario ya existe
                    if (context.Usuarios.Any(u => u.Usuario == usuarioLogin))
                        return false;

                    // Crear usuario
                    var nuevoUsuario = new UsuarioModel
                    {
                        Usuario = usuarioLogin,
                        Contrasenia = HashHelper.Sha256(clave),
                        RolId = 2
                    };

                    context.Usuarios.Add(nuevoUsuario);
                    context.SaveChanges(); // Importante: para que se genere el ID

                    // Crear docente usando el ID del usuario recién creado
                    var nuevoDocente = new DocenteModel
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

                    context.Docentes.Add(nuevoDocente);
                    context.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool EditarDocente(
                int docenteId,
                string nuevosNombres, string nuevosApellidos, string nuevoTelefono, int nuevaEdad, DateTime nuevaFechaNacimiento,
                int nuevoGradoId, int nuevaSeccionId)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    // Buscar al docente existente
                    var docente = context.Docentes.FirstOrDefault(d => d.Id == docenteId);

                    if (docente == null)
                        return false;

                    // Actualizar datos del docente
                    docente.Nombres = nuevosNombres;
                    docente.Apellidos = nuevosApellidos;
                    docente.Telefono = nuevoTelefono;
                    docente.Edad = nuevaEdad;
                    docente.FechaNacimiento = nuevaFechaNacimiento;
                    docente.GradoId = nuevoGradoId;
                    docente.SeccionId = nuevaSeccionId;

                    context.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarDocente(int docenteId)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var docente = context.Docentes.FirstOrDefault(d => d.Id == docenteId);
                    if (docente == null)
                        return false;

                    context.Docentes.Remove(docente);
                    context.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        //Alumno
        public List<AlumnoListadoDTO> ListarAlumnos()
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

        public bool EditarAlumno(
                int alumnoId,
                string nuevosNombres, string nuevosApellidos, string nuevoTelefono, int nuevaEdad, DateTime nuevaFechaNacimiento,
                int nuevoGradoId, int nuevaSeccionId)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var alumno = context.Alumnos.FirstOrDefault(a => a.Id == alumnoId);

                    if (alumno == null)
                        return false;

                    alumno.Nombres = nuevosNombres;
                    alumno.Apellidos = nuevosApellidos;
                    alumno.Telefono = nuevoTelefono;
                    alumno.Edad = nuevaEdad;
                    alumno.FechaNacimiento = nuevaFechaNacimiento;
                    alumno.GradoId = nuevoGradoId;
                    alumno.SeccionId = nuevaSeccionId;

                    context.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarAlumno(int alumnoId)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var alumno = context.Alumnos.FirstOrDefault(a => a.Id == alumnoId);
                    if (alumno == null)
                        return false;

                    context.Alumnos.Remove(alumno);
                    context.SaveChanges();

                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error al eliminar el alumno: {e.Message}");
                return false;
            }
        }

        // Secciones 
        public List<SeccionListadoDTO> ListarSecciones()
        {
            using (var context = new AppDbContext())
            {
                return (from d in context.Secciones
                        select new SeccionListadoDTO
                        {
                            Id = d.Id,
                            Nombre = d.Nombre
                        }).ToList();
            }
        }

        public bool CrearSeccion(string nombre)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var nuevaSeccion = new SeccionModel
                    {
                        Nombre = nombre 
                    };

                    context.Secciones.Add(nuevaSeccion);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear la sección: {ex.Message}");
                return false;
            }
        }

        public bool EditarSeccion(int id, string nuevoNombre)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var seccion = context.Secciones.FirstOrDefault(s => s.Id == id);
                    if (seccion == null)
                        return false;

                    seccion.Nombre = nuevoNombre;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al editar la sección: {ex.Message}");
                return false;
            }
        }

        public bool EliminarSeccion(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var seccion = context.Secciones.FirstOrDefault(s => s.Id == id);
                    if (seccion == null)
                        return false;

                    context.Secciones.Remove(seccion);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar la sección: {ex.Message}");
                return false;
            }
        }

        public List<MateriasListadoDTO> ListarMaterias()
        {
            using (var context = new AppDbContext())
            {
                return (from d in context.Materias
                        select new MateriasListadoDTO
                        {
                            Id = d.Id,
                            Nombre = d.Nombre
                        }).ToList();
            }
        }


    }
}
