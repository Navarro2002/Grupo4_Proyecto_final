using Grupo4_Proyecto_final.Connection;
using Grupo4_Proyecto_final.Controllers;
using Grupo4_Proyecto_final.Models;
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
    public partial class GestionAdminForm : Form
    {
        private List<UsuarioListadoDTO> listaUsuarios = new List<UsuarioListadoDTO>();

        public GestionAdminForm()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void GestionAdminForm_Load(object sender, EventArgs e)
        {
            cmbRolBusq.SelectedIndexChanged += cmbRolBusq_SelectedIndexChanged;
            CargarUsuarios();
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            using (var context = new AppDbContext())
            {
                var roles = context.Rol.ToList();

                roles.Insert(0, new RolModel { id = 0, nombre = "Seleccione" });

                // Asignar al ComboBox
                cmbRolBusq.DataSource = roles;
                cmbRolBusq.DisplayMember = "nombre";
                cmbRolBusq.ValueMember = "id";
            }
        }

        private void CargarUsuarios()
        {
            AdminController controller = new AdminController();
            listaUsuarios = controller.ListarUsuarios();

            if (dataGridViewUsuarios.Columns.Count == 0)
            {
                dataGridViewUsuarios.Columns.Add("Id", "ID");
                dataGridViewUsuarios.Columns.Add("UsuarioLogin", "Usuario");
                dataGridViewUsuarios.Columns.Add("Contrasenia", "Contrasenia");
                dataGridViewUsuarios.Columns.Add("RolAsignado", "Rol");
                dataGridViewUsuarios.Columns.Add("RolId", "RolId");
                dataGridViewUsuarios.Columns["RolId"].Visible = false;
            }

            MostrarUsuarios(listaUsuarios);
        }

        private void MostrarUsuarios(List<UsuarioListadoDTO> usuarios)
        {
            dataGridViewUsuarios.Rows.Clear();

            foreach (var usuario in usuarios)
            {
                dataGridViewUsuarios.Rows.Add(
                    usuario.Id,
                    usuario.UsuarioLogin,
                    usuario.Contrasenia,
                    usuario.RolAsignado,
                    usuario.RolId
                );
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var form = new CrearUsuarioForm();
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                CargarUsuarios();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AplicarFiltros()
        {
            string filtroTexto = txtUsuarioBusq.Text.ToLower();

            int rolSeleccionadoId = 0;

            if (cmbRolBusq.SelectedValue != null && int.TryParse(cmbRolBusq.SelectedValue.ToString(), out int valor))
            {
                rolSeleccionadoId = valor;
            }

            var usuariosFiltrados = listaUsuarios.Where(u =>
                (u.UsuarioLogin.ToLower().Contains(filtroTexto) ||
                 u.RolAsignado.ToLower().Contains(filtroTexto)) &&
                (rolSeleccionadoId == 0 || u.RolId == rolSeleccionadoId)
            ).ToList();

            MostrarUsuarios(usuariosFiltrados);
        }

        private void txtUsuarioBusq_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void cmbRolBusq_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuarioBusq.Text = "";
            cmbRolBusq.SelectedIndex = 0;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridViewUsuarios.SelectedRows[0];
                int id = Convert.ToInt32(fila.Cells["Id"].Value);
                string usuario = fila.Cells["Usuario"].Value.ToString();
                string contrasenia = fila.Cells["Contraseña"].Value.ToString();
                string rol = fila.Cells["Rol"].Value.ToString();
                int rolId = Convert.ToInt32(fila.Cells["RolId"].Value);


                EditarUsuarioForm editarForm = new EditarUsuarioForm(id, usuario, contrasenia, rol, rolId);

                DialogResult result = editarForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    CargarUsuarios();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario de la lista para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridViewUsuarios.SelectedRows[0];
                int id = Convert.ToInt32(fila.Cells["Id"].Value);
                string nombreUsuario = fila.Cells["Usuario"].Value.ToString();


                DialogResult confirmacion = MessageBox.Show(
                    $"¿Estás seguro que deseas eliminar al usuario '{nombreUsuario}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    var controller = new AdminController();
                    bool eliminado = controller.EliminarUsuario(id);

                    if (eliminado)
                    {
                        MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Seleccione un usuario de la lista para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
