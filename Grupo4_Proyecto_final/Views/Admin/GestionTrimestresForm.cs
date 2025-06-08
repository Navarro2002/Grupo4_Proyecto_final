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
    public partial class GestionTrimestresForm : Form
    {
        private List<TrimestresListadoDTO> listaTrimestres = new List<TrimestresListadoDTO>();

        public GestionTrimestresForm()
        {
            InitializeComponent();
            CargarTrimestres();
        }

        private void GestionTrimestresForm_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarTrimestres()
        {
            AdminController controller = new AdminController();
            listaTrimestres = controller.ListarTrimestres();

            if (dataGridTrimestres.Columns.Count == 0)
            {
                dataGridTrimestres.Columns.Add("Id", "Id");
                dataGridTrimestres.Columns.Add("Nombre", "Nombre");
                dataGridTrimestres.Columns.Add("NotaMinina", "NotaMinina");
            }

            MostrarGrados(listaTrimestres);
        }

        private void MostrarGrados(List<TrimestresListadoDTO> trimestre)
        {
            dataGridTrimestres.Rows.Clear();

            foreach (var trimestres in trimestre)
            {
                dataGridTrimestres.Rows.Add(
                    trimestres.Id,
                    trimestres.Trimestre,
                    trimestres.NotaMinima
                );
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string filtroTexto = txtNombre.Text.ToLower();

            var gradosFiltradas = listaTrimestres
                .Where(t => t.Trimestre.ToLower().Contains(filtroTexto))
                .ToList();

            MostrarGrados(gradosFiltradas);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CrearTrimestreForm form = new CrearTrimestreForm();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                CargarTrimestres();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridTrimestres.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridTrimestres.SelectedRows[0];
                int id = Convert.ToInt32(fila.Cells["Id"].Value);
                string nombre = fila.Cells["Nombre"].Value.ToString();
                double nota = Convert.ToDouble(fila.Cells["NotaMinina"].Value);

                EditarTrimestreForm editarForm = new EditarTrimestreForm(id, nombre, nota);

                DialogResult result = editarForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    CargarTrimestres();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un trimestre de la lista para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridTrimestres.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridTrimestres.SelectedRows[0];
                int id = Convert.ToInt32(fila.Cells["Id"].Value);
                string nombre = fila.Cells["Nombre"].Value.ToString();


                DialogResult confirmacion = MessageBox.Show(
                    $"¿Estás seguro que deseas eliminar el trimestre'{nombre}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    var controller = new AdminController();
                    bool eliminado = controller.EliminarTrimestre(id);

                    if (eliminado)
                    {
                        MessageBox.Show("Trimestre eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarTrimestres();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al eliminar el trimetre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un trimestre de la lista para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            }
        }
}
