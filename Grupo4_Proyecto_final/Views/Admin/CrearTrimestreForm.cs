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
    public partial class CrearTrimestreForm : Form
    {
        public CrearTrimestreForm()
        {
            InitializeComponent();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

            txtNota.Text = txtNota.Text.Trim();
            if (string.IsNullOrEmpty(txtNota.Text))
            {
                txtNota.Focus();
                MessageBox.Show("La nota mínima es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtNota.Text, out double nota))
            {
                txtNota.Focus();
                MessageBox.Show("La nota mínima debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nota < 0 || nota > 10)
            {
                txtNota.Focus();
                MessageBox.Show("La nota mínima debe estar entre 0 y 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string nombre = txtNombre.Text;
                var controller = new AdminController();

                bool creado = controller.CrearTrimestre(nombre, nota);

                if (creado)
                {
                    string resumen = "Trimestre creado con éxito:\n" +
                                     $"Nombre: {nombre}";

                    MessageBox.Show(resumen, "Trimestre Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("El trimestre ya existe o ocurrió un error.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al crear el trimeste:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
