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
    public partial class EditarTrimestreForm : Form
    {
        protected int IdTrimestre;
        protected string nombre;
        protected double nota;
        public EditarTrimestreForm(int id, string nombre, double nota)
        {
            InitializeComponent();
            this.IdTrimestre = id;
            txtId.Text = nombre;
            txtNombre.Text = nombre;
            txtNota.Text = nota.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarTrimestreForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El campo 'Nombre' es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    return;
                }

                txtNota.Text = txtNota.Text.Trim();
                if (string.IsNullOrEmpty(txtNota.Text))
                {
                    MessageBox.Show("El campo 'Nota mínima' es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNota.Focus();
                    return;
                }

                if (!double.TryParse(txtNota.Text, out double nota))
                {
                    MessageBox.Show("La nota mínima debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNota.Focus();
                    return;
                }

                if (nota < 0 || nota > 10)
                {
                    MessageBox.Show("La nota mínima debe estar entre 0 y 10.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNota.Focus();
                    return;
                }

                if (Decimal.Round((decimal)nota, 2) != (decimal)nota)
                {
                    MessageBox.Show("La nota mínima solo puede tener hasta dos decimales.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNota.Focus();
                    return;
                }

                AdminController controller = new AdminController();
                bool resultado = controller.EditarTrimestre(IdTrimestre, nombre, nota);

                if (resultado)
                {
                    MessageBox.Show("Trimestre editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo editar el trimestre. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
