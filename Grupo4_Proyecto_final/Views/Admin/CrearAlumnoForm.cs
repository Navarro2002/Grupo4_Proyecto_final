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
    public partial class CrearAlumnoForm : Form
    {
        private int childFormNumber = 0;

        public CrearAlumnoForm()
        {
            InitializeComponent();
        }

        private void CrearAlumnoForm_Load(object sender, EventArgs e)
        {
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos
                if (
                    string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                    string.IsNullOrWhiteSpace(txtContrasenia.Text) ||
                    string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                    txtEdad.Value == 0 ||
                    cmbGrado.SelectedIndex <= 0 ||
                    cmbSeccion.SelectedIndex <= 0
                )
                {
                    MessageBox.Show("Por favor complete todos los campos correctamente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Captura de datos
                string usuario = txtUsuario.Text;
                string contrasenia = txtContrasenia.Text;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string telefono = txtTelefono.Text;
                int edad = (int)txtEdad.Value;
                DateTime fechaNacimiento = dtFechaNacimiento.Value;
                int gradoId = Convert.ToInt32(cmbGrado.SelectedValue);
                int seccionId = Convert.ToInt32(cmbSeccion.SelectedValue);

                // Crear usuario
                var controller = new AdminController();

                bool creado = controller.CrearAlumno(usuario, contrasenia, nombre, apellido, telefono, edad, fechaNacimiento, gradoId, seccionId);

                if (creado)
                {
                    string resumen = "Docente creado con éxito:\n" +
                                     $"Usuario: {usuario}\n" +
                                     $"Contraseña: {contrasenia}\n" +
                                     $"Nombre: {nombre}\n";

                    MessageBox.Show(resumen, "Datos del usuario del alumno", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("El alumno ya existe o ocurrió un error.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al crear el alumno:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            GenerarUsuario();
        }

        private void dtFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            GenerarUsuario();
        }
    }
}
