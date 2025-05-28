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
    public partial class EditarDocenteForm : Form
    {
        private int docenteId;
        private int rolSeleccionadoId;
        public EditarDocenteForm(
            int id,
            string usuario,
            string nombres, string apellidos, string telefono, int edad, DateTime fechaNacimiento,
            int gradoId, int seccionId
            )
        {
            //txtUsuario.Text = usuario;
            txtNombre.Text = nombres;
            InitializeComponent();
        }

        private void EditarDocenteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
