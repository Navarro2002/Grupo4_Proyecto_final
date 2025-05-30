using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo4_Proyecto_final.Views.Admin
{
    public partial class GestionMateriasForm : Form
    {
        private int childFormNumber = 0;

        public GestionMateriasForm()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CrearMateriasForm form = new CrearMateriasForm();
            form.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarMateriaForm form = new EditarMateriaForm();
            form.Show();
        }
    }
}
