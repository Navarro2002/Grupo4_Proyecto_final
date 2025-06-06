namespace Grupo4_Proyecto_final.Views.Docente
{
    partial class ListadoAlumnosForm
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
            fechalbl = new Label();
            groupBox2 = new GroupBox();
            lbReprobados = new Label();
            lbAprobados = new Label();
            lblReprobados = new Label();
            lblAprobados = new Label();
            btnAsignarEvalucacion = new Button();
            btnSalir = new Button();
            btnLimpiar = new Button();
            lblFecha = new Label();
            label4 = new Label();
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
            Promedio = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlumnos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(fechalbl);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(btnAsignarEvalucacion);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dataGridViewAlumnos);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 614);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // fechalbl
            // 
            fechalbl.AutoSize = true;
            fechalbl.Location = new Point(807, 148);
            fechalbl.Name = "fechalbl";
            fechalbl.Size = new Size(38, 15);
            fechalbl.TabIndex = 55;
            fechalbl.Text = "label3";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbReprobados);
            groupBox2.Controls.Add(lbAprobados);
            groupBox2.Controls.Add(lblReprobados);
            groupBox2.Controls.Add(lblAprobados);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(557, 462);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 106);
            groupBox2.TabIndex = 54;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estadisticas";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lbReprobados
            // 
            lbReprobados.AutoSize = true;
            lbReprobados.Location = new Point(169, 63);
            lbReprobados.Name = "lbReprobados";
            lbReprobados.Size = new Size(43, 17);
            lbReprobados.TabIndex = 3;
            lbReprobados.Text = "label4";
            // 
            // lbAprobados
            // 
            lbAprobados.AutoSize = true;
            lbAprobados.Location = new Point(168, 28);
            lbAprobados.Name = "lbAprobados";
            lbAprobados.Size = new Size(43, 17);
            lbAprobados.TabIndex = 2;
            lbAprobados.Text = "label3";
            // 
            // lblReprobados
            // 
            lblReprobados.AutoSize = true;
            lblReprobados.Location = new Point(14, 65);
            lblReprobados.Name = "lblReprobados";
            lblReprobados.Size = new Size(149, 17);
            lblReprobados.TabIndex = 1;
            lblReprobados.Text = "Porcentaje reprobados:";
            // 
            // lblAprobados
            // 
            lblAprobados.AutoSize = true;
            lblAprobados.Location = new Point(14, 27);
            lblAprobados.Name = "lblAprobados";
            lblAprobados.Size = new Size(144, 17);
            lblAprobados.TabIndex = 0;
            lblAprobados.Text = "Porcentaje aprobados:";
            // 
            // btnAsignarEvalucacion
            // 
            btnAsignarEvalucacion.BackColor = Color.FromArgb(224, 224, 224);
            btnAsignarEvalucacion.ForeColor = SystemColors.ActiveCaptionText;
            btnAsignarEvalucacion.Location = new Point(53, 514);
            btnAsignarEvalucacion.Name = "btnAsignarEvalucacion";
            btnAsignarEvalucacion.Size = new Size(117, 40);
            btnAsignarEvalucacion.TabIndex = 52;
            btnAsignarEvalucacion.Text = "Asignar Evaluación";
            btnAsignarEvalucacion.UseVisualStyleBackColor = false;
            btnAsignarEvalucacion.Click += btnAsignarEvalucacion_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 192, 192);
            btnSalir.Location = new Point(850, 558);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(60, 40);
            btnSalir.TabIndex = 50;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ScrollBar;
            btnLimpiar.Location = new Point(317, 140);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(66, 35);
            btnLimpiar.TabIndex = 48;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(807, 148);
            lblFecha.Name = "lblFecha";
            lblFecha.RightToLeft = RightToLeft.No;
            lblFecha.Size = new Size(0, 15);
            lblFecha.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(757, 148);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 46;
            label4.Text = "Fecha: ";
            // 
            // dataGridViewAlumnos
            // 
            dataGridViewAlumnos.AllowUserToOrderColumns = true;
            dataGridViewAlumnos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Edad, Telefono, FechaNacimiento, Grado, IdGrado, Seccion, IdSeccion, Promedio });
            dataGridViewAlumnos.Location = new Point(53, 189);
            dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            dataGridViewAlumnos.RightToLeft = RightToLeft.No;
            dataGridViewAlumnos.Size = new Size(843, 226);
            dataGridViewAlumnos.TabIndex = 45;
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
            // Promedio
            // 
            Promedio.HeaderText = "Promedio";
            Promedio.Name = "Promedio";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(53, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(235, 53);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar por";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(75, 21);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(154, 25);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtDocenteBusq_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 24);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(384, 32);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Alumnos";
            // 
            // ListadoAlumnosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 614);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ListadoAlumnosForm";
            Text = "Listado Alumnos";
            Load += ListadoAlumnosForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlumnos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private Panel panel1;
        private Label label1;
        private Button btnSalir;
        private Button btnLimpiar;
        private Label lblFecha;
        private Label label4;
        private DataGridView dataGridViewAlumnos;
        private GroupBox groupBox1;
        private TextBox txtNombre;
        private Label label2;
        private Button btnAsignarEvalucacion;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn Grado;
        private DataGridViewTextBoxColumn IdGrado;
        private DataGridViewTextBoxColumn Seccion;
        private DataGridViewTextBoxColumn IdSeccion;
        private DataGridViewTextBoxColumn Promedio;
        private GroupBox groupBox2;
        private Label lblAprobados;
        private Label lblReprobados;
        private Label fechalbl;
        private Label lbReprobados;
        private Label lbAprobados;
    }
}



