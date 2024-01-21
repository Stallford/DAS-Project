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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            // dgvArbitro
            // 
            dgvArbitro.BackgroundColor = Color.FromArgb(30, 37, 40);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvArbitro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvArbitro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArbitro.Location = new Point(17, 205);
            dgvArbitro.Name = "dgvArbitro";
            dgvArbitro.ReadOnly = true;
            dgvArbitro.RowHeadersWidth = 51;
            dgvArbitro.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgvArbitro.RowTemplate.Height = 25;
            dgvArbitro.Size = new Size(772, 176);
            dgvArbitro.TabIndex = 33;
            dgvArbitro.CellClick += dgvArbitro_CellClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(126, 28, 19);
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.FromArgb(230, 225, 194);
            btnEliminar.Location = new Point(453, 159);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(93, 40);
            btnEliminar.TabIndex = 32;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(30, 37, 40);
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.FromArgb(230, 225, 194);
            btnGuardar.Location = new Point(347, 159);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 40);
            btnGuardar.TabIndex = 31;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(109, 151, 136);
            btnNuevo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.FromArgb(230, 225, 194);
            btnNuevo.Location = new Point(241, 159);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(93, 40);
            btnNuevo.TabIndex = 30;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(706, 77);
            txtId.Name = "txtId";
            txtId.Size = new Size(64, 29);
            txtId.TabIndex = 29;
            // 
            // txtEdad
            // 
            txtEdad.Enabled = false;
            txtEdad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEdad.Location = new Point(706, 33);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(64, 29);
            txtEdad.TabIndex = 28;
            txtEdad.KeyPress += soloNumeros;
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(458, 77);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(194, 29);
            txtContraseña.TabIndex = 27;
            txtContraseña.KeyPress += noEspacio;
            // 
            // txtCorreo
            // 
            txtCorreo.Enabled = false;
            txtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(458, 33);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(194, 29);
            txtCorreo.TabIndex = 26;
            txtCorreo.KeyPress += noEspacio;
            // 
            // txtApellidos
            // 
            txtApellidos.Enabled = false;
            txtApellidos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellidos.Location = new Point(95, 80);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(202, 29);
            txtApellidos.TabIndex = 25;
            txtApellidos.KeyPress += soloAlfabeto;
            // 
            // txtNombres
            // 
            txtNombres.Enabled = false;
            txtNombres.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombres.Location = new Point(95, 33);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(201, 29);
            txtNombres.TabIndex = 24;
            txtNombres.KeyPress += soloAlfabeto;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(674, 82);
            label6.Name = "label6";
            label6.Size = new Size(29, 21);
            label6.TabIndex = 23;
            label6.Text = "Id:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(656, 36);
            label5.Name = "label5";
            label5.Size = new Size(50, 21);
            label5.TabIndex = 22;
            label5.Text = "Edad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(350, 82);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 21;
            label4.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(301, 36);
            label3.Name = "label3";
            label3.Size = new Size(151, 21);
            label3.TabIndex = 20;
            label3.Text = "Correo Electronico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 82);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 19;
            label2.Text = "Apellidos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 36);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 18;
            label1.Text = "Nombres:";
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
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(5, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(783, 129);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Arbitro:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(109, 151, 136);
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.FromArgb(230, 225, 194);
            btnCancelar.Location = new Point(241, 159);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 40);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 384);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(dgvArbitro);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Name = "FormRegistro";
            Text = "Registro de Arbitros";
            Load += FormRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArbitro).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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