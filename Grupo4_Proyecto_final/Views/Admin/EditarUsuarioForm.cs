using Grupo4_Proyecto_final.Connection;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Grupo4_Proyecto_final.Views.Admin
{
    public partial class EditarUsuarioForm : Form
    {
        private int usuarioId;
        private int rolSeleccionadoId;
        public EditarUsuarioForm(int id, string usuario, string contrasenia, string rol, int rolId)
        {
            InitializeComponent();
            usuarioId = id;
            rolSeleccionadoId = rolId;
            txtId.Text = id.ToString();
            txtUsuario.Text = usuario;
            cmbRol.SelectedItem = rol;
            CargarRoles();
        }

        private void CargarRoles()
        {
            using (var context = new AppDbContext())
            {
                var roles = context.Rol
                    .Select(r => new { r.id, r.nombre })
                    .ToList();

                cmbRol.DataSource = roles;
                cmbRol.ValueMember = "id";
                cmbRol.DisplayMember = "nombre";

                cmbRol.SelectedValue = rolSeleccionadoId;
            }
        }

        private void EditarUsuarioForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                string usuario = txtUsuario.Text.Trim();
                int rolId = (int)cmbRol.SelectedValue;

                if (string.IsNullOrWhiteSpace(usuario))
                {
                    MessageBox.Show("El campo 'Usuario' es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Focus();
                    return;
                }

                if (cmbRol.SelectedIndex <= 0 || cmbRol.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un rol válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbRol.Focus();
                    return;
                }

                AdminController controller = new AdminController();

                bool resultado = controller.EditarUsuario(id, usuario, rolId);

                if (resultado)
                {
                    MessageBox.Show("Usuario editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo editar el usuario. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
