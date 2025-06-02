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

        public CalificacionesAlumnoForm()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalificacionesAlumnoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
