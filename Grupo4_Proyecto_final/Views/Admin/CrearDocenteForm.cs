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
    public partial class CrearDocenteForm : Form
    {
        private int childFormNumber = 0;

        public CrearDocenteForm()
        {
            InitializeComponent();
            txtNombre.Focus();
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            GenerarUsuario();
        }

        private void CrearDocenteForm_Load(object sender, EventArgs e)
        {
            GenerarUsuario();
            txtNombre.Focus();

            using (var context = new AppDbContext())
            {
                var grados = context.Grados.ToList();
                grados.Insert(0, new GradoModel { Id = 0, Nombre = "Seleccione" });
                cmbGrado.DataSource = grados;
                cmbGrado.DisplayMember = "nombre";
                cmbGrado.ValueMember = "id";

                var seccion = context.Secciones.ToList();
                seccion.Insert(0, new SeccionModel { Id = 0, Nombre = "Seleccione" });
                cmbSeccion.DataSource = seccion;
                cmbSeccion.DisplayMember = "nombre";
                cmbSeccion.ValueMember = "id";

            }

        }

        private void GenerarUsuario()
        {
            string nombres = txtNombre.Text.Trim();

            if (!string.IsNullOrWhiteSpace(nombres) && dtFechaNacimiento.Value != null)
            {
                string primerNombre = nombres.Split(' ')[0].ToLower();

                int anioNacimiento = dtFechaNacimiento.Value.Year;
                DateTime fechaNacimiento = dtFechaNacimiento.Value;
                int diaNacimiento = dtFechaNacimiento.Value.Day;

                txtUsuario.Text = $"{primerNombre}{diaNacimiento}{anioNacimiento}";
                txtContrasenia.Text = fechaNacimiento.ToString("ddMMyyyy");

            }
        }

        private void dtFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            GenerarUsuario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El campo 'Nombre' es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    MessageBox.Show("El campo 'Apellido' es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtApellido.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    MessageBox.Show("El campo 'Teléfono' es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTelefono.Focus();
                    return;
                }

                if (txtEdad.Value == 0)
                {
                    MessageBox.Show("La edad debe ser mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEdad.Focus();
                    return;
                }

                if (cmbGrado.SelectedIndex <= 0)
                {
                    MessageBox.Show("Seleccione un grado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbGrado.Focus();
                    return;
                }

                if (cmbSeccion.SelectedIndex <= 0)
                {
                    MessageBox.Show("Seleccione una sección.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbSeccion.Focus();
                    return;
                }


                string usuario = txtUsuario.Text;
                string contrasenia = txtContrasenia.Text;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string telefono = txtTelefono.Text;
                int edaddocente = (int)txtEdad.Value;
                DateTime fechaNacimiento = dtFechaNacimiento.Value;
                int gradoId = Convert.ToInt32(cmbGrado.SelectedValue);
                int seccionId = Convert.ToInt32(cmbSeccion.SelectedValue);

                var controller = new AdminController();

                bool creado = controller.CrearDocente(usuario, contrasenia, nombre, apellido, telefono, edaddocente, fechaNacimiento, gradoId, seccionId);

                if (creado)
                {
                    string resumen = "Docente creado con éxito:\n" +
                                     $"Usuario: {usuario}\n" +
                                     $"Contraseña: {contrasenia}\n" +
                                     $"Nombre: {nombre}\n";

                    MessageBox.Show(resumen, "Datos del usuario del docente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Text = "";
                    txtContrasenia.Text = "";
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtTelefono.Text = "";
                    txtEdad.Value = 0;
                    cmbGrado.SelectedIndex = 0;
                    cmbSeccion.SelectedIndex = 0;

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
    }
}
