namespace Grupo4_Proyecto_final.Views.Admin
{
    partial class CrearTrimestreForm
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
            txtNota = new TextBox();
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
            panel1.Controls.Add(txtNota);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnCrear);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 210);
            panel1.TabIndex = 5;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(91, 113);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(131, 23);
            txtNota.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 12;
            label3.Text = "Nota minina";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(224, 224, 224);
            btnCancelar.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(153, 147);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(62, 32);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(224, 224, 224);
            btnCrear.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrear.Location = new Point(45, 147);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(62, 32);
            btnCrear.TabIndex = 10;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(91, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(131, 23);
            txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 22);
            label1.Name = "label1";
            label1.Size = new Size(102, 17);
            label1.TabIndex = 0;
            label1.Text = "Crear Trimestre";
            // 
            // CrearTrimestreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 210);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CrearTrimestreForm";
            Text = "Crear Trimestre";
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
        private TextBox txtNota;
        private Label label3;
    }
}



