namespace PROYECTO_DAS
{
    partial class FormInicio
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
            button2 = new Button();
            btnIngresar = new Button();
            label3 = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(407, 214);
            button2.Name = "button2";
            button2.Size = new Size(81, 38);
            button2.TabIndex = 13;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(296, 214);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(80, 38);
            btnIngresar.TabIndex = 12;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 47);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 11;
            label3.Text = "Iniciar Sesion";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(366, 162);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 10;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(366, 111);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 165);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 8;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 114);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 7;
            label1.Text = "Usuario";
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btnIngresar);
            Controls.Add(label3);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormInicio";
            Text = "Login";
            Load += FormInicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button btnIngresar;
        private Label label3;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label label2;
        private Label label1;
    }
}