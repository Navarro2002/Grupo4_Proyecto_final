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
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Grupo4_Proyecto_final.Views.Docente
{
    public partial class AsignarEvaluacionForm : Form
    {
        private List<EvaluacionlistadoDTO> listaEvaluacion = new List<EvaluacionlistadoDTO>();
        public int idUser;
        public string user;
        public int idRol;
        public int idEstudiante;
        public AsignarEvaluacionForm(int idEstudiant, string nombreCompleto, int idUser, string user)
        {
            InitializeComponent();
            idEstudiante = idEstudiant;
            lblNombreAlumno.Text = nombreCompleto;
            CargarEvaluaciones();

        }

        private void AsignarEvaluaciónForm_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var materias = context.Materias.ToList();
                materias.Insert(0, new MateriaModel { Id = 0, Nombre = "Seleccione" });
                cmbMateria.DataSource = materias;
                cmbMateria.DisplayMember = "nombre";
                cmbMateria.ValueMember = "id";

                var trimestres = context.Trimestres.ToList();
                trimestres.Insert(0, new TrimestreModel { Id = 0, Trimestre = "Seleccione" });
                cmbTrimestre.DataSource = trimestres;
                cmbTrimestre.DisplayMember = "trimestre";
                cmbTrimestre.ValueMember = "id";

                var materiasBusq = context.Materias.ToList();
                materiasBusq.Insert(0, new MateriaModel { Id = 0, Nombre = "Seleccione" });
                cmbMateriaBusq.DataSource = materiasBusq;
                cmbMateriaBusq.DisplayMember = "nombre";
                cmbMateriaBusq.ValueMember = "id";

                var trimestresBusq = context.Trimestres.ToList();
                trimestresBusq.Insert(0, new TrimestreModel { Id = 0, Trimestre = "Seleccione" });
                cmbTrimestreBusq.DataSource = trimestresBusq;
                cmbTrimestreBusq.DisplayMember = "trimestre";
                cmbTrimestreBusq.ValueMember = "id";

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCalificacion.Clear();
            txtEvaluacion.Clear();
            cmbTrimestre.SelectedIndex = 0;
            cmbMateria.SelectedIndex = 0;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cmbMateria.Text))
                {
                    MessageBox.Show("Debe seleccionar una materia.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbMateria.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(cmbTrimestre.Text))
                {
                    MessageBox.Show("Debe seleccionar un trimestre.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbTrimestre.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCalificacion.Text))
                {
                    MessageBox.Show("El campo 'Calificación' es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCalificacion.Focus();
                    return;
                }

                if (!decimal.TryParse(txtCalificacion.Text, out decimal calificacion))
                {
                    MessageBox.Show("La calificación debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCalificacion.Focus();
                    return;
                }

                if (calificacion < 0 || calificacion > 10)
                {
                    MessageBox.Show("La calificación debe estar entre 0 y 10.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCalificacion.Focus();
                    return;
                }

                int materia = Convert.ToInt32(cmbMateria.SelectedValue); ;
                int trimestre = Convert.ToInt32(cmbTrimestre.SelectedValue); ;
                string nombreEvaluacion = txtEvaluacion.Text;

                var controller = new DocenteController();

                bool creado = controller.AsignarCalificacion(idEstudiante, materia, trimestre, (double)calificacion, nombreEvaluacion);
                
                if (creado)
                {
                    string resumen = "Calificación registrada con éxito:\n" +
                                     $"Calificación: {calificacion}\n" +
                                     $"Evaluación: {nombreEvaluacion}";

                    MessageBox.Show(resumen, "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEvaluaciones();
                }
                cmbMateria.SelectedIndex = 0;
                cmbTrimestre.SelectedIndex = 0;
                txtCalificacion.Clear();
                txtEvaluacion.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar la calificación:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtCalificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txtCalificacion.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtCalificacion_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtCalificacion.Text, out decimal valor))
            {
                if (valor > 10)
                {
                    MessageBox.Show("La calificacion no puede ser mayor que 10.");
                    txtCalificacion.Text = "10"; 
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
                txtCalificacion.Clear();
            }
        }

        private void CargarEvaluaciones()
        {

            int idMateria = Convert.ToInt32(cmbMateriaBusq.SelectedValue);
            int idTrimestre = Convert.ToInt32(cmbTrimestreBusq.SelectedValue);

            DocenteController controller = new DocenteController();
            listaEvaluacion = controller.ObtenerEvaluacionesPorAlumnoYMateria(idEstudiante, idMateria, idTrimestre);

            if (dataGridNotas.Columns.Count == 0)
            {
                dataGridNotas.Columns.Add("Evaluacion", "Evaluacion");
                dataGridNotas.Columns.Add("Materia", "Materia");
                dataGridNotas.Columns.Add("Trimestre", "Trimestre");
                dataGridNotas.Columns.Add("Calificacion", "Calificacion");
            }

            MostrarEvaluaciones(listaEvaluacion);
        }

        private void MostrarEvaluaciones(List<EvaluacionlistadoDTO> evaluaciones)
        {
            dataGridNotas.Rows.Clear();

            foreach (var evaluacion in evaluaciones)
            {
                dataGridNotas.Rows.Add(
                    evaluacion.Evaluacion,
                    evaluacion.Materia,
                    evaluacion.Trimestre,
                    evaluacion.Nota
                );
            }
        }

        private void cmbMateriaBusq_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMateriaBusq.SelectedIndex > 0 && cmbTrimestreBusq.SelectedIndex > 0)
                CargarEvaluaciones();
        }

        private void cmbTrimestreBusq_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMateriaBusq.SelectedIndex > 0 && cmbTrimestreBusq.SelectedIndex > 0)
                CargarEvaluaciones();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
