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
    public partial class CrearGradosForm : Form
    {

        public CrearGradosForm()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            txtNombre.Text = txtNombre.Text.Trim();
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.Focus();
                MessageBox.Show("El nombre del grado es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string nombre = txtNombre.Text;
                var controller = new AdminController();

                bool creado = controller.CrearGrado(nombre);

                if (creado)
                {
                    string resumen = "Grado creado con éxito:\n" +
                                     $"Nombre: {nombre}";

                    MessageBox.Show(resumen, "Grado Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("El grado ya existe o ocurrió un error.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al crear el grado:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearGradosForm_Load(object sender, EventArgs e)
        {

        }
    }
}
