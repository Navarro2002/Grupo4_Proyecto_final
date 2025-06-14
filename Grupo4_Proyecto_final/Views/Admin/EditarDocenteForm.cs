﻿using Grupo4_Proyecto_final.Connection;
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
    public partial class EditarDocenteForm : Form
    {
        private int docenteId;
        private int gradoSeleccionadoId;
        private int seccionSeleccionadoId;
        public EditarDocenteForm(
            int id,
            string usuario,
            string nombres, string apellidos, string telefono, int edad, DateTime fechaNacimiento,
            int gradoId, int seccionId
            )
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

        private void EditarDocenteForm_Load(object sender, EventArgs e)
        {

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                DateTime fechaNacimiento = dtFechaNacimiento.Value;
                int edad = int.Parse(txtEdad.Text);
                int gradoId = (int)cmbGrado.SelectedValue;
                int seccionId = (int)cmbSeccion.SelectedValue;

                AdminController controller = new AdminController();

                bool resultado = controller.EditarDocente(id, nombre, apellido, telefono, edad, fechaNacimiento, gradoId, seccionId );

                if (resultado)
                {
                    MessageBox.Show("Docente editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo editar el docente. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
