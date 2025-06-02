namespace Grupo4_Proyecto_final.Views.Alumno
{
    partial class HomeAlumnoForm
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
            Label lblNombreAlumno;
            toolTip = new ToolTip(components);
            panel1 = new Panel();
            btnSalir = new Button();
            btnActualizarContraseña = new Button();
            lblUser = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnRegistrarAlumno = new Button();
            lblNombreAlumno = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombreAlumno
            // 
            lblNombreAlumno.AutoSize = true;
            lblNombreAlumno.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreAlumno.Location = new Point(36, 223);
            lblNombreAlumno.Name = "lblNombreAlumno";
            lblNombreAlumno.Size = new Size(159, 21);
            lblNombreAlumno.TabIndex = 37;
            lblNombreAlumno.Text = "Nombre del Alumno";
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnActualizarContraseña);
            panel1.Controls.Add(lblNombreAlumno);
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 475);
            panel1.TabIndex = 4;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 192, 192);
            btnSalir.Location = new Point(443, 414);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 39;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnActualizarContraseña
            // 
            btnActualizarContraseña.BackColor = SystemColors.ActiveCaption;
            btnActualizarContraseña.Location = new Point(366, 322);
            btnActualizarContraseña.Name = "btnActualizarContraseña";
            btnActualizarContraseña.Size = new Size(177, 23);
            btnActualizarContraseña.TabIndex = 38;
            btnActualizarContraseña.Text = "Actualizar contraseña";
            btnActualizarContraseña.TextAlign = ContentAlignment.TopCenter;
            btnActualizarContraseña.UseVisualStyleBackColor = false;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(487, 83);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(36, 15);
            lblUser.TabIndex = 36;
            lblUser.Text = "User1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_;
            pictureBox1.Location = new Point(30, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(185, 275);
            label3.Name = "label3";
            label3.Size = new Size(16, 21);
            label3.TabIndex = 35;
            label3.Text = "-";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 25);
            label1.Name = "label1";
            label1.Size = new Size(262, 30);
            label1.TabIndex = 28;
            label1.Text = "Colegio Anders Hejlsberg";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 275);
            label5.Name = "label5";
            label5.Size = new Size(142, 21);
            label5.TabIndex = 34;
            label5.Text = "Cantidad Materias";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(440, 83);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 33;
            label2.Text = "Usuario:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrarAlumno);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(30, 374);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(188, 89);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calificaciones";
            // 
            // btnRegistrarAlumno
            // 
            btnRegistrarAlumno.BackColor = Color.FromArgb(192, 255, 192);
            btnRegistrarAlumno.Location = new Point(19, 24);
            btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            btnRegistrarAlumno.RightToLeft = RightToLeft.Yes;
            btnRegistrarAlumno.Size = new Size(146, 37);
            btnRegistrarAlumno.TabIndex = 13;
            btnRegistrarAlumno.Text = "Ver Calificaciones";
            btnRegistrarAlumno.UseVisualStyleBackColor = false;
            btnRegistrarAlumno.Click += btnRegistrarAlumno_Click;
            // 
            // HomeAlumnoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 475);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "HomeAlumnoForm";
            Text = "HomeAlumnoForm";
            Load += HomeAlumnoForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private Panel panel1;
        private Label lblUser;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label1;
        private Label label5;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnRegistrarAlumno;
        private Button btnActualizarContraseña;
        private Button btnSalir;
    }
}



