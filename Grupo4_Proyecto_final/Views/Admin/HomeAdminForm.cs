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

namespace Grupo4_Proyecto_final.Views.Admin
{
    public partial class HomeAdminForm : Form
    {
        private int childFormNumber = 0;

        public HomeAdminForm()
        {
            InitializeComponent();
        }


        private void HomeAdminForm_Load(object sender, EventArgs e)
        {

            AdminController controller = new AdminController();
            var totalDocentes = controller.ObtenerTotalDocentes();
            var totalAlumnos = controller.ObtenerTotalAlumnos();
            var totalUsuarios = controller.ObtenerTotalUsuarios();

            lblCantDocentes.Text = totalDocentes.ToString();
            lblCantAlumnos.Text = totalAlumnos.ToString();
            lblCantUsuarios.Text = totalUsuarios.ToString();
        }

        private void btnAdministrarUsuarios_Click(object sender, EventArgs e)
        {
            GestionAdminForm formAdminUsuarios = new GestionAdminForm();
            formAdminUsuarios.Show();
        }

        private void btnAdministrarDocentes_Click(object sender, EventArgs e)
        {
            GestionarDocenteForm formAdminDocentes = new GestionarDocenteForm();
            formAdminDocentes.Show();
        }

        private void btnSeccion_Click(object sender, EventArgs e)
        {
            GestionSeccionForm formAdminSecciones = new GestionSeccionForm();
            formAdminSecciones.Show();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            GestionAlumnoForm form = new GestionAlumnoForm();
            form.Show();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            GestionMateriasForm form = new GestionMateriasForm();
            form.Show();
        }
    }
}
