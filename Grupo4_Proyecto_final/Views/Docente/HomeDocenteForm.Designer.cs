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
            lblUser = new Label();
            label3 = new Label();
            label5 = new Label();
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
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(lblCantAlumnos);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(611, 485);
            panel1.TabIndex = 4;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(503, 78);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(36, 15);
            lblUser.TabIndex = 27;
            lblUser.Text = "User1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(218, 229);
            label3.Name = "label3";
            label3.Size = new Size(16, 21);
            label3.TabIndex = 26;
            label3.Text = "-";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 229);
            label5.Name = "label5";
            label5.Size = new Size(155, 21);
            label5.TabIndex = 25;
            label5.Text = "Materias Impartidas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(456, 78);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 24;
            label2.Text = "Usuario:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrarAlumno);
            groupBox1.Controls.Add(btnAlumnos);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(46, 369);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 89);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Administración";
            // 
            // btnRegistrarAlumno
            // 
            btnRegistrarAlumno.Location = new Point(233, 35);
            btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            btnRegistrarAlumno.RightToLeft = RightToLeft.Yes;
            btnRegistrarAlumno.Size = new Size(146, 37);
            btnRegistrarAlumno.TabIndex = 13;
            btnRegistrarAlumno.Text = "Registrar alumno";
            btnRegistrarAlumno.UseVisualStyleBackColor = true;
            btnRegistrarAlumno.Click += btnRegistrarAlumno_Click;
            // 
            // btnAlumnos
            // 
            btnAlumnos.Location = new Point(15, 35);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(173, 37);
            btnAlumnos.TabIndex = 12;
            btnAlumnos.Text = "Administrar Evaluaciones";
            btnAlumnos.UseVisualStyleBackColor = true;
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // lblCantAlumnos
            // 
            lblCantAlumnos.AutoSize = true;
            lblCantAlumnos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantAlumnos.Location = new Point(218, 294);
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
            label4.Location = new Point(46, 294);
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
            ClientSize = new Size(611, 485);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "HomeDocenteForm";
            Text = "HomeDocenteForm";
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
        private Label label3;
        private Label label5;
        private Label label2;
        private Button btnRegistrarAlumno;
        private Label lblUser;
    }
}



