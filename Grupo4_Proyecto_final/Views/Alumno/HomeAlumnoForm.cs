using Grupo4_Proyecto_final.Controllers;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo4_Proyecto_final.Views.Alumno
{
    public partial class HomeAlumnoForm : Form
    {
        public int idUser;
        public string user;
        public int idRol;
        public int idAlumno;
        public string nombreCompleto;

        public HomeAlumnoForm(int idUsuario, string usuario, int idRol)
        {
            InitializeComponent();
            this.idUser = idUsuario;
            this.user = usuario;
            this.idRol = idRol;
        }

        private void HomeAlumnoForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = user;
            var controller = new AlumnoController();
            var alumno = controller.ObtenerAlumno(idUser); 
            this.idAlumno = alumno.Id;
            this.nombreCompleto = alumno.NombreCompleto ?? "No disponible";
            if (alumno != null)
            {
                lblAlumno.Text = alumno.NombreCompleto ?? "-";
                lblGrado.Text = alumno.GradoNombre ?? "-";
                lblSeccion.Text = alumno.SeccionNombre ?? "-";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 

        private void btnVerPromedios_Click(object sender, EventArgs e)
        {
            PromediosAlumnosForm Form = new PromediosAlumnosForm(idAlumno, nombreCompleto);
            Form.ShowDialog();
        }

   
    }
}
