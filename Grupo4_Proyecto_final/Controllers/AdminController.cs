using Grupo4_Proyecto_final.Connection;
using Grupo4_Proyecto_final.Controllers.Auth;
using Grupo4_Proyecto_final.Models;
using Grupo4_Proyecto_final.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}
