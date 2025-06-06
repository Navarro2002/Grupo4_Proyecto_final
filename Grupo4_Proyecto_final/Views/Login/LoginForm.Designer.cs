namespace Grupo4_Proyecto_final.Views.Login
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            btnLimpiar = new Button();
            btnIngresar = new Button();
            txtContrasenia = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(134, 149);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 13;
            label3.Text = "Iniciar Sesión";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.GradientInactiveCaption;
            btnLimpiar.Location = new Point(186, 307);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 30);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.GradientInactiveCaption;
            btnIngresar.Location = new Point(84, 307);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(70, 30);
            btnIngresar.TabIndex = 11;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(105, 246);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(173, 23);
            txtContrasenia.TabIndex = 10;
            txtContrasenia.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(101, 184);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(177, 23);
            txtUsuario.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 249);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 8;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 187);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 7;
            label1.Text = "Usuario";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_;
            pictureBox1.Location = new Point(119, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(255, 192, 192);
            btnCerrar.Location = new Point(274, 356);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 30);
            btnCerrar.TabIndex = 15;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // LoginForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(361, 398);
            Controls.Add(btnCerrar);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnLimpiar;
        private Button btnIngresar;
        private TextBox txtContrasenia;
        private TextBox txtUsuario;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnCerrar;
    }
}