using Grupo4_Proyecto_final.Connection;
using Grupo4_Proyecto_final.Models;
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
    public partial class RegistrarAlumnoForm : Form
    {
        private int childFormNumber = 0;

        public RegistrarAlumnoForm()
        {
            InitializeComponent();
        }

        private void RegistrarAlumnoForm_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();

            using (var context = new AppDbContext())
            {
                var grados = context.Grados.ToList();
                grados.Insert(0, new GradoModel { Id = 0, Nombre = "Seleccione" });
                cmbGrado.DataSource = grados;
                cmbGrado.DisplayMember = "nombre";
                cmbGrado.ValueMember = "id";

                var seccion = context.Secciones.ToList();
                seccion.Insert(0, new SeccionModel { Id = 0, Nombre = "Seleccione" });
                cmbSeccion.DataSource = seccion;
                cmbSeccion.DisplayMember = "nombre";
                cmbSeccion.ValueMember = "id";

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
