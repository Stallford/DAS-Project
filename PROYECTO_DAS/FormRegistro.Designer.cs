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
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArbitro).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(532, 147);
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
            btnEliminar.Location = new Point(419, 147);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(93, 40);
            btnEliminar.TabIndex = 32;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(295, 147);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 40);
            btnGuardar.TabIndex = 31;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(172, 147);
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
            txtId.Location = new Point(642, 63);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 29;
            // 
            // txtEdad
            // 
            txtEdad.Enabled = false;
            txtEdad.Location = new Point(642, 19);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 28;
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.Location = new Point(329, 63);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(194, 23);
            txtContraseña.TabIndex = 27;
            // 
            // txtCorreo
            // 
            txtCorreo.Enabled = false;
            txtCorreo.Location = new Point(329, 19);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(194, 23);
            txtCorreo.TabIndex = 26;
            // 
            // txtApellidos
            // 
            txtApellidos.Enabled = false;
            txtApellidos.Location = new Point(73, 63);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(100, 23);
            txtApellidos.TabIndex = 25;
            // 
            // txtNombres
            // 
            txtNombres.Enabled = false;
            txtNombres.Location = new Point(73, 19);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(100, 23);
            txtNombres.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(603, 66);
            label6.Name = "label6";
            label6.Size = new Size(17, 15);
            label6.TabIndex = 23;
            label6.Text = "Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(603, 22);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 22;
            label5.Text = "Edad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 66);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 21;
            label4.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 22);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 20;
            label3.Text = "Correo Electronico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 66);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 19;
            label2.Text = "Apellidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 22);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 18;
            label1.Text = "Nombres";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(txtEdad);
            groupBox1.Controls.Add(txtContraseña);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(5, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(760, 104);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Arbitro:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(172, 147);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 40);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(btnEditar);
            Controls.Add(dgvArbitro);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Name = "FormRegistro";
            Text = "FormRegistro";
            Load += FormRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArbitro).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox groupBox1;
        private Button btnCancelar;
    }
}