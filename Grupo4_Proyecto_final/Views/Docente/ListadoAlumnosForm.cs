using Grupo4_Proyecto_final.Controllers;
using Grupo4_Proyecto_final.Models.DTOs;
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

            //AsignarEvaluacionForm form = new AsignarEvaluacionForm();
            form.ShowDialog();
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
                dataGridViewAlumnos.Columns.Add("Usuario", "Usuario");

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
                    alumno.Usuario
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
