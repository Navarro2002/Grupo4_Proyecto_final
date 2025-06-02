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
    public partial class ActualizarContraForm : Form
    {
        private int childFormNumber = 0;

        public ActualizarContraForm()
        {
            InitializeComponent();
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarContraForm_Load(object sender, EventArgs e)
        {

        }
    }
}
