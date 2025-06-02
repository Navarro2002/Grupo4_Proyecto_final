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
    public partial class GestionMateriasForm : Form
    {
        private List<MateriasListadoDTO> listaMaterias = new List<MateriasListadoDTO>();

        public GestionMateriasForm()
        {
            InitializeComponent();
            CargarMaterias();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CrearMateriasForm form = new CrearMateriasForm();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                CargarMaterias();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridMaterias.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridMaterias.SelectedRows[0];
                int id = Convert.ToInt32(fila.Cells["Id"].Value);
                string nombre = fila.Cells["Nombre"].Value.ToString();

                EditarMateriaForm editarForm = new EditarMateriaForm(id, nombre);

                DialogResult result = editarForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    CargarMaterias();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una materia de la lista para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void CargarMaterias()
        {
            AdminController controller = new AdminController();
            listaMaterias = controller.ListarMaterias();

            if (dataGridMaterias.Columns.Count == 0)
            {
                dataGridMaterias.Columns.Add("Id", "Id");
                dataGridMaterias.Columns.Add("Nombre", "Nombre");

            }

            MostrarMaterias(listaMaterias);
        }

        private void MostrarMaterias(List<MateriasListadoDTO> materia)
        {
            dataGridMaterias.Rows.Clear();

            foreach (var materias in materia)
            {
                dataGridMaterias.Rows.Add(
                    materias.Id,
                    materias.Nombre
                );
            }
        }
        private void GestionMateriasForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridMaterias.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridMaterias.SelectedRows[0];
                int id = Convert.ToInt32(fila.Cells["Id"].Value);
                string nombre = fila.Cells["Nombre"].Value.ToString();


                DialogResult confirmacion = MessageBox.Show(
                    $"¿Estás seguro que deseas eliminar la materia'{nombre}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    var controller = new AdminController();
                    bool eliminado = controller.EliminarMateria(id);

                    if (eliminado)
                    {
                        MessageBox.Show("Materia eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarMaterias();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al eliminar la materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string filtroTexto = txtNombre.Text.ToLower();

            var materiasFiltradas = listaMaterias
                .Where(m => m.Nombre.ToLower().Contains(filtroTexto))
                .ToList();

            MostrarMaterias(materiasFiltradas);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
        }

    }
}
