namespace Grupo4_Proyecto_final.Views.Docente
{
    partial class HomeDocenteForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolTip = new ToolTip(components);
            panel1 = new Panel();
            btnCerrar = new Button();
            btnActualizarContraseña = new Button();
            lblSeccion = new Label();
            label6 = new Label();
            lblGrado = new Label();
            label5 = new Label();
            lbl = new Label();
            lblNombreDocente = new Label();
            lblUser = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnRegistrarAlumno = new Button();
            btnAlumnos = new Button();
            lblCantAlumnos = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnActualizarContraseña);
            panel1.Controls.Add(lblSeccion);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblGrado);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lbl);
            panel1.Controls.Add(lblNombreDocente);
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(lblCantAlumnos);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 460);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(255, 192, 192);
            btnCerrar.Location = new Point(489, 430);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 40;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnActualizarContraseña
            // 
            btnActualizarContraseña.BackColor = SystemColors.ActiveCaption;
            btnActualizarContraseña.Location = new Point(369, 105);
            btnActualizarContraseña.Name = "btnActualizarContraseña";
            btnActualizarContraseña.Size = new Size(177, 23);
            btnActualizarContraseña.TabIndex = 39;
            btnActualizarContraseña.Text = "Actualizar contraseña";
            btnActualizarContraseña.TextAlign = ContentAlignment.TopCenter;
            btnActualizarContraseña.UseVisualStyleBackColor = false;
            btnActualizarContraseña.Click += btnActualizarContraseña_Click;
            // 
            // lblSeccion
            // 
            lblSeccion.AutoSize = true;
            lblSeccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeccion.Location = new Point(420, 279);
            lblSeccion.Name = "lblSeccion";
            lblSeccion.Size = new Size(16, 21);
            lblSeccion.TabIndex = 33;
            lblSeccion.Text = "-";
            lblSeccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(351, 279);
            label6.Name = "label6";
            label6.Size = new Size(71, 21);
            label6.TabIndex = 32;
            label6.Text = "Sección:";
            // 
            // lblGrado
            // 
            lblGrado.AutoSize = true;
            lblGrado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrado.Location = new Point(104, 279);
            lblGrado.Name = "lblGrado";
            lblGrado.Size = new Size(16, 21);
            lblGrado.TabIndex = 31;
            lblGrado.Text = "-";
            lblGrado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 279);
            label5.Name = "label5";
            label5.Size = new Size(63, 21);
            label5.TabIndex = 30;
            label5.Text = "Grado: ";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(46, 173);
            lbl.Name = "lbl";
            lbl.Size = new Size(140, 21);
            lbl.TabIndex = 29;
            lbl.Text = "Nombre docente:";
            // 
            // lblNombreDocente
            // 
            lblNombreDocente.AutoSize = true;
            lblNombreDocente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreDocente.Location = new Point(188, 173);
            lblNombreDocente.Name = "lblNombreDocente";
            lblNombreDocente.Size = new Size(136, 21);
            lblNombreDocente.TabIndex = 28;
            lblNombreDocente.Text = "Nombre docente";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblUser.Location = new Point(483, 85);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(40, 17);
            lblUser.TabIndex = 27;
            lblUser.Text = "User1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(427, 85);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 24;
            label2.Text = "Usuario:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrarAlumno);
            groupBox1.Controls.Add(btnAlumnos);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(46, 323);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 89);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Administración";
            // 
            // btnRegistrarAlumno
            // 
            btnRegistrarAlumno.BackColor = Color.FromArgb(224, 224, 224);
            btnRegistrarAlumno.Location = new Point(233, 35);
            btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            btnRegistrarAlumno.RightToLeft = RightToLeft.Yes;
            btnRegistrarAlumno.Size = new Size(146, 37);
            btnRegistrarAlumno.TabIndex = 13;
            btnRegistrarAlumno.Text = "Registrar alumno";
            btnRegistrarAlumno.UseVisualStyleBackColor = false;
            btnRegistrarAlumno.Click += btnRegistrarAlumno_Click;
            // 
            // btnAlumnos
            // 
            btnAlumnos.BackColor = Color.FromArgb(224, 224, 224);
            btnAlumnos.Location = new Point(15, 35);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(173, 37);
            btnAlumnos.TabIndex = 12;
            btnAlumnos.Text = "Administrar Evaluaciones";
            btnAlumnos.UseVisualStyleBackColor = false;
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // lblCantAlumnos
            // 
            lblCantAlumnos.AutoSize = true;
            lblCantAlumnos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantAlumnos.Location = new Point(217, 226);
            lblCantAlumnos.Name = "lblCantAlumnos";
            lblCantAlumnos.Size = new Size(16, 21);
            lblCantAlumnos.TabIndex = 20;
            lblCantAlumnos.Text = "-";
            lblCantAlumnos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 226);
            label4.Name = "label4";
            label4.Size = new Size(165, 21);
            label4.TabIndex = 18;
            label4.Text = "Alumnos registrados:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_;
            pictureBox1.Location = new Point(46, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 20);
            label1.Name = "label1";
            label1.Size = new Size(262, 30);
            label1.TabIndex = 16;
            label1.Text = "Colegio Anders Hejlsberg";
            // 
            // HomeDocenteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 460);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "HomeDocenteForm";
            Text = "Home Docente";
            Load += HomeDocenteForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button btnAlumnos;
        private Label lblCantAlumnos;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnRegistrarAlumno;
        private Label lblUser;
        private Label lblNombreDocente;
        private Label lbl;
        private Label lblSeccion;
        private Label label6;
        private Label lblGrado;
        private Label label5;
        private Button btnActualizarContraseña;
        private Button btnCerrar;
    }
}



