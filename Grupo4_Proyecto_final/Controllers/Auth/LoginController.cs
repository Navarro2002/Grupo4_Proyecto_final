using Grupo4_Proyecto_final.Connection;
using Grupo4_Proyecto_final.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_Proyecto_final.Controllers.Auth
{
    internal class LoginController
    {
        public UsuarioModel Autenticar(string usuario, string contrasenia)
        {
            using (var context = new AppDbContext())
            {
                string claveHash = HashHelper.Sha256(contrasenia);

                return context.Usuarios
                    .Include(u => u.Rol)
                    .FirstOrDefault(u => u.Usuario == usuario && u.Contrasenia == claveHash);
            }
        }
    }
}
