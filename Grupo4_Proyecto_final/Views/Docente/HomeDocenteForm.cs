using Grupo4_Proyecto_final.Connection;
using Grupo4_Proyecto_final.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo4_Proyecto_final.Views.Docente
{
    public partial class HomeDocenteForm : Form
    {
        public int idUser;
        public string user;
        public int idRol;

        public HomeDocenteForm(int id, string user, int idRol)
        {
            InitializeComponent();
            this.user = user;
            this.idUser = id;
            this.idRol = idRol;
        }
        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            ListadoAlumnosForm listadoAlumnosForm = new ListadoAlumnosForm(idUser, user, idRol);
            listadoAlumnosForm.Show();
        }

        private void HomeDocenteForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = user;
            var controller = new DocenteController();
            var docente = controller.ObtenerDocente(idUser); // Realizar un casteo explícito a la clase esperada  
            var cantidadAlumnos = controller.cantidadAlumnos(idUser);
            lblCantAlumnos.Text = cantidadAlumnos.ToString();

            if (docente != null)
            {
                lblNombreDocente.Text = docente.NombreCompleto ?? "-";
                lblGrado.Text = docente.GradoNombre ?? "-";
                lblSeccion.Text = docente.SeccionNombre ?? "-";
            }
        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            RegistrarAlumnoForm registrarAlumnosForm = new RegistrarAlumnoForm(idUser, user);
            registrarAlumnosForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
