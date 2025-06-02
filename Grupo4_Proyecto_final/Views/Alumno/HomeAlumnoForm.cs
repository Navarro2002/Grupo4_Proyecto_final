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
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            CalificacionesAlumnoForm calificacionesForm = new CalificacionesAlumnoForm();
            calificacionesForm.ShowDialog();
        }
    }
}
