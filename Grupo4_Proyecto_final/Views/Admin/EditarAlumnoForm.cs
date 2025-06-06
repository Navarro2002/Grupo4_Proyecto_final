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

namespace Grupo4_Proyecto_final.Views.Admin
{
    public partial class EditarAlumnoForm : Form
    {
        private int docenteId;
        private int gradoSeleccionadoId;
        private int seccionSeleccionadoId;
        public EditarAlumnoForm(int id,
            string usuario,
            string nombres, string apellidos, string telefono, int edad, DateTime fechaNacimiento,
            int gradoId, int seccionId)
        {
            InitializeComponent();
            txtNombre.Focus();
            docenteId = id;
            txtId.Text = id.ToString();
            txtUsuario.Text = usuario;
            txtNombre.Text = nombres;
            txtApellido.Text = apellidos;
            txtTelefono.Text = telefono;
            txtEdad.Text = edad.ToString();
            dtFechaNacimiento.Value = fechaNacimiento;
            CargarGrados();
            CargarSecciones();
            cmbGrado.SelectedValue = gradoId;
            cmbSeccion.SelectedValue = seccionId;
        }

        private void EditarAlumnoForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
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

                int id = int.Parse(txtId.Text);
                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                DateTime fechaNacimiento = dtFechaNacimiento.Value;
                int edad = int.Parse(txtEdad.Text);
                int gradoId = (int)cmbGrado.SelectedValue;
                int seccionId = (int)cmbSeccion.SelectedValue;

                AdminController controller = new AdminController();

                bool resultado = controller.EditarAlumno(id, nombre, apellido, telefono, edad, fechaNacimiento, gradoId, seccionId);

                if (resultado)
                {
                    MessageBox.Show("Alumno editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo editar el alumno. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrados()
        {
            using (var context = new AppDbContext())
            {
                var grados = context.Grados
                    .Select(g => new { g.Id, g.Nombre })
                    .ToList();

                cmbGrado.DataSource = grados;
                cmbGrado.ValueMember = "id";
                cmbGrado.DisplayMember = "nombre";

                cmbGrado.SelectedValue = gradoSeleccionadoId;
            }
        }

        private void CargarSecciones()
        {
            using (var context = new AppDbContext())
            {
                var secciones = context.Secciones
                    .Select(s => new { s.Id, s.Nombre })
                    .ToList();

                cmbSeccion.DataSource = secciones;
                cmbSeccion.ValueMember = "id";
                cmbSeccion.DisplayMember = "nombre";

                cmbSeccion.SelectedValue = seccionSeleccionadoId;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
