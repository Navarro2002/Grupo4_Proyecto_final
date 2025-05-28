using Grupo4_Proyecto_final.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_Proyecto_final.Connection
{
    internal class AppDbContext: DbContext
    {
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<AlumnoModel> Alumnos { get; set; }
        public DbSet<DocenteModel> Docentes { get; set; }
        public DbSet<RolModel> Rol { get; set; }
        public DbSet<GradoModel> Grados { get; set; }
        public DbSet<SeccionModel> Secciones { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=master;User Id=sa;Password=Admin123!;TrustServerCertificate=True;");
        }
    }
}
