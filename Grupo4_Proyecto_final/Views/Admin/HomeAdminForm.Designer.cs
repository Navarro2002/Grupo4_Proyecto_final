namespace Grupo4_Proyecto_final.Views.Admin
{
    partial class HomeAdminForm
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
            lblCantDocentes = new Label();
            groupBox1 = new GroupBox();
            BtnGrados = new Button();
            btnSeccion = new Button();
            btnMaterias = new Button();
            btnAlumnos = new Button();
            btnAdministrarUsuarios = new Button();
            btnAdministrarDocentes = new Button();
            lblCantUsuarios = new Label();
            label3 = new Label();
            lblCantAlumnos = new Label();
            label2 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            imageList1 = new ImageList(components);
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(lblCantDocentes);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(lblCantUsuarios);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblCantAlumnos);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 570);
            panel1.TabIndex = 4;
            // 
            // lblCantDocentes
            // 
            lblCantDocentes.AutoSize = true;
            lblCantDocentes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantDocentes.Location = new Point(200, 318);
            lblCantDocentes.Name = "lblCantDocentes";
            lblCantDocentes.Size = new Size(16, 21);
            lblCantDocentes.TabIndex = 15;
            lblCantDocentes.Text = "-";
            lblCantDocentes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnGrados);
            groupBox1.Controls.Add(btnSeccion);
            groupBox1.Controls.Add(btnMaterias);
            groupBox1.Controls.Add(btnAlumnos);
            groupBox1.Controls.Add(btnAdministrarUsuarios);
            groupBox1.Controls.Add(btnAdministrarDocentes);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(32, 372);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(626, 157);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Administración";
            // 
            // BtnGrados
            // 
            BtnGrados.Location = new Point(383, 102);
            BtnGrados.Name = "BtnGrados";
            BtnGrados.Size = new Size(133, 37);
            BtnGrados.TabIndex = 15;
            BtnGrados.Text = "Grados";
            BtnGrados.UseVisualStyleBackColor = true;
            // 
            // btnSeccion
            // 
            btnSeccion.Location = new Point(88, 102);
            btnSeccion.Name = "btnSeccion";
            btnSeccion.Size = new Size(133, 37);
            btnSeccion.TabIndex = 14;
            btnSeccion.Text = "Secciones";
            btnSeccion.UseVisualStyleBackColor = true;
            btnSeccion.Click += btnSeccion_Click;
            // 
            // btnMaterias
            // 
            btnMaterias.Location = new Point(477, 48);
            btnMaterias.Name = "btnMaterias";
            btnMaterias.Size = new Size(133, 37);
            btnMaterias.TabIndex = 13;
            btnMaterias.Text = "Materias";
            btnMaterias.UseVisualStyleBackColor = true;
            btnMaterias.Click += btnMaterias_Click;
            // 
            // btnAlumnos
            // 
            btnAlumnos.Location = new Point(329, 48);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(133, 37);
            btnAlumnos.TabIndex = 12;
            btnAlumnos.Text = "Alumnos";
            btnAlumnos.UseVisualStyleBackColor = true;
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // btnAdministrarUsuarios
            // 
            btnAdministrarUsuarios.Location = new Point(18, 48);
            btnAdministrarUsuarios.Name = "btnAdministrarUsuarios";
            btnAdministrarUsuarios.Size = new Size(133, 37);
            btnAdministrarUsuarios.TabIndex = 11;
            btnAdministrarUsuarios.Text = "Usuarios";
            btnAdministrarUsuarios.UseVisualStyleBackColor = true;
            btnAdministrarUsuarios.Click += btnAdministrarUsuarios_Click;
            // 
            // btnAdministrarDocentes
            // 
            btnAdministrarDocentes.Location = new Point(172, 48);
            btnAdministrarDocentes.Name = "btnAdministrarDocentes";
            btnAdministrarDocentes.Size = new Size(133, 37);
            btnAdministrarDocentes.TabIndex = 10;
            btnAdministrarDocentes.Text = "Docentes";
            btnAdministrarDocentes.UseVisualStyleBackColor = true;
            btnAdministrarDocentes.Click += btnAdministrarDocentes_Click;
            // 
            // lblCantUsuarios
            // 
            lblCantUsuarios.AutoSize = true;
            lblCantUsuarios.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantUsuarios.Location = new Point(200, 194);
            lblCantUsuarios.Name = "lblCantUsuarios";
            lblCantUsuarios.Size = new Size(16, 21);
            lblCantUsuarios.TabIndex = 13;
            lblCantUsuarios.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 194);
            label3.Name = "label3";
            label3.Size = new Size(163, 21);
            label3.TabIndex = 12;
            label3.Text = "Usuarios registrados:";
            // 
            // lblCantAlumnos
            // 
            lblCantAlumnos.AutoSize = true;
            lblCantAlumnos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantAlumnos.Location = new Point(200, 260);
            lblCantAlumnos.Name = "lblCantAlumnos";
            lblCantAlumnos.Size = new Size(16, 21);
            lblCantAlumnos.TabIndex = 8;
            lblCantAlumnos.Text = "-";
            lblCantAlumnos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 318);
            label2.Name = "label2";
            label2.Size = new Size(170, 21);
            label2.TabIndex = 7;
            label2.Text = "Docentes registrados:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 260);
            label4.Name = "label4";
            label4.Size = new Size(165, 21);
            label4.TabIndex = 6;
            label4.Text = "Alumnos registrados:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_;
            pictureBox1.Location = new Point(32, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(204, 23);
            label1.Name = "label1";
            label1.Size = new Size(262, 30);
            label1.TabIndex = 0;
            label1.Text = "Colegio Anders Hejlsberg";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // HomeAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 570);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "HomeAdminForm";
            Text = "Colegio Anders Hejlsberg";
            Load += HomeAdminForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private Panel panel1;
        private Label label1;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label lblCantAlumnos;
        private Label label2;
        private Button btnAdministrarDocentes;
        private Button btnAdministrarUsuarios;
        private Label label3;
        private Label lblCantUsuarios;
        private GroupBox groupBox1;
        private Button btnMaterias;
        private Button btnAlumnos;
        private Label lblCantDocentes;
        private Button btnSeccion;
        private Button BtnGrados;
    }
}



