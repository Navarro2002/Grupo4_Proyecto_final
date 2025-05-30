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
    public partial class GestionSeccionForm : Form
    {
        private List<SeccionListadoDTO> listaSeccion = new List<SeccionListadoDTO>();

        public GestionSeccionForm()
        {
            InitializeComponent();
            CargarSecciones();
        }

        private void GestionSeccionForm_Load(object sender, EventArgs e)
        {

        }

        private void CargarSecciones()
        {
            AdminController controller = new AdminController();
            listaSeccion = controller.ListarSecciones();

            if (dataGridSecciones.Columns.Count == 0)
            {
                dataGridSecciones.Columns.Add("Id", "Id");
                dataGridSecciones.Columns.Add("Nombre", "Nombre");

            }

            MostrarSecciones(listaSeccion);
        }

        private void MostrarSecciones(List<SeccionListadoDTO> seccion)
        {
            dataGridSecciones.Rows.Clear();

            foreach (var secciones in seccion)
            {
                dataGridSecciones.Rows.Add(
                    secciones.Id,
                    secciones.Nombre
                );
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            string filtroTexto = txtNombre.Text.ToLower();

            var seccionesFiltrados = listaSeccion
                .Where(d => d.Nombre.ToLower().Contains(filtroTexto))
                .ToList();

            MostrarSecciones(seccionesFiltrados);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var form = new CrearSeccionForm();
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                CargarSecciones();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
