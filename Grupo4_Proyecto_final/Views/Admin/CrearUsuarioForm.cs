using Grupo4_Proyecto_final.Connection;
using Grupo4_Proyecto_final.Controllers;
using Grupo4_Proyecto_final.Models;
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
    public partial class CrearUsuarioForm : Form
    {
        private int childFormNumber = 0;

        public CrearUsuarioForm()
        {
            InitializeComponent();
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var roles = context.Rol.ToList();

                roles.Insert(0, new RolModel { id = 0, nombre = "Seleccione" });

                cmbRol.DataSource = roles;
                cmbRol.DisplayMember = "nombre";
                cmbRol.ValueMember = "id";
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    MessageBox.Show("El campo 'Usuario' es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtContrasenia.Text))
                {
                    MessageBox.Show("El campo 'Contraseña' es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContrasenia.Focus();
                    return;
                }

                if (cmbRol.SelectedIndex == 0 || cmbRol.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un rol válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbRol.Focus();
                    return;
                }


                string usuario = txtUsuario.Text;
                string contrasenia = txtContrasenia.Text;
                int rolId = Convert.ToInt32(cmbRol.SelectedValue);

                var controller = new AdminController();
                bool creado = controller.CrearUsuario(usuario, contrasenia, rolId);

                if (creado)
                {
                    MessageBox.Show("Usuario creado con éxito.");
                    txtUsuario.Text = "";
                    txtContrasenia.Text = "";
                    cmbRol.SelectedIndex = 0;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El usuario ya existe o ocurrió un error.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Seleccione un rol válido antes de guardar.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al crear el usuario:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
