using Grupo4_Proyecto_final.Controllers;
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
            CargarPromedios(idAlumno) ; // llama con el ID real

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarPromedios(int idAlumno)
        {
            AlumnoController controller = new AlumnoController();
            List<PromedioTrimestreDTO> promedios = controller.ObtenerPromedioPorTrimestre(idAlumno);

            // Agregamos columnas si están vacías
            if (dataGridPromediosTrimestres.Columns.Count == 0)
            {
                dataGridPromediosTrimestres.Columns.Add("Trimestre", "Trimestre");
                dataGridPromediosTrimestres.Columns.Add("Promedio", "Promedio");
            }

            // Limpiamos filas
            dataGridPromediosTrimestres.Rows.Clear();

            // Cargamos los datos
            foreach (var promedio in promedios)
            {
                dataGridPromediosTrimestres.Rows.Add(promedio.Trimestre, promedio.Promedio);
            }
        }

    }
}
