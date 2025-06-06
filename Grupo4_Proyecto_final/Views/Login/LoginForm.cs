using Grupo4_Proyecto_final.Controllers.Auth;
using Grupo4_Proyecto_final.Views.Admin;
using Grupo4_Proyecto_final.Views.Alumno;
using Grupo4_Proyecto_final.Views.Docente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo4_Proyecto_final.Views.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtUsuario.Focus();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var controller = new LoginController();
            var user = controller.Autenticar(txtUsuario.Text, txtContrasenia.Text);
            if (user != null)
            {
                MessageBox.Show($"Bienvenido {user.Usuario}, rol: {user.Rol.nombre}");
                if (user.Rol.nombre == "Administrador")
                {
                    HomeAdminForm formAdmin = new HomeAdminForm();
                    formAdmin.Show();
                }
                else if (user.Rol.nombre == "Docente")
                {
                    HomeDocenteForm formAdmin = new HomeDocenteForm(user.Id, user.Usuario, user.Rol.id);
                    formAdmin.Show();
                }
                else if (user.Rol.nombre == "Estudiante")
                {
                    HomeAlumnoForm formAdmin = new HomeAlumnoForm(user.Id, user.Usuario, user.Rol.id);
                    formAdmin.Show();
                }
            }
            else
            {
                MessageBox.Show("Credenciales inválidas");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContrasenia.Text = "";
            txtUsuario.Focus();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
