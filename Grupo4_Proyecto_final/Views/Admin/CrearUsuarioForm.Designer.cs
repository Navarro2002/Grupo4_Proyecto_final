namespace Grupo4_Proyecto_final.Views.Admin
{
    partial class CrearUsuarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearUsuarioForm));
            toolTip = new ToolTip(components);
            panel1 = new Panel();
            txtLimpiar = new Button();
            btnCrear = new Button();
            cmbRol = new ComboBox();
            txtContrasenia = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(txtLimpiar);
            panel1.Controls.Add(btnCrear);
            panel1.Controls.Add(cmbRol);
            panel1.Controls.Add(txtContrasenia);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 279);
            panel1.TabIndex = 4;
            // 
            // txtLimpiar
            // 
            txtLimpiar.BackColor = SystemColors.ControlLight;
            txtLimpiar.Location = new Point(183, 223);
            txtLimpiar.Name = "txtLimpiar";
            txtLimpiar.Size = new Size(78, 29);
            txtLimpiar.TabIndex = 33;
            txtLimpiar.Text = "Limpiar";
            txtLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = SystemColors.ControlLight;
            btnCrear.Location = new Point(38, 223);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(86, 29);
            btnCrear.TabIndex = 32;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(85, 177);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(121, 23);
            cmbRol.TabIndex = 31;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(85, 135);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(212, 23);
            txtContrasenia.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 177);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 27;
            label6.Text = "Rol: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 138);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 26;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 89);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 25;
            label4.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(81, 81);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(212, 23);
            txtUsuario.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 19);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 23;
            label2.Text = "Crear Usuario";
            // 
            // CrearUsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 279);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CrearUsuarioForm";
            Text = "CrearUsuario";
            Load += CrearUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private Panel panel1;
        private Button txtLimpiar;
        private Button btnCrear;
        private ComboBox cmbRol;
        private TextBox txtContrasenia;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtUsuario;
        private Label label2;
    }
}



