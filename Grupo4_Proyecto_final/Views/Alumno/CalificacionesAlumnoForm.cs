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

namespace Grupo4_Proyecto_final.Views.Alumno
{
    public partial class CalificacionesAlumnoForm : Form
    {
        private int childFormNumber = 0;
        private int idAlumno;
        private string nombreCompleto;
        public CalificacionesAlumnoForm(int idAlumno, string nombreAlumno)
        {
            InitializeComponent();
            this.idAlumno = idAlumno;
            this.nombreCompleto = nombreAlumno;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalificacionesAlumnoForm_Load(object sender, EventArgs e)
        {
            lblAlumno.Text = nombreCompleto;
            using (var context = new AppDbContext())
            {
                var trimestre = context.Trimestres.ToList();
                trimestre.Insert(0, new TrimestreModel { Id = 0, Trimestre = "Seleccione" });
                cmbTrimestre.DataSource = trimestre;
                cmbTrimestre.DisplayMember = "Trimestre";
                cmbTrimestre.ValueMember = "Id";

                var materia = context.Materias.ToList();
                materia.Insert(0, new MateriaModel { Id = 0, Nombre = "Seleccione" });
                cmbMateria.DataSource = materia;
                cmbMateria.DisplayMember = "Nombre";
                cmbMateria.ValueMember = "Id";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CargarEvaluaciones(int idAlumno)
        {
            AlumnoController controller = new AlumnoController();

            // Leer el id de materia seleccionado, si hay alguno
            int? trimestreId = null;
            if (cmbTrimestre.SelectedValue != null && int.TryParse(cmbTrimestre.SelectedValue.ToString(), out int idTrimestre) && idTrimestre != 0)
            {
                trimestreId = idTrimestre;
            }

            int? materiaId = null;
            if (cmbMateria.SelectedValue != null && int.TryParse(cmbMateria.SelectedValue.ToString(), out int idMateria) && idMateria != 0)
            {
                materiaId = idMateria;
            }
            // Trimestre fijo por ahora (1), puedes cambiarlo también a una variable
            List<EvaluacionlistadoDTO> promedios = controller.ListarEvaluaciones(idAlumno, materiaId, trimestreId);

            // Agregamos columnas si están vacías
            if (dataGridEvaluaciones.Columns.Count == 0)
            {

                dataGridEvaluaciones.Columns.Add("Evaluacion", "Evaluacion");
                dataGridEvaluaciones.Columns.Add("Trimestre", "Trimestre");
                dataGridEvaluaciones.Columns.Add("Materia", "Materia");
                dataGridEvaluaciones.Columns.Add("Nota", "Nota");
            }

            // Limpiamos filas
            dataGridEvaluaciones.Rows.Clear();

            // Cargamos los datos
            foreach (var promedio in promedios)
            {
                dataGridEvaluaciones.Rows.Add(promedio.Evaluacion, promedio.Trimestre, promedio.Materia, promedio.Nota.ToString("F2"));
            }
        }

        private void cmbTrimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarEvaluaciones(idAlumno);
        }

        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarEvaluaciones(idAlumno);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbMateria.SelectedIndex = 0;
            cmbTrimestre.SelectedIndex = 0;
        }
    }
}
