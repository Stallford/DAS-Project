namespace Presentacion.Formularios
{
    partial class FrmSituaciones
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbNombre = new ComboBox();
            txtApellidos = new TextBox();
            txtCedula = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtLocal = new TextBox();
            txtVisitante = new TextBox();
            cmbLugar = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            rtxJustificante = new RichTextBox();
            groupBox3 = new GroupBox();
            btnLimpiar = new Button();
            btnEnviar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 35);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 83);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 1;
            label2.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 129);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 2;
            label3.Text = "Cédula:";
            // 
            // cmbNombre
            // 
            cmbNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbNombre.FormattingEnabled = true;
            cmbNombre.Location = new Point(93, 32);
            cmbNombre.Name = "cmbNombre";
            cmbNombre.Size = new Size(231, 29);
            cmbNombre.TabIndex = 3;
            // 
            // txtApellidos
            // 
            txtApellidos.Enabled = false;
            txtApellidos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellidos.Location = new Point(93, 80);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(231, 29);
            txtApellidos.TabIndex = 4;
            // 
            // txtCedula
            // 
            txtCedula.Enabled = false;
            txtCedula.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCedula.Location = new Point(93, 129);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(231, 29);
            txtCedula.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCedula);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(cmbNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(16, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 189);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Solicitante:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtLocal);
            groupBox2.Controls.Add(txtVisitante);
            groupBox2.Controls.Add(cmbLugar);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(389, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(392, 189);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Partido Asignado:";
            // 
            // txtLocal
            // 
            txtLocal.Enabled = false;
            txtLocal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLocal.Location = new Point(141, 129);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(231, 29);
            txtLocal.TabIndex = 5;
            // 
            // txtVisitante
            // 
            txtVisitante.Enabled = false;
            txtVisitante.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtVisitante.Location = new Point(141, 79);
            txtVisitante.Name = "txtVisitante";
            txtVisitante.Size = new Size(231, 29);
            txtVisitante.TabIndex = 4;
            // 
            // cmbLugar
            // 
            cmbLugar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbLugar.FormattingEnabled = true;
            cmbLugar.Location = new Point(141, 32);
            cmbLugar.Name = "cmbLugar";
            cmbLugar.Size = new Size(231, 29);
            cmbLugar.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(34, 129);
            label4.Name = "label4";
            label4.Size = new Size(101, 21);
            label4.TabIndex = 2;
            label4.Text = "Equipo Local:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 82);
            label5.Name = "label5";
            label5.Size = new Size(125, 21);
            label5.TabIndex = 1;
            label5.Text = "Equipo Visitante:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(82, 35);
            label6.Name = "label6";
            label6.Size = new Size(53, 21);
            label6.TabIndex = 0;
            label6.Text = "Lugar:";
            // 
            // rtxJustificante
            // 
            rtxJustificante.Enabled = false;
            rtxJustificante.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtxJustificante.Location = new Point(6, 28);
            rtxJustificante.Name = "rtxJustificante";
            rtxJustificante.Size = new Size(753, 123);
            rtxJustificante.TabIndex = 8;
            rtxJustificante.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rtxJustificante);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(16, 225);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(765, 162);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Justificante:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(30, 37, 40);
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.FromArgb(230, 225, 194);
            btnLimpiar.Location = new Point(409, 408);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(102, 31);
            btnLimpiar.TabIndex = 31;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(109, 151, 136);
            btnEnviar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnviar.ForeColor = Color.FromArgb(230, 225, 194);
            btnEnviar.Location = new Point(275, 408);
            btnEnviar.Margin = new Padding(3, 2, 3, 2);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(102, 31);
            btnEnviar.TabIndex = 30;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            // 
            // FrmSituaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEnviar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmSituaciones";
            Text = "FrmSituaciones";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbNombre;
        private TextBox txtApellidos;
        private TextBox txtCedula;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtLocal;
        private TextBox txtVisitante;
        private ComboBox cmbLugar;
        private Label label4;
        private Label label5;
        private Label label6;
        private RichTextBox rtxJustificante;
        private GroupBox groupBox3;
        private Button btnLimpiar;
        private Button btnEnviar;
    }
}