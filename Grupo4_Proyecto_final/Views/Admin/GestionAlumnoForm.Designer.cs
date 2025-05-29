namespace Grupo4_Proyecto_final.Views.Admin
{
    partial class GestionAlumnoForm
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
            groupBox2 = new GroupBox();
            cmbGrado = new ComboBox();
            label3 = new Label();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            lblFecha = new Label();
            label4 = new Label();
            btnNuevo = new Button();
            dataGridViewAlumnos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            Grado = new DataGridViewTextBoxColumn();
            IdGrado = new DataGridViewTextBoxColumn();
            Seccion = new DataGridViewTextBoxColumn();
            IdSeccion = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            txtDocenteBusq = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlumnos).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(dataGridViewAlumnos);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 488);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbGrado);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(262, 101);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(235, 53);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar por";
            // 
            // cmbGrado
            // 
            cmbGrado.FormattingEnabled = true;
            cmbGrado.Location = new Point(53, 21);
            cmbGrado.Name = "cmbGrado";
            cmbGrado.Size = new Size(121, 23);
            cmbGrado.TabIndex = 1;
            cmbGrado.SelectedIndexChanged += cmbGrado_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 24);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 0;
            label3.Text = "Grado";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 128, 128);
            btnSalir.BackgroundImageLayout = ImageLayout.None;
            btnSalir.Location = new Point(755, 417);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(67, 35);
            btnSalir.TabIndex = 43;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ScrollBar;
            btnLimpiar.Location = new Point(546, 115);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(66, 35);
            btnLimpiar.TabIndex = 42;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ControlLight;
            btnEliminar.Location = new Point(252, 417);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 35);
            btnEliminar.TabIndex = 41;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.ControlLight;
            btnEditar.Location = new Point(128, 417);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(87, 35);
            btnEditar.TabIndex = 40;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(766, 125);
            lblFecha.Name = "lblFecha";
            lblFecha.RightToLeft = RightToLeft.No;
            lblFecha.Size = new Size(0, 15);
            lblFecha.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(716, 125);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 38;
            label4.Text = "Fecha: ";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ControlLight;
            btnNuevo.Location = new Point(12, 417);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(78, 35);
            btnNuevo.TabIndex = 37;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dataGridViewAlumnos
            // 
            dataGridViewAlumnos.AllowUserToOrderColumns = true;
            dataGridViewAlumnos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Edad, Telefono, FechaNacimiento, Grado, IdGrado, Seccion, IdSeccion, Usuario });
            dataGridViewAlumnos.Location = new Point(12, 166);
            dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            dataGridViewAlumnos.RightToLeft = RightToLeft.No;
            dataGridViewAlumnos.Size = new Size(824, 226);
            dataGridViewAlumnos.TabIndex = 36;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Edad
            // 
            Edad.HeaderText = "Edad";
            Edad.Name = "Edad";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.HeaderText = "FechaNacimiento";
            FechaNacimiento.Name = "FechaNacimiento";
            // 
            // Grado
            // 
            Grado.HeaderText = "Grado";
            Grado.Name = "Grado";
            // 
            // IdGrado
            // 
            IdGrado.HeaderText = "IdGrado";
            IdGrado.Name = "IdGrado";
            IdGrado.Visible = false;
            // 
            // Seccion
            // 
            Seccion.HeaderText = "Seccion";
            Seccion.Name = "Seccion";
            // 
            // IdSeccion
            // 
            IdSeccion.HeaderText = "IdSeccion";
            IdSeccion.Name = "IdSeccion";
            IdSeccion.Visible = false;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDocenteBusq);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(235, 53);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar por";
            // 
            // txtDocenteBusq
            // 
            txtDocenteBusq.Location = new Point(75, 21);
            txtDocenteBusq.Name = "txtDocenteBusq";
            txtDocenteBusq.Size = new Size(154, 23);
            txtDocenteBusq.TabIndex = 1;
            txtDocenteBusq.TextChanged += txtDocenteBusq_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 24);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 40);
            label1.Name = "label1";
            label1.Size = new Size(163, 21);
            label1.TabIndex = 1;
            label1.Text = "Gestión de Alumnos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // GestionAlumnoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 488);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "GestionAlumnoForm";
            Text = "GestionAlumnoForm";
            Load += GestionAlumnoForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlumnos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private ComboBox cmbGrado;
        private Label label3;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnEditar;
        private Label lblFecha;
        private Label label4;
        private Button btnNuevo;
        private DataGridView dataGridViewAlumnos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn Grado;
        private DataGridViewTextBoxColumn IdGrado;
        private DataGridViewTextBoxColumn Seccion;
        private DataGridViewTextBoxColumn IdSeccion;
        private DataGridViewTextBoxColumn Usuario;
        private GroupBox groupBox1;
        private TextBox txtDocenteBusq;
        private Label label2;
    }
}



