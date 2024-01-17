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
            dgvArbitro.Location = new Point(19, 273);
            dgvArbitro.Margin = new Padding(3, 4, 3, 4);
            dgvArbitro.Name = "dgvArbitro";
            dgvArbitro.RowHeadersWidth = 51;
            dgvArbitro.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgvArbitro.RowTemplate.Height = 25;
            dgvArbitro.Size = new Size(882, 235);
            dgvArbitro.TabIndex = 33;
            dgvArbitro.CellClick += dgvArbitro_CellClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(126, 28, 19);
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.FromArgb(230, 225, 194);
            btnEliminar.Location = new Point(518, 212);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(106, 53);
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
            btnGuardar.Location = new Point(397, 212);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 53);
            btnGuardar.TabIndex = 31;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.Location = new Point(275, 212);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(106, 53);
            btnNuevo.TabIndex = 30;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(807, 103);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(73, 34);
            txtId.TabIndex = 29;
            // 
            // txtEdad
            // 
            txtEdad.Enabled = false;
            txtEdad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEdad.Location = new Point(807, 44);
            txtEdad.Margin = new Padding(3, 4, 3, 4);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(73, 34);
            txtEdad.TabIndex = 28;
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(523, 103);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(221, 34);
            txtContraseña.TabIndex = 27;
            // 
            // txtCorreo
            // 
            txtCorreo.Enabled = false;
            txtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(523, 44);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(221, 34);
            txtCorreo.TabIndex = 26;
            // 
            // txtApellidos
            // 
            txtApellidos.Enabled = false;
            txtApellidos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellidos.Location = new Point(109, 106);
            txtApellidos.Margin = new Padding(3, 4, 3, 4);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(230, 34);
            txtApellidos.TabIndex = 25;
            // 
            // txtNombres
            // 
            txtNombres.Enabled = false;
            txtNombres.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombres.Location = new Point(109, 44);
            txtNombres.Margin = new Padding(3, 4, 3, 4);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(229, 34);
            txtNombres.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(770, 109);
            label6.Name = "label6";
            label6.Size = new Size(35, 28);
            label6.TabIndex = 23;
            label6.Text = "Id:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(750, 48);
            label5.Name = "label5";
            label5.Size = new Size(61, 28);
            label5.TabIndex = 22;
            label5.Text = "Edad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(400, 109);
            label4.Name = "label4";
            label4.Size = new Size(119, 28);
            label4.TabIndex = 21;
            label4.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(344, 48);
            label3.Name = "label3";
            label3.Size = new Size(183, 28);
            label3.TabIndex = 20;
            label3.Text = "Correo Electronico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 109);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 19;
            label2.Text = "Apellidos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 48);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
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
            groupBox1.Location = new Point(6, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(895, 172);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Arbitro:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(109, 151, 136);
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.FromArgb(230, 225, 194);
            btnCancelar.Location = new Point(275, 212);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 53);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 512);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(dgvArbitro);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRegistro";
            Text = "FormRegistro";
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