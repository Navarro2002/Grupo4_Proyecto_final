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
        private int childFormNumber = 0;

        public ListadoAlumnosForm()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAsignarEvalucacion_Click(object sender, EventArgs e)
        {
            AsignarEvaluacionForm form = new AsignarEvaluacionForm();
            form.ShowDialog();
        }
    }
}
