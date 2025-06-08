namespace Grupo4_Proyecto_final.Views.Docente
{
    partial class AsignarEvaluacionForm
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
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            cmbTrimestreBusq = new ComboBox();
            cmbMateriaBusq = new ComboBox();
            dataGridNotas = new DataGridView();
            Evaluacion = new DataGridViewTextBoxColumn();
            Materia = new DataGridViewTextBoxColumn();
            Trimestre = new DataGridViewTextBoxColumn();
            Calificacion = new DataGridViewTextBoxColumn();
            txtEvaluacion = new TextBox();
            label3 = new Label();
            txtCalificacion = new TextBox();
            btnLimpiar = new Button();
            btnAsignar = new Button();
            label6 = new Label();
            cmbTrimestre = new ComboBox();
            label5 = new Label();
            cmbMateria = new ComboBox();
            label4 = new Label();
            lblNombreAlumno = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridNotas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(dataGridNotas);
            panel1.Controls.Add(txtEvaluacion);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCalificacion);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnAsignar);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbTrimestre);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbMateria);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblNombreAlumno);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 370);
            panel1.TabIndex = 4;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(700, 335);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 17;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextAlign = ContentAlignment.TopCenter;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbTrimestreBusq);
            groupBox1.Controls.Add(cmbMateriaBusq);
            groupBox1.Location = new Point(328, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(453, 54);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar por";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(258, 25);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 17;
            label8.Text = "Trimestre: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 25);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 17;
            label7.Text = "Materia: ";
            // 
            // cmbTrimestreBusq
            // 
            cmbTrimestreBusq.FormattingEnabled = true;
            cmbTrimestreBusq.Location = new Point(326, 22);
            cmbTrimestreBusq.Name = "cmbTrimestreBusq";
            cmbTrimestreBusq.Size = new Size(121, 23);
            cmbTrimestreBusq.TabIndex = 17;
            cmbTrimestreBusq.SelectedIndexChanged += cmbTrimestreBusq_SelectedIndexChanged;
            // 
            // cmbMateriaBusq
            // 
            cmbMateriaBusq.FormattingEnabled = true;
            cmbMateriaBusq.Location = new Point(65, 22);
            cmbMateriaBusq.Name = "cmbMateriaBusq";
            cmbMateriaBusq.Size = new Size(121, 23);
            cmbMateriaBusq.TabIndex = 17;
            cmbMateriaBusq.SelectedIndexChanged += cmbMateriaBusq_SelectedIndexChanged;
            // 
            // dataGridNotas
            // 
            dataGridNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridNotas.Columns.AddRange(new DataGridViewColumn[] { Evaluacion, Materia, Trimestre, Calificacion });
            dataGridNotas.Location = new Point(328, 106);
            dataGridNotas.Name = "dataGridNotas";
            dataGridNotas.Size = new Size(448, 206);
            dataGridNotas.TabIndex = 15;
            // 
            // Evaluacion
            // 
            Evaluacion.HeaderText = "Evaluación";
            Evaluacion.Name = "Evaluacion";
            // 
            // Materia
            // 
            Materia.HeaderText = "Materia";
            Materia.Name = "Materia";
            // 
            // Trimestre
            // 
            Trimestre.HeaderText = "Trimestre";
            Trimestre.Name = "Trimestre";
            // 
            // Calificacion
            // 
            Calificacion.HeaderText = "Calificación";
            Calificacion.Name = "Calificacion";
            // 
            // txtEvaluacion
            // 
            txtEvaluacion.Location = new Point(129, 103);
            txtEvaluacion.Name = "txtEvaluacion";
            txtEvaluacion.Size = new Size(124, 23);
            txtEvaluacion.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 106);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 13;
            label3.Text = "Evaluación ";
            // 
            // txtCalificacion
            // 
            txtCalificacion.Location = new Point(132, 230);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(62, 23);
            txtCalificacion.TabIndex = 12;
            txtCalificacion.KeyPress += txtCalificacion_KeyPress;
            txtCalificacion.Leave += txtCalificacion_Leave;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(178, 289);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.TopCenter;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnCancelar_Click;
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(60, 289);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(75, 23);
            btnAsignar.TabIndex = 9;
            btnAsignar.Text = " Asignar";
            btnAsignar.TextAlign = ContentAlignment.TopCenter;
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 230);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(75, 15);
            label6.TabIndex = 7;
            label6.Text = "Calificación: ";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // cmbTrimestre
            // 
            cmbTrimestre.FormattingEnabled = true;
            cmbTrimestre.Location = new Point(132, 185);
            cmbTrimestre.Name = "cmbTrimestre";
            cmbTrimestre.Size = new Size(121, 23);
            cmbTrimestre.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 188);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 5;
            label5.Text = "Trimestre: ";
            // 
            // cmbMateria
            // 
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(132, 142);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(121, 23);
            cmbMateria.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 145);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Materia: ";
            // 
            // lblNombreAlumno
            // 
            lblNombreAlumno.AutoSize = true;
            lblNombreAlumno.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblNombreAlumno.Location = new Point(92, 61);
            lblNombreAlumno.Name = "lblNombreAlumno";
            lblNombreAlumno.Size = new Size(201, 17);
            lblNombreAlumno.TabIndex = 2;
            lblNombreAlumno.Text = "Jose Ernesto Navarro Guardado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(33, 61);
            label2.Name = "label2";
            label2.Size = new Size(63, 17);
            label2.TabIndex = 1;
            label2.Text = "Alumno: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 19);
            label1.Name = "label1";
            label1.Size = new Size(162, 21);
            label1.TabIndex = 0;
            label1.Text = "Asignar Calificación";
            // 
            // AsignarEvaluacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 370);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AsignarEvaluacionForm";
            Text = "Asignar Evaluación";
            Load += AsignarEvaluaciónForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridNotas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private Panel panel1;
        private Label lblNombreAlumno;
        private Label label2;
        private Label label1;
        private ComboBox cmbMateria;
        private Label label4;
        private Button btnLimpiar;
        private Button btnAsignar;
        private Label label6;
        private ComboBox cmbTrimestre;
        private Label label5;
        private TextBox txtCalificacion;
        private Label label3;
        private TextBox txtEvaluacion;
        private DataGridView dataGridNotas;
        private DataGridViewTextBoxColumn Evaluacion;
        private DataGridViewTextBoxColumn Materia;
        private DataGridViewTextBoxColumn Trimestre;
        private DataGridViewTextBoxColumn Calificacion;
        private GroupBox groupBox1;
        private ComboBox cmbTrimestreBusq;
        private ComboBox cmbMateriaBusq;
        private Label label8;
        private Label label7;
        private Button btnCerrar;
    }
}



