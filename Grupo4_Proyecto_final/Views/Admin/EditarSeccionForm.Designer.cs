namespace Grupo4_Proyecto_final.Views.Admin
{
    partial class EditarSeccionForm
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
            label3 = new Label();
            btnCancelar = new Button();
            btnEditar = new Button();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 207);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(89, 56);
            txtId.Name = "txtId";
            txtId.Size = new Size(38, 23);
            txtId.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 56);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 16;
            label3.Text = "Id:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(224, 224, 224);
            btnCancelar.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(169, 149);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(62, 32);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(224, 224, 224);
            btnEditar.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(65, 149);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(62, 32);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(89, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(131, 23);
            txtNombre.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 108);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 12;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 19);
            label1.Name = "label1";
            label1.Size = new Size(94, 17);
            label1.TabIndex = 0;
            label1.Text = "Editar Sección";
            label1.Click += label1_Click;
            // 
            // EditarSeccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 207);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "EditarSeccionForm";
            Text = "Editar Seccion";
            Load += EditarSeccionForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private Panel panel1;
        private Label label1;
        private Button btnCancelar;
        private Button btnEditar;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtId;
        private Label label3;
    }
}



