﻿namespace Grupo4_Proyecto_final.Views.Alumno
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
            lblSeccion = new Label();
            label6 = new Label();
            lblGrado = new Label();
            label4 = new Label();
            lblAlumno = new Label();
            btnSalir = new Button();
            btnActualizarContraseña = new Button();
            lblUser = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnVerPromedios = new Button();
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
            lblNombreAlumno.Location = new Point(36, 191);
            lblNombreAlumno.Name = "lblNombreAlumno";
            lblNombreAlumno.Size = new Size(163, 21);
            lblNombreAlumno.TabIndex = 37;
            lblNombreAlumno.Text = "Nombre del Alumno:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(lblSeccion);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblGrado);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblAlumno);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnActualizarContraseña);
            panel1.Controls.Add(lblNombreAlumno);
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 500);
            panel1.TabIndex = 4;
            // 
            // lblSeccion
            // 
            lblSeccion.AutoSize = true;
            lblSeccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeccion.Location = new Point(447, 260);
            lblSeccion.Name = "lblSeccion";
            lblSeccion.Size = new Size(16, 21);
            lblSeccion.TabIndex = 44;
            lblSeccion.Text = "-";
            lblSeccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(378, 260);
            label6.Name = "label6";
            label6.Size = new Size(71, 21);
            label6.TabIndex = 43;
            label6.Text = "Sección:";
            // 
            // lblGrado
            // 
            lblGrado.AutoSize = true;
            lblGrado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrado.Location = new Point(131, 260);
            lblGrado.Name = "lblGrado";
            lblGrado.Size = new Size(16, 21);
            lblGrado.TabIndex = 42;
            lblGrado.Text = "-";
            lblGrado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(73, 260);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 41;
            label4.Text = "Grado: ";
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlumno.Location = new Point(205, 191);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(79, 21);
            lblAlumno.TabIndex = 40;
            lblAlumno.Text = "ALUMNO";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 192, 192);
            btnSalir.Location = new Point(501, 459);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(56, 29);
            btnSalir.TabIndex = 39;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnActualizarContraseña
            // 
            btnActualizarContraseña.BackColor = SystemColors.ActiveCaption;
            btnActualizarContraseña.Location = new Point(345, 339);
            btnActualizarContraseña.Name = "btnActualizarContraseña";
            btnActualizarContraseña.Size = new Size(177, 23);
            btnActualizarContraseña.TabIndex = 38;
            btnActualizarContraseña.Text = "Actualizar contraseña";
            btnActualizarContraseña.TextAlign = ContentAlignment.TopCenter;
            btnActualizarContraseña.UseVisualStyleBackColor = false;
            btnActualizarContraseña.Click += btnActualizarContraseña_Click;
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
            groupBox1.Controls.Add(btnVerPromedios);
            groupBox1.Controls.Add(btnRegistrarAlumno);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(49, 391);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 85);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calificaciones";
            // 
            // btnVerPromedios
            // 
            btnVerPromedios.BackColor = Color.FromArgb(224, 224, 224);
            btnVerPromedios.Location = new Point(201, 24);
            btnVerPromedios.Name = "btnVerPromedios";
            btnVerPromedios.RightToLeft = RightToLeft.Yes;
            btnVerPromedios.Size = new Size(146, 37);
            btnVerPromedios.TabIndex = 14;
            btnVerPromedios.Text = "Ver Promedios";
            btnVerPromedios.UseVisualStyleBackColor = false;
            btnVerPromedios.Click += btnVerPromedios_Click;
            // 
            // btnRegistrarAlumno
            // 
            btnRegistrarAlumno.BackColor = Color.FromArgb(224, 224, 224);
            btnRegistrarAlumno.Location = new Point(23, 26);
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
            ClientSize = new Size(569, 500);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "HomeAlumnoForm";
            Text = "Home Alumno ";
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
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnRegistrarAlumno;
        private Button btnActualizarContraseña;
        private Button btnSalir;
        private Button btnVerPromedios;
        private Label lblAlumno;
        private Label lblSeccion;
        private Label label6;
        private Label lblGrado;
        private Label label4;
    }
}



