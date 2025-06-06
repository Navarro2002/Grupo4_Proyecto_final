namespace Grupo4_Proyecto_final.Views.Admin
{
    partial class EditarMateriaForm
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
            btnCrear = new Button();
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
            panel1.Controls.Add(btnCrear);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 173);
            panel1.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(91, 62);
            txtId.Name = "txtId";
            txtId.Size = new Size(42, 23);
            txtId.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 70);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 22;
            label3.Text = "Id";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(224, 224, 224);
            btnCancelar.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(143, 129);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(62, 32);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(224, 224, 224);
            btnCrear.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrear.Location = new Point(37, 129);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(62, 32);
            btnCrear.TabIndex = 20;
            btnCrear.Text = "Editar";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(91, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(131, 23);
            txtNombre.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 94);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 18;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 30);
            label1.Name = "label1";
            label1.Size = new Size(95, 17);
            label1.TabIndex = 17;
            label1.Text = "Editar Materia";
            // 
            // EditarMateriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 173);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "EditarMateriaForm";
            Text = "Editar ";
            Load += EditarMateriaForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnCrear;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private TextBox txtId;
        private Label label3;
    }
}



