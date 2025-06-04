namespace Grupo4_Proyecto_final.Views.Alumno
{
    partial class CalificacionesAlumnoForm
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
            groupBox1 = new GroupBox();
            btnLimpiar = new Button();
            cmbMateria = new ComboBox();
            cmbTrimestre = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            lblAlumno = new Label();
            label2 = new Label();
            btnCerrar = new Button();
            dataGridEvaluaciones = new DataGridView();
            Evaluacion = new DataGridViewTextBoxColumn();
            Trimestre = new DataGridViewTextBoxColumn();
            Materia = new DataGridViewTextBoxColumn();
            Promedio = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEvaluaciones).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(lblAlumno);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(dataGridEvaluaciones);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(553, 430);
            panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(cmbMateria);
            groupBox1.Controls.Add(cmbTrimestre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(48, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 58);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar por";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ButtonFace;
            btnLimpiar.Location = new Point(352, 18);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(66, 26);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cmbMateria
            // 
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(250, 18);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(88, 25);
            cmbMateria.TabIndex = 3;
            cmbMateria.SelectedIndexChanged += cmbMateria_SelectedIndexChanged;
            // 
            // cmbTrimestre
            // 
            cmbTrimestre.FormattingEnabled = true;
            cmbTrimestre.Location = new Point(71, 18);
            cmbTrimestre.Name = "cmbTrimestre";
            cmbTrimestre.Size = new Size(103, 25);
            cmbTrimestre.TabIndex = 2;
            cmbTrimestre.SelectedIndexChanged += cmbTrimestre_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 27);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 1;
            label4.Text = "Trimestre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 26);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 0;
            label3.Text = "Materia";
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Location = new Point(108, 98);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(105, 15);
            lblAlumno.TabIndex = 4;
            lblAlumno.Text = "Nombre completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 96);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 3;
            label2.Text = "Alumno: ";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(255, 192, 192);
            btnCerrar.Location = new Point(455, 395);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // dataGridEvaluaciones
            // 
            dataGridEvaluaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEvaluaciones.Columns.AddRange(new DataGridViewColumn[] { Evaluacion, Trimestre, Materia, Promedio });
            dataGridEvaluaciones.Location = new Point(48, 204);
            dataGridEvaluaciones.Name = "dataGridEvaluaciones";
            dataGridEvaluaciones.Size = new Size(444, 185);
            dataGridEvaluaciones.TabIndex = 1;
            // 
            // Evaluacion
            // 
            Evaluacion.HeaderText = "Evaluación";
            Evaluacion.Name = "Evaluacion";
            // 
            // Trimestre
            // 
            Trimestre.HeaderText = "Trimestre";
            Trimestre.Name = "Trimestre";
            // 
            // Materia
            // 
            Materia.HeaderText = "Materia";
            Materia.Name = "Materia";
            // 
            // Promedio
            // 
            Promedio.HeaderText = "Promedio";
            Promedio.Name = "Promedio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 30);
            label1.Name = "label1";
            label1.Size = new Size(198, 21);
            label1.TabIndex = 0;
            label1.Text = "Calificaciones Obtenidas";
            label1.Click += label1_Click;
            // 
            // CalificacionesAlumnoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 430);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CalificacionesAlumnoForm";
            Text = "Calificaciones Alumno";
            Load += CalificacionesAlumnoForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEvaluaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridEvaluaciones;
        private Button btnCerrar;
        private Label lblAlumno;
        private Label label2;
        private DataGridViewTextBoxColumn Evaluacion;
        private DataGridViewTextBoxColumn Trimestre;
        private DataGridViewTextBoxColumn Materia;
        private DataGridViewTextBoxColumn Promedio;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private ComboBox cmbMateria;
        private ComboBox cmbTrimestre;
        private Button btnLimpiar;
    }
}



