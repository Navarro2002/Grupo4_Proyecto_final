namespace Grupo4_Proyecto_final.Views.Alumno
{
    partial class ActualizarContraForm
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
            lblUsuario = new Label();
            txtCancelar = new Button();
            btnActualizar = new Button();
            txtContrasenia = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(txtCancelar);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(txtContrasenia);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 249);
            panel1.TabIndex = 4;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(42, 76);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(54, 17);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuario";
            lblUsuario.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtCancelar
            // 
            txtCancelar.Location = new Point(172, 187);
            txtCancelar.Name = "txtCancelar";
            txtCancelar.Size = new Size(75, 26);
            txtCancelar.TabIndex = 4;
            txtCancelar.Text = "Cancelar";
            txtCancelar.UseVisualStyleBackColor = true;
            txtCancelar.Click += txtCancelar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(48, 187);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 26);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(148, 136);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(100, 23);
            txtContrasenia.TabIndex = 2;
            txtContrasenia.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 139);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 1;
            label2.Text = "Nueva contraseña: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 22);
            label1.Name = "label1";
            label1.Size = new Size(177, 21);
            label1.TabIndex = 0;
            label1.Text = "Actualizar Contraseña";
            // 
            // ActualizarContraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 249);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ActualizarContraForm";
            Text = "Actualizar Contraseña";
            Load += ActualizarContraForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private Panel panel1;
        private Button txtCancelar;
        private Button btnActualizar;
        private TextBox txtContrasenia;
        private Label label2;
        private Label label1;
        private Label lblUsuario;
    }
}



