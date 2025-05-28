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
    public partial class GestionarDocenteForm : Form
    {
        private List<DocenteListadoDTO> listaDocente = new List<DocenteListadoDTO>();

        public GestionarDocenteForm()
        {
            InitializeComponent();
            CargarDocentes();
        }


        private void GestionarDocenteForm_Load(object sender, EventArgs e)
        {
            cmbGrado.SelectedIndexChanged += cmbGrado_SelectedIndexChanged;
            CargarDocentes();
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
        private void CargarDocentes()
        {
            AdminController controller = new AdminController();
            listaDocente = controller.ListarDocentes();

            if (dataGridViewDocentes.Columns.Count == 0)
            {
                dataGridViewDocentes.Columns.Add("Id", "Id");
                dataGridViewDocentes.Columns.Add("NombreCompleto", "NombreCompleto");
                dataGridViewDocentes.Columns.Add("Edad", "Edad");
                dataGridViewDocentes.Columns.Add("Telefono", "Telefono");
                dataGridViewDocentes.Columns.Add("FechaNacimiento", "FechaNacimiento");
                dataGridViewDocentes.Columns.Add("GradoNombre", "GradoNombre");
                dataGridViewDocentes.Columns.Add("IdGrado", "IdGrado");
                dataGridViewDocentes.Columns.Add("SeccionNombre", "SeccionNombre");
                dataGridViewDocentes.Columns.Add("IdSeccion", "IdSeccion");
                dataGridViewDocentes.Columns.Add("Usuario", "Usuario");

            }

            MostrarDocentes(listaDocente);
        }

        private void MostrarDocentes(List<DocenteListadoDTO> usuarios)
        {
            dataGridViewDocentes.Rows.Clear();

            foreach (var usuario in usuarios)
            {
                dataGridViewDocentes.Rows.Add(
                    usuario.Id,
                    usuario.NombreCompleto,
                    usuario.Edad,
                    usuario.Telefono,
                    usuario.FechaNacimiento,
                    usuario.GradoNombre,
                    usuario.IdGrado,
                    usuario.SeccionNombre,
                    usuario.IdSeccion,
                    usuario.Usuario
                );
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var form = new CrearDocenteForm();
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                CargarDocentes();
            }
        }

        private void txtDocenteBusq_TextChanged(object sender, EventArgs e)
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

            var usuariosFiltrados = listaDocente.Where(d =>
                (d.NombreCompleto.ToLower().Contains(filtroTexto) ||
                 d.GradoNombre.ToLower().Contains(filtroTexto)) &&
                (gradoSeleccionadoId == 0 || d.IdGrado == gradoSeleccionadoId)
            ).ToList();

            MostrarDocentes(usuariosFiltrados);
        }

        private void cmbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDocenteBusq.Text = "";
            cmbGrado.SelectedIndex = 0;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewDocentes.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridViewDocentes.SelectedRows[0];

                int id = Convert.ToInt32(fila.Cells["Id"].Value);
                string usuario = fila.Cells["Usuario"].Value.ToString();
                string nombre = fila.Cells["Nombre"].Value.ToString().Split(' ')[0];
                string apellido = fila.Cells["Nombre"].Value.ToString().Split(' ').Length > 1
                    ? fila.Cells["Nombre"].Value.ToString().Split(' ')[1] : ""; // Mismo campo
                string telefono = fila.Cells["Telefono"].Value.ToString();
                int edad = Convert.ToInt32(fila.Cells["Edad"].Value);
                DateTime fechaNacimiento = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value);

                string grado = fila.Cells["Grado"].Value.ToString();
                int gradoId = Convert.ToInt32(fila.Cells["IdGrado"].Value);
                string seccion = fila.Cells["Seccion"].Value.ToString();
                int seccionId = Convert.ToInt32(fila.Cells["IdSeccion"].Value);
                // Asume que tenés seccionId en tu modelo si querés usarlo

                EditarDocenteForm editarForm = new EditarDocenteForm(
                    id, usuario, nombre, apellido, telefono, edad,
                    fechaNacimiento, gradoId, seccionId
                );

                DialogResult result = editarForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    CargarDocentes();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un docente de la lista para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
