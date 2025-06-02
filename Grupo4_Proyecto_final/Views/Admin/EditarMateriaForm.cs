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
    public partial class EditarMateriaForm : Form
    {
        private int idMateria;

        public EditarMateriaForm(int id, string nombre)
        {
            InitializeComponent();
            idMateria = id;
            txtId.Text = id.ToString();
            txtNombre.Text = nombre;

        }
        private void EditarMateriaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                string nombre = txtNombre.Text.Trim();


                AdminController controller = new AdminController();

                bool resultado = controller.EditarMateria(id, nombre);

                if (resultado)
                {
                    MessageBox.Show("Materia editada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo editar la materia. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
