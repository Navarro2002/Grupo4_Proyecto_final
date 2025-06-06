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
    public partial class CrearSeccionForm : Form
    {
        private int childFormNumber = 0;

        public CrearSeccionForm()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    txtNombre.Focus();
                    MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombre = txtNombre.Text;


                var controller = new AdminController();

                bool creado = controller.CrearSeccion(nombre);

                if (creado)
                {
                    string resumen = "Sección creada con éxito:\n" +
                                     $"Nombre: {nombre}";

                    MessageBox.Show(resumen, "Sección Creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("El alumno ya existe o ocurrió un error.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al crear la sección:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
