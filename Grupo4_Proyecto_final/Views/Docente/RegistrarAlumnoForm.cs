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

namespace Grupo4_Proyecto_final.Views.Docente
{
    public partial class RegistrarAlumnoForm : Form
    {
        private int usuarioId;

        public RegistrarAlumnoForm(int IdUser, string user)
        {
            InitializeComponent();
            usuarioId = IdUser;
        }

        private void RegistrarAlumnoForm_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();


            var controller = new DocenteController();
            var docente = controller.ObtenerDocente(usuarioId);
            cmbGrado.Items.Clear();
            cmbGrado.Items.Add(docente.GradoNombre);
            cmbGrado.SelectedIndex = 0;

            cmbSeccion.Items.Clear();
            cmbSeccion.Items.Add(docente.SeccionNombre);
            cmbSeccion.SelectedIndex = 0;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar nombre
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El campo 'Nombre' es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    return;
                }

                // Validar apellido
                if (string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    MessageBox.Show("El campo 'Apellido' es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtApellido.Focus();
                    return;
                }

                // Validar teléfono
                if (string.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    MessageBox.Show("El campo 'Teléfono' es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTelefono.Focus();
                    return;
                }

                // Validar edad
                if (txtEdad.Value == 0)
                {
                    MessageBox.Show("Debe ingresar una edad válida (mayor que 0).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEdad.Focus();
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

                var controller = new DocenteController();
                var docente = controller.ObtenerDocente(usuarioId);
                int gradoId = docente.IdGrado;
                int seccionId = docente.IdSeccion;

                bool creado = controller.CrearAlumno(usuario, contrasenia, nombre, apellido, telefono, edad, fechaNacimiento, gradoId, seccionId);

                if (creado)
                {
                    string resumen = "Alumno creado con éxito:\n" +
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

        private void dtFechaNacimiento_Leave(object sender, EventArgs e)
        {

        }

        private void dtFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            GenerarUsuario();
        }
    }
}
