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
            ListadoAlumnosForm listadoAlumnosForm = new ListadoAlumnosForm();
            listadoAlumnosForm.Show();
        }

        private void HomeDocenteForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = user;
        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            RegistrarAlumnoForm registrarAlumnosForm = new RegistrarAlumnoForm();
            registrarAlumnosForm.Show();
        }
    }
}
