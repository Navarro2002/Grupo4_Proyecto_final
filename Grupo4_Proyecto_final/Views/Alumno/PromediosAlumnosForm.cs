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
    public partial class PromediosAlumnosForm : Form
    {
        private int childFormNumber = 0;
        private int idAlumno;
        private string nombreCompleto;
        public PromediosAlumnosForm(int idAlumno, string nombreAlumno)
        {
            InitializeComponent();
            this.idAlumno = idAlumno;
            this.nombreCompleto = nombreAlumno;
        }

        private void PromediosAlumnosForm_Load(object sender, EventArgs e)
        {
            lblAlumno.Text = nombreCompleto;
            CargarPromedios(idAlumno);
            CargarPromediosMaterias(idAlumno);
            using (var context = new AppDbContext())
            {
                var trimestre = context.Trimestres.ToList();

                trimestre.Insert(0, new TrimestreModel { Id = 0, Trimestre = "Seleccione" });

                cmbTrimestre.DataSource = trimestre;
                cmbTrimestre.DisplayMember = "trimestre";
                cmbTrimestre.ValueMember = "id";
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarPromedios(int idAlumno)
        {
            AlumnoController controller = new AlumnoController();
            List<PromedioTrimestreDTO> promedios = controller.ObtenerPromedioPorTrimestre(idAlumno);

            if (dataGridPromediosTrimestres.Columns.Count == 0)
            {
                dataGridPromediosTrimestres.Columns.Add("Trimestre", "Trimestre");
                dataGridPromediosTrimestres.Columns.Add("Promedio", "Promedio");
            }

            dataGridPromediosTrimestres.Rows.Clear();

            foreach (var promedio in promedios)
            {
                dataGridPromediosTrimestres.Rows.Add(promedio.Trimestre, promedio.Promedio.ToString("F2"));
            }
        }

        private void CargarPromediosMaterias(int idAlumno)
        {
            AlumnoController controller = new AlumnoController();

            int? trimestreId = null;
            if (cmbTrimestre.SelectedValue != null && int.TryParse(cmbTrimestre.SelectedValue.ToString(), out int idTrimestre) && idTrimestre != 0)
            {
                trimestreId = idTrimestre;
            }


            List<PromediosMateriasDTO> promedios = controller.ObtenerMateriasAprobadasReprobadas(idAlumno, trimestreId);

            if (dataGridProMaterias.Columns.Count == 0)
            {
                dataGridProMaterias.Columns.Add("Materia", "Materia");
                dataGridProMaterias.Columns.Add("Trimestre", "Trimestre");
                dataGridProMaterias.Columns.Add("Promedio", "Promedio");
                dataGridProMaterias.Columns.Add("Estado", "Estado");
            }

            dataGridProMaterias.Rows.Clear();

            foreach (var promedio in promedios)
            {
                dataGridProMaterias.Rows.Add(promedio.Materia, promedio.Trimestre, promedio.Promedio.ToString("F2"), promedio.Estado.ToString());
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbTrimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPromediosMaterias(idAlumno);

        }
    }
}
