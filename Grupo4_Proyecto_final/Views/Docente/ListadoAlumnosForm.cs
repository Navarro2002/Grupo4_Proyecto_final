using Grupo4_Proyecto_final.Controllers;
using Grupo4_Proyecto_final.Models.DTOs;
using Grupo4_Proyecto_final.Views.Admin;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ListadoAlumnosForm : Form
    {
        private List<AlumnoListadoDTO> listaAlumno = new List<AlumnoListadoDTO>();
        public int idUser;
        public string user;
        public int idRol;
        public ListadoAlumnosForm(int id, string user, int idRol)
        {
            InitializeComponent();
            this.user = user;
            this.idUser = id;
            this.idRol = idRol;
            CargarAlumnos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAsignarEvalucacion_Click(object sender, EventArgs e)
        {
            var controller = new DocenteController();
            var docente = controller.ObtenerDocente(idUser);

            if (dataGridViewAlumnos.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridViewAlumnos.SelectedRows[0];
                int idAlumno = Convert.ToInt32(fila.Cells["Id"].Value);
                string nombreAlumno = fila.Cells["Nombre"].Value.ToString();


                AsignarEvaluacionForm editarForm = new AsignarEvaluacionForm(idAlumno, nombreAlumno, idUser, user);

                DialogResult result = editarForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    CargarAlumnos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione el alumno al que le asignara la calificación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ListadoAlumnosForm_Load(object sender, EventArgs e)
        {
         
        }

        private void CargarAlumnos()
        {
            DocenteController controller = new DocenteController();
            var docente = controller.ObtenerDocente(idUser);
            if (docente == null)
            {
                MessageBox.Show("No se pudo obtener la información del docente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var idGrado = docente.IdGrado;
            var idSeccion = docente.IdSeccion;
            listaAlumno = controller.ListarAlumnos(idGrado, idSeccion);

            if (dataGridViewAlumnos.Columns.Count == 0)
            {
                dataGridViewAlumnos.Columns.Add("Id", "Id");
                dataGridViewAlumnos.Columns.Add("NombreCompleto", "NombreCompleto");
                dataGridViewAlumnos.Columns.Add("Edad", "Edad");
                dataGridViewAlumnos.Columns.Add("Telefono", "Telefono");
                dataGridViewAlumnos.Columns.Add("FechaNacimiento", "FechaNacimiento");
                dataGridViewAlumnos.Columns.Add("GradoNombre", "GradoNombre");
                dataGridViewAlumnos.Columns.Add("IdGrado", "IdGrado");
                dataGridViewAlumnos.Columns.Add("SeccionNombre", "SeccionNombre");
                dataGridViewAlumnos.Columns.Add("IdSeccion", "IdSeccion");
                dataGridViewAlumnos.Columns.Add("Promedio", "Promedio");

            }

            MostrarAlumnos(listaAlumno);
        }

        private void MostrarAlumnos(List<AlumnoListadoDTO> alumnos)
        {
            dataGridViewAlumnos.Rows.Clear();

            foreach (var alumno in alumnos)
            {
                dataGridViewAlumnos.Rows.Add(
                    alumno.Id,
                    alumno.NombreCompleto,
                    alumno.Edad,
                    alumno.Telefono,
                    alumno.FechaNacimiento,
                    alumno.GradoNombre,
                    alumno.IdGrado,
                    alumno.SeccionNombre,
                    alumno.IdSeccion,
                    alumno.Promedio
                );
            }
        }

        private void txtDocenteBusq_TextChanged(object sender, EventArgs e)
        {
            string filtroTexto = txtNombre.Text.ToLower();

            var materiasFiltradas = listaAlumno
                .Where(m => m.NombreCompleto.ToLower().Contains(filtroTexto))
                .ToList();

            MostrarAlumnos(materiasFiltradas);
        }
    }
}
