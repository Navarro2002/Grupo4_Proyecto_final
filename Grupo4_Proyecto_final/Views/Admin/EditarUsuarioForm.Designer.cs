namespace Grupo4_Proyecto_final.Views.Admin
{
    partial class EditarUsuarioForm
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
            txtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            btnEditar = new Button();
            cmbRol = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            txtUsuario = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(cmbRol);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtUsuario);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 343);
            panel1.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.AcceptsReturn = true;
            txtId.Location = new Point(100, 115);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(54, 23);
            txtId.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 123);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 46;
            label2.Text = "Id: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 55);
            label1.Name = "label1";
            label1.Size = new Size(122, 21);
            label1.TabIndex = 45;
            label1.Text = "Editar Usuario ";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(237, 286);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 44;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(79, 286);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 43;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(100, 205);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(121, 23);
            cmbRol.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 213);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 38;
            label6.Text = "Rol: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 158);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 36;
            label4.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(100, 158);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(212, 23);
            txtUsuario.TabIndex = 40;
            // 
            // EditarUsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 343);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "EditarUsuarioForm";
            Text = "EditarUsuarioForm";
            Load += EditarUsuarioForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private Panel panel1;
        private TextBox txtId;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnEditar;
        private ComboBox cmbRol;
        private Label label6;
        private Label label4;
        private TextBox txtUsuario;
    }
}



