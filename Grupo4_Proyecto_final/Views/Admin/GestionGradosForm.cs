using Grupo4_Proyecto_final.Controllers;
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
    public partial class GestionGradosForm : Form
    {
        private List<GradosListadoDTO> listaGrados = new List<GradosListadoDTO>();

        public GestionGradosForm()
        {
            InitializeComponent();
            CargarGrados();
        }


        private void GestionGradosForm_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarGrados()
        {
            AdminController controller = new AdminController();
            listaGrados = controller.ListarGrados();

            if (dataGridGrados.Columns.Count == 0)
            {
                dataGridGrados.Columns.Add("Id", "Id");
                dataGridGrados.Columns.Add("Nombre", "Nombre");

            }

            MostrarGrados(listaGrados);
        }

        private void MostrarGrados(List<GradosListadoDTO> grado)
        {
            dataGridGrados.Rows.Clear();

            foreach (var grados in grado)
            {
                dataGridGrados.Rows.Add(
                    grados.Id,
                    grados.Nombre
                );
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string filtroTexto = txtNombre.Text.ToLower();

            var gradosFiltradas = listaGrados
                .Where(m => m.Nombre.ToLower().Contains(filtroTexto))
                .ToList();

            MostrarGrados(gradosFiltradas);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var form = new CrearGradosForm();
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                CargarGrados();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridGrados.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridGrados.SelectedRows[0];
                int id = Convert.ToInt32(fila.Cells["Id"].Value);
                string nombre = fila.Cells["Nombre"].Value.ToString();

                EditarGradoForm editarForm = new EditarGradoForm(id, nombre);

                DialogResult result = editarForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    CargarGrados();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un grado de la lista para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridGrados.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridGrados.SelectedRows[0];
                int id = Convert.ToInt32(fila.Cells["Id"].Value);
                string nombre = fila.Cells["Nombre"].Value.ToString();


                DialogResult confirmacion = MessageBox.Show(
                    $"¿Estás seguro que deseas eliminar el grado'{nombre}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    var controller = new AdminController();
                    bool eliminado = controller.EliminarGrado(id);

                    if (eliminado)
                    {
                        MessageBox.Show("Grado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrados();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al eliminar el grado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un grado de la lista para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
