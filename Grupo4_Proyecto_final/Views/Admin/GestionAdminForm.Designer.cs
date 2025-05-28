namespace Grupo4_Proyecto_final.Views.Admin
{
    partial class GestionAdminForm
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
            pictureBox1 = new PictureBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            lblFecha = new Label();
            label4 = new Label();
            btnNuevo = new Button();
            dataGridViewUsuarios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Contraseña = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            RolId = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            cmbRolBusq = new ComboBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            txtUsuarioBusq = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(dataGridViewUsuarios);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(737, 523);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_;
            pictureBox1.Location = new Point(17, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 128, 128);
            btnSalir.BackgroundImageLayout = ImageLayout.None;
            btnSalir.Location = new Point(649, 477);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(67, 35);
            btnSalir.TabIndex = 21;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ScrollBar;
            btnLimpiar.Location = new Point(413, 141);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(66, 35);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ControlLight;
            btnEliminar.Location = new Point(261, 477);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 35);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.ControlLight;
            btnEditar.Location = new Point(137, 477);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(87, 35);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(617, 165);
            lblFecha.Name = "lblFecha";
            lblFecha.RightToLeft = RightToLeft.No;
            lblFecha.Size = new Size(0, 15);
            lblFecha.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(573, 165);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 16;
            label4.Text = "Fecha: ";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ControlLight;
            btnNuevo.Location = new Point(21, 477);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(78, 35);
            btnNuevo.TabIndex = 15;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.AllowUserToOrderColumns = true;
            dataGridViewUsuarios.Columns.AddRange(new DataGridViewColumn[] { Id, Usuario, Contraseña, Rol, RolId });
            dataGridViewUsuarios.Location = new Point(17, 201);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RightToLeft = RightToLeft.No;
            dataGridViewUsuarios.Size = new Size(704, 270);
            dataGridViewUsuarios.TabIndex = 14;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            // 
            // Contraseña
            // 
            Contraseña.HeaderText = "Contraseña";
            Contraseña.Name = "Contraseña";
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            // 
            // RolId
            // 
            RolId.HeaderText = "RolId";
            RolId.Name = "RolId";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbRolBusq);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(203, 127);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(168, 53);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar por";
            // 
            // cmbRolBusq
            // 
            cmbRolBusq.FormattingEnabled = true;
            cmbRolBusq.Location = new Point(36, 21);
            cmbRolBusq.Name = "cmbRolBusq";
            cmbRolBusq.Size = new Size(121, 23);
            cmbRolBusq.TabIndex = 2;
            cmbRolBusq.SelectedIndexChanged += cmbRolBusq_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 24);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 1;
            label3.Text = "Rol";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtUsuarioBusq);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(17, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(172, 53);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar por";
            // 
            // txtUsuarioBusq
            // 
            txtUsuarioBusq.Location = new Point(61, 21);
            txtUsuarioBusq.Name = "txtUsuarioBusq";
            txtUsuarioBusq.Size = new Size(100, 23);
            txtUsuarioBusq.TabIndex = 1;
            txtUsuarioBusq.TextChanged += txtUsuarioBusq_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 24);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 0;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 50);
            label1.Name = "label1";
            label1.Size = new Size(202, 20);
            label1.TabIndex = 11;
            label1.Text = "Administración de Usuarios";
            // 
            // GestionAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 523);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "GestionAdminForm";
            Text = "Usuarios";
            Load += GestionAdminForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private Panel panel1;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnEditar;
        private Label lblFecha;
        private Label label4;
        private Button btnNuevo;
        private DataGridView dataGridViewUsuarios;
        private GroupBox groupBox2;
        private ComboBox cmbRolBusq;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox txtUsuarioBusq;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Contraseña;
        private DataGridViewTextBoxColumn Rol;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn RolId;
    }
}



