namespace PROYECTO_DAS
{
    partial class FormRegistro
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
            btnEditar = new Button();
            dgvArbitro = new DataGridView();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            txtId = new TextBox();
            txtEdad = new TextBox();
            txtContraseña = new TextBox();
            txtCorreo = new TextBox();
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvArbitro).BeginInit();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(627, 131);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(93, 40);
            btnEditar.TabIndex = 34;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // dgvArbitro
            // 
            dgvArbitro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArbitro.Location = new Point(16, 214);
            dgvArbitro.Name = "dgvArbitro";
            dgvArbitro.RowTemplate.Height = 25;
            dgvArbitro.Size = new Size(731, 202);
            dgvArbitro.TabIndex = 33;
            dgvArbitro.CellClick += dgvArbitro_CellClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(514, 131);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(93, 40);
            btnEliminar.TabIndex = 32;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(390, 131);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 40);
            btnGuardar.TabIndex = 31;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(267, 131);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(93, 40);
            btnNuevo.TabIndex = 30;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(647, 67);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 29;
            // 
            // txtEdad
            // 
            txtEdad.Enabled = false;
            txtEdad.Location = new Point(647, 23);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 28;
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.Location = new Point(334, 67);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(194, 23);
            txtContraseña.TabIndex = 27;
            // 
            // txtCorreo
            // 
            txtCorreo.Enabled = false;
            txtCorreo.Location = new Point(334, 23);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(194, 23);
            txtCorreo.TabIndex = 26;
            // 
            // txtApellidos
            // 
            txtApellidos.Enabled = false;
            txtApellidos.Location = new Point(78, 67);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(100, 23);
            txtApellidos.TabIndex = 25;
            // 
            // txtNombres
            // 
            txtNombres.Enabled = false;
            txtNombres.Location = new Point(78, 23);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(100, 23);
            txtNombres.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(608, 70);
            label6.Name = "label6";
            label6.Size = new Size(17, 15);
            label6.TabIndex = 23;
            label6.Text = "Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(608, 26);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 22;
            label5.Text = "Edad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 70);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 21;
            label4.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 26);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 20;
            label3.Text = "Correo Electronico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 70);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 19;
            label2.Text = "Apellidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 26);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 18;
            label1.Text = "Nombres";
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditar);
            Controls.Add(dgvArbitro);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtId);
            Controls.Add(txtEdad);
            Controls.Add(txtContraseña);
            Controls.Add(txtCorreo);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRegistro";
            Text = "FormRegistro";
            Load += FormRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArbitro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditar;
        private DataGridView dgvArbitro;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
        private TextBox txtId;
        private TextBox txtEdad;
        private TextBox txtContraseña;
        private TextBox txtCorreo;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}