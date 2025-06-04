namespace Grupo4_Proyecto_final.Views.Admin
{
    partial class CrearAlumnoForm
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
            btnCancelar = new Button();
            btnCrear = new Button();
            groupBox2 = new GroupBox();
            cmbSeccion = new ComboBox();
            cmbGrado = new ComboBox();
            txtTelefono = new TextBox();
            txtEdad = new NumericUpDown();
            dtFechaNacimiento = new DateTimePicker();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            txtContrasenia = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtEdad).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnCrear);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(737, 523);
            panel1.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(402, 458);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 32);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrear.Location = new Point(192, 458);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(82, 32);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbSeccion);
            groupBox2.Controls.Add(cmbGrado);
            groupBox2.Controls.Add(txtTelefono);
            groupBox2.Controls.Add(txtEdad);
            groupBox2.Controls.Add(dtFechaNacimiento);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(40, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(657, 260);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Alumno";
            // 
            // cmbSeccion
            // 
            cmbSeccion.FormattingEnabled = true;
            cmbSeccion.Location = new Point(269, 214);
            cmbSeccion.Name = "cmbSeccion";
            cmbSeccion.Size = new Size(121, 25);
            cmbSeccion.TabIndex = 13;
            // 
            // cmbGrado
            // 
            cmbGrado.FormattingEnabled = true;
            cmbGrado.Location = new Point(34, 214);
            cmbGrado.Name = "cmbGrado";
            cmbGrado.Size = new Size(121, 25);
            cmbGrado.TabIndex = 12;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(453, 139);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(159, 25);
            txtTelefono.TabIndex = 11;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(270, 141);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(120, 25);
            txtEdad.TabIndex = 10;
            // 
            // dtFechaNacimiento
            // 
            dtFechaNacimiento.Location = new Point(34, 140);
            dtFechaNacimiento.Name = "dtFechaNacimiento";
            dtFechaNacimiento.Size = new Size(200, 25);
            dtFechaNacimiento.TabIndex = 9;
            dtFechaNacimiento.ValueChanged += dtFechaNacimiento_ValueChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(272, 68);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(159, 25);
            txtApellido.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(31, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(203, 25);
            txtNombre.TabIndex = 7;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(268, 188);
            label10.Name = "label10";
            label10.Size = new Size(53, 17);
            label10.TabIndex = 6;
            label10.Text = "Sección";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 188);
            label9.Name = "label9";
            label9.Size = new Size(45, 17);
            label9.TabIndex = 5;
            label9.Text = "Grado";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 119);
            label8.Name = "label8";
            label8.Size = new Size(116, 17);
            label8.TabIndex = 4;
            label8.Text = "Fecha Nacimiento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(264, 119);
            label7.Name = "label7";
            label7.Size = new Size(38, 17);
            label7.TabIndex = 3;
            label7.Text = "Edad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(453, 119);
            label6.Name = "label6";
            label6.Size = new Size(59, 17);
            label6.TabIndex = 2;
            label6.Text = "Teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 46);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(57, 17);
            label5.TabIndex = 1;
            label5.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 46);
            label4.Name = "label4";
            label4.Size = new Size(58, 17);
            label4.TabIndex = 0;
            label4.Text = "Nombre";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtContrasenia);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(40, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 77);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Usuario";
            // 
            // txtContrasenia
            // 
            txtContrasenia.Enabled = false;
            txtContrasenia.Location = new Point(271, 34);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.ReadOnly = true;
            txtContrasenia.Size = new Size(100, 25);
            txtContrasenia.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Enabled = false;
            txtUsuario.Location = new Point(69, 34);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(100, 25);
            txtUsuario.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(191, 37);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 1;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(10, 37);
            label2.Name = "label2";
            label2.Size = new Size(53, 17);
            label2.TabIndex = 0;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(294, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 5;
            label1.Text = "Nuevo Alumno";
            // 
            // CrearAlumnoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 523);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CrearAlumnoForm";
            Text = "CrearAlumnoForm";
            Load += CrearAlumnoForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtEdad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnCrear;
        private GroupBox groupBox2;
        private ComboBox cmbSeccion;
        private ComboBox cmbGrado;
        private TextBox txtTelefono;
        private NumericUpDown txtEdad;
        private DateTimePicker dtFechaNacimiento;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtContrasenia;
        private TextBox txtUsuario;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}



