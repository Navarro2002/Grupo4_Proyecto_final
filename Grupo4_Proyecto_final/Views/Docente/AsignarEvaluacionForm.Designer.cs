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
            btnCancelar = new Button();
            btnAsignar = new Button();
            txtNota = new TextBox();
            label6 = new Label();
            cmbTrimestre = new ComboBox();
            label5 = new Label();
            cmbMateria = new ComboBox();
            label4 = new Label();
            lblNombreAlumno = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnAsignar);
            panel1.Controls.Add(txtNota);
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
            panel1.Size = new Size(383, 356);
            panel1.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(209, 289);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.TopCenter;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
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
            // txtNota
            // 
            txtNota.Location = new Point(121, 187);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(121, 23);
            txtNota.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 187);
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
            cmbTrimestre.Location = new Point(121, 142);
            cmbTrimestre.Name = "cmbTrimestre";
            cmbTrimestre.Size = new Size(121, 23);
            cmbTrimestre.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 145);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 5;
            label5.Text = "Trimestre: ";
            // 
            // cmbMateria
            // 
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(121, 99);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(121, 23);
            cmbMateria.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 102);
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
            ClientSize = new Size(383, 356);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AsignarEvaluacionForm";
            Text = "AsignarEvaluaciónForm";
            Load += AsignarEvaluaciónForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button btnCancelar;
        private Button btnAsignar;
        private TextBox txtNota;
        private Label label6;
        private ComboBox cmbTrimestre;
        private Label label5;
    }
}



