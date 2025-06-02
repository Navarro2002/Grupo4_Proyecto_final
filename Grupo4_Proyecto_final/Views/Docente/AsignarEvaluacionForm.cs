using Grupo4_Proyecto_final.Connection;
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
    public partial class AsignarEvaluacionForm : Form
    {
        public int idUser;
        public string user;
        public int idRol;
        public AsignarEvaluacionForm(int idEstudiante, string nombreCompleto, int idUser, string user)
        {
            InitializeComponent();
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
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
