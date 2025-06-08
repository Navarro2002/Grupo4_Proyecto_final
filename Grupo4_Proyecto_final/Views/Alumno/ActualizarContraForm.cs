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

namespace Grupo4_Proyecto_final.Views.Alumno
{
    public partial class ActualizarContraForm : Form
    {
        public int idUser;
        public string user;

        public ActualizarContraForm(int idUser, string user)
        {
            InitializeComponent();
            this.idUser = idUser;
            this.user = user;
        }
        private void ActualizarContraForm_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = user;
        }

        private void txtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtContrasenia.Text))
                {
                    MessageBox.Show("Ingrese la nueva contraseña por favor", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string contrasenia = txtContrasenia.Text;

                var controller = new AlumnoController();
                bool creado = controller.ActualizarContresenia(idUser, contrasenia);

                if (creado)
                {
                    MessageBox.Show($"Contraseña actualizada correctamente.\nContraseña nueva: {contrasenia}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtContrasenia.Text = "";
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar .a contraseña:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
