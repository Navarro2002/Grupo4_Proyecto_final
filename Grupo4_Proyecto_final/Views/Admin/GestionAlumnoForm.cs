using Grupo4_Proyecto_final.Connection;
using Grupo4_Proyecto_final.Controllers;
using Grupo4_Proyecto_final.Models;
using Grupo4_Proyecto_final.Models.DTOs;
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
    public partial class GestionAlumnoForm : Form
    {
        private List<AlumnoListadoDTO> listaAlumno = new List<AlumnoListadoDTO>();

        public GestionAlumnoForm()
        {
            InitializeComponent();
            CargarAlumnos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GestionAlumnoForm_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            using (var context = new AppDbContext())
            {
                var grados = context.Grados.ToList();

                grados.Insert(0, new GradoModel { Id = 0, Nombre = "Seleccione" });

                // Asignar al ComboBox
                cmbGrado.DataSource = grados;
                cmbGrado.DisplayMember = "nombre";
                cmbGrado.ValueMember = "id";
            }
        }

        private void CargarAlumnos()
        {
            AdminController controller = new AdminController();
            listaAlumno = controller.ListarAlumnos();

            if (dataGridViewAlumnos.Columns.Count == 0)
            {
                dataGridViewAlumnos.Columns.Add("Id", "Id");
                dataGridViewAlumnos.Columns.Add("NombreCompleto", "NombreCompleto");
                dataGridViewAlumnos.Columns.Add("Edad", "Edad");
                dataGridViewAlumnos.Columns.Add("Telefono", "Telefono");
                dataGridViewAlumnos.Columns.Add("FechaNacimiento", "FechaNacimiento");
                dataGridViewAlumnos.Columns.Add("GradoNombre", "GradoNombre");
                dataGridViewAlumnos.Columns.Add("IdGrado", "IdGrado");
                dataGridViewAlumnos.Columns.Add("SeccionNombre", "SeccionNombre");
                dataGridViewAlumnos.Columns.Add("IdSeccion", "IdSeccion");
                dataGridViewAlumnos.Columns.Add("Usuario", "Usuario");

            }

            MostrarAlumnos(listaAlumno);
        }

        private void MostrarAlumnos(List<AlumnoListadoDTO> alumnos)
        {
            dataGridViewAlumnos.Rows.Clear();

            foreach (var alumno in alumnos)
            {
                dataGridViewAlumnos.Rows.Add(
                    alumno.Id,
                    alumno.NombreCompleto,
                    alumno.Edad,
                    alumno.Telefono,
                    alumno.FechaNacimiento,
                    alumno.GradoNombre,
                    alumno.IdGrado,
                    alumno.SeccionNombre,
                    alumno.IdSeccion,
                    alumno.Usuario
                );
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var form = new CrearAlumnoForm();
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                CargarAlumnos();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDocenteBusq_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void cmbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();

        }

        private void AplicarFiltros()
        {
            string filtroTexto = txtDocenteBusq.Text.ToLower();

            int gradoSeleccionadoId = 0;

            if (cmbGrado.SelectedValue != null && int.TryParse(cmbGrado.SelectedValue.ToString(), out int valor))
            {
                gradoSeleccionadoId = valor;
            }

            var usuariosFiltrados = listaAlumno.Where(d =>
                (d.NombreCompleto.ToLower().Contains(filtroTexto) ||
                 d.GradoNombre.ToLower().Contains(filtroTexto)) &&
                (gradoSeleccionadoId == 0 || d.IdGrado == gradoSeleccionadoId)
            ).ToList();

            MostrarAlumnos(usuariosFiltrados);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDocenteBusq.Text = "";
            cmbGrado.SelectedIndex = 0;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlumnos.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridViewAlumnos.SelectedRows[0];

                int id = Convert.ToInt32(fila.Cells["Id"].Value);
                string usuario = fila.Cells["Usuario"].Value.ToString();
                string nombre = fila.Cells["Nombre"].Value.ToString().Split(' ')[0];
                string apellido = fila.Cells["Nombre"].Value.ToString().Split(' ').Length > 1
                    ? fila.Cells["Nombre"].Value.ToString().Split(' ')[1] : "";
                string telefono = fila.Cells["Telefono"].Value.ToString();
                int edad = Convert.ToInt32(fila.Cells["Edad"].Value);
                DateTime fechaNacimiento = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value);

                string grado = fila.Cells["Grado"].Value.ToString();
                int gradoId = Convert.ToInt32(fila.Cells["IdGrado"].Value);
                string seccion = fila.Cells["Seccion"].Value.ToString();
                int seccionId = Convert.ToInt32(fila.Cells["IdSeccion"].Value);

                EditarAlumnoForm editarForm = new EditarAlumnoForm(
                    id, usuario, nombre, apellido, telefono, edad,
                    fechaNacimiento, gradoId, seccionId
                );

                DialogResult result = editarForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    CargarAlumnos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un alumno de la lista para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlumnos.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridViewAlumnos.SelectedRows[0];
                int id = Convert.ToInt32(fila.Cells["Id"].Value);
                string nombre = fila.Cells["Nombre"].Value.ToString();


                DialogResult confirmacion = MessageBox.Show(
                    $"¿Estás seguro que deseas eliminar este alumno '{nombre}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    var controller = new AdminController();
                    bool eliminado = controller.EliminarAlumno(id);

                    if (eliminado)
                    {
                        MessageBox.Show("Alumno eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarAlumnos();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al eliminar el alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Seleccione un alumno de la lista para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
