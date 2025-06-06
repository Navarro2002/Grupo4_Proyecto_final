namespace Grupo4_Proyecto_final.Views.Alumno
{
    partial class PromediosAlumnosForm
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
            cmbTrimestre = new ComboBox();
            label3 = new Label();
            dataGridProMaterias = new DataGridView();
            Materia = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            lblAlumno = new Label();
            label2 = new Label();
            btnCerrar = new Button();
            groupBox1 = new GroupBox();
            dataGridPromediosTrimestres = new DataGridView();
            Trimestre = new DataGridViewTextBoxColumn();
            Promedio = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProMaterias).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPromediosTrimestres).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(lblAlumno);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 585);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbTrimestre);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dataGridProMaterias);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(77, 323);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(490, 235);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Promedios de materias";
            // 
            // cmbTrimestre
            // 
            cmbTrimestre.FormattingEnabled = true;
            cmbTrimestre.Location = new Point(82, 29);
            cmbTrimestre.Name = "cmbTrimestre";
            cmbTrimestre.Size = new Size(121, 25);
            cmbTrimestre.TabIndex = 3;
            cmbTrimestre.SelectedIndexChanged += cmbTrimestre_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 32);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 2;
            label3.Text = "Trimestre";
            // 
            // dataGridProMaterias
            // 
            dataGridProMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProMaterias.Columns.AddRange(new DataGridViewColumn[] { Materia, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Estado });
            dataGridProMaterias.Location = new Point(12, 70);
            dataGridProMaterias.Name = "dataGridProMaterias";
            dataGridProMaterias.Size = new Size(432, 150);
            dataGridProMaterias.TabIndex = 1;
            // 
            // Materia
            // 
            Materia.HeaderText = "Materia";
            Materia.Name = "Materia";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Trimestre";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Promedio";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Location = new Point(149, 76);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(105, 15);
            lblAlumno.TabIndex = 6;
            lblAlumno.Text = "Nombre completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(89, 74);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 5;
            label2.Text = "Alumno: ";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(255, 192, 192);
            btnCerrar.Location = new Point(573, 542);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 31);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridPromediosTrimestres);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(77, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 188);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Promedios por trimestres";
            // 
            // dataGridPromediosTrimestres
            // 
            dataGridPromediosTrimestres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPromediosTrimestres.Columns.AddRange(new DataGridViewColumn[] { Trimestre, Promedio });
            dataGridPromediosTrimestres.Location = new Point(55, 24);
            dataGridPromediosTrimestres.Name = "dataGridPromediosTrimestres";
            dataGridPromediosTrimestres.Size = new Size(241, 150);
            dataGridPromediosTrimestres.TabIndex = 1;
            // 
            // Trimestre
            // 
            Trimestre.HeaderText = "Trimestre";
            Trimestre.Name = "Trimestre";
            // 
            // Promedio
            // 
            Promedio.HeaderText = "Promedio";
            Promedio.Name = "Promedio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(245, 23);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 0;
            label1.Text = "Promedios Alumno";
            // 
            // PromediosAlumnosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 585);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "PromediosAlumnosForm";
            Text = "Promedios Alumno";
            Load += PromediosAlumnosForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProMaterias).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridPromediosTrimestres).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private Panel panel1;
        private GroupBox groupBox1;
        private DataGridView dataGridPromediosTrimestres;
        private DataGridViewTextBoxColumn Trimestre;
        private DataGridViewTextBoxColumn Promedio;
        private Label label1;
        private Button btnCerrar;
        private Label lblAlumno;
        private Label label2;
        private GroupBox groupBox2;
        private DataGridView dataGridProMaterias;
        private ComboBox cmbTrimestre;
        private Label label3;
        private DataGridViewTextBoxColumn Materia;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Estado;
    }
}



