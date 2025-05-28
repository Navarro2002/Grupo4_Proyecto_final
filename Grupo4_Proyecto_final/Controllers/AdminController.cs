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

    }
}
