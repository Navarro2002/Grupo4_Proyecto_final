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
            btnCerrar = new Button();
            groupBox1 = new GroupBox();
            dataGridPromediosTrimestres = new DataGridView();
            Trimestre = new DataGridViewTextBoxColumn();
            Promedio = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lblAlumno = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPromediosTrimestres).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(lblAlumno);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(710, 523);
            panel1.TabIndex = 4;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(623, 471);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 31);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridPromediosTrimestres);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(77, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 198);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Promedios por trimestres";
            // 
            // dataGridPromediosTrimestres
            // 
            dataGridPromediosTrimestres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPromediosTrimestres.Columns.AddRange(new DataGridViewColumn[] { Trimestre, Promedio });
            dataGridPromediosTrimestres.Location = new Point(154, 24);
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
            label1.Location = new Point(267, 22);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 0;
            label1.Text = "Promedios Alumno";
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
            // PromediosAlumnosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 523);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "PromediosAlumnosForm";
            Text = "Promedios Alumno";
            Load += PromediosAlumnosForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}



