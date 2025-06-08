namespace Grupo4_Proyecto_final.Views.Admin
{
    partial class GestionTrimestresForm
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
            btnSalir = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            dataGridTrimestres = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            NotaMinina = new DataGridViewTextBoxColumn();
            btnLimpiar = new Button();
            lblFecha = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTrimestres).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(dataGridTrimestres);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 300);
            panel1.TabIndex = 4;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 128, 128);
            btnSalir.BackgroundImageLayout = ImageLayout.None;
            btnSalir.Location = new Point(386, 248);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(47, 35);
            btnSalir.TabIndex = 50;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ControlLight;
            btnEliminar.Location = new Point(220, 252);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(70, 26);
            btnEliminar.TabIndex = 49;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.ControlLight;
            btnEditar.Location = new Point(130, 252);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(72, 26);
            btnEditar.TabIndex = 48;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ControlLight;
            btnNuevo.Location = new Point(29, 252);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(81, 26);
            btnNuevo.TabIndex = 47;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dataGridTrimestres
            // 
            dataGridTrimestres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTrimestres.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, NotaMinina });
            dataGridTrimestres.Location = new Point(39, 96);
            dataGridTrimestres.Name = "dataGridTrimestres";
            dataGridTrimestres.Size = new Size(336, 150);
            dataGridTrimestres.TabIndex = 46;
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
            // NotaMinina
            // 
            NotaMinina.HeaderText = "Nota Minina";
            NotaMinina.Name = "NotaMinina";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ScrollBar;
            btnLimpiar.Location = new Point(240, 56);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(70, 30);
            btnLimpiar.TabIndex = 45;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(375, 61);
            lblFecha.Name = "lblFecha";
            lblFecha.RightToLeft = RightToLeft.No;
            lblFecha.Size = new Size(0, 15);
            lblFecha.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(331, 61);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 43;
            label4.Text = "Fecha: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Location = new Point(17, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(192, 44);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 19);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(86, 15);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(130, 17);
            label1.Name = "label1";
            label1.Size = new Size(142, 17);
            label1.TabIndex = 41;
            label1.Text = "Gestión de Trimestres";
            // 
            // GestionTrimestresForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 300);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "GestionTrimestresForm";
            Text = "Gestion Trimestres";
            Load += GestionTrimestresForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTrimestres).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private Panel panel1;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnNuevo;
        private DataGridView dataGridTrimestres;
        private Button btnLimpiar;
        private Label lblFecha;
        private Label label4;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn NotaMinina;
    }
}



