namespace PROYECTO_DAS
{
    partial class FormMenu
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
            btnHistorial = new Button();
            btnActas = new Button();
            btnSituaciones = new Button();
            btnNotificaciones = new Button();
            btnAsignacion = new Button();
            btnCalendario = new Button();
            btnRegistro = new Button();
            SuspendLayout();
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.FromArgb(30, 37, 40);
            btnHistorial.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistorial.ForeColor = Color.FromArgb(230, 225, 194);
            btnHistorial.Location = new Point(398, 205);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(211, 38);
            btnHistorial.TabIndex = 13;
            btnHistorial.Text = "Consulta de historial";
            btnHistorial.UseVisualStyleBackColor = false;
            // 
            // btnActas
            // 
            btnActas.BackColor = Color.FromArgb(109, 151, 136);
            btnActas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnActas.ForeColor = Color.FromArgb(230, 225, 194);
            btnActas.Location = new Point(398, 130);
            btnActas.Name = "btnActas";
            btnActas.Size = new Size(211, 38);
            btnActas.TabIndex = 12;
            btnActas.Text = "Ingreso de actas";
            btnActas.UseVisualStyleBackColor = false;
            // 
            // btnSituaciones
            // 
            btnSituaciones.BackColor = Color.FromArgb(126, 28, 19);
            btnSituaciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSituaciones.ForeColor = Color.FromArgb(230, 225, 194);
            btnSituaciones.Location = new Point(398, 62);
            btnSituaciones.Name = "btnSituaciones";
            btnSituaciones.Size = new Size(211, 38);
            btnSituaciones.TabIndex = 11;
            btnSituaciones.Text = "Registro de situaciones";
            btnSituaciones.UseVisualStyleBackColor = false;
            btnSituaciones.Click += btnSituaciones_Click;
            // 
            // btnNotificaciones
            // 
            btnNotificaciones.BackColor = Color.FromArgb(191, 10, 13);
            btnNotificaciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNotificaciones.ForeColor = Color.FromArgb(230, 225, 194);
            btnNotificaciones.Location = new Point(243, 279);
            btnNotificaciones.Name = "btnNotificaciones";
            btnNotificaciones.Size = new Size(211, 38);
            btnNotificaciones.TabIndex = 10;
            btnNotificaciones.Text = "Notificaciones";
            btnNotificaciones.UseVisualStyleBackColor = false;
            // 
            // btnAsignacion
            // 
            btnAsignacion.BackColor = Color.FromArgb(126, 28, 19);
            btnAsignacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAsignacion.ForeColor = Color.FromArgb(230, 225, 194);
            btnAsignacion.Location = new Point(80, 205);
            btnAsignacion.Name = "btnAsignacion";
            btnAsignacion.Size = new Size(211, 38);
            btnAsignacion.TabIndex = 9;
            btnAsignacion.Text = "Asignacion de arbitros";
            btnAsignacion.UseVisualStyleBackColor = false;
            btnAsignacion.Click += btnAsignacion_Click;
            // 
            // btnCalendario
            // 
            btnCalendario.BackColor = Color.FromArgb(30, 37, 40);
            btnCalendario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalendario.ForeColor = Color.FromArgb(230, 225, 194);
            btnCalendario.Location = new Point(80, 130);
            btnCalendario.Name = "btnCalendario";
            btnCalendario.Size = new Size(211, 38);
            btnCalendario.TabIndex = 8;
            btnCalendario.Text = "Registro de calendario";
            btnCalendario.UseVisualStyleBackColor = false;
            btnCalendario.Click += btnCalendario_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.FromArgb(109, 151, 136);
            btnRegistro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistro.ForeColor = Color.FromArgb(230, 225, 194);
            btnRegistro.Location = new Point(80, 62);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(211, 38);
            btnRegistro.TabIndex = 7;
            btnRegistro.Text = "Registro de arbitro";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(683, 351);
            Controls.Add(btnHistorial);
            Controls.Add(btnActas);
            Controls.Add(btnSituaciones);
            Controls.Add(btnNotificaciones);
            Controls.Add(btnAsignacion);
            Controls.Add(btnCalendario);
            Controls.Add(btnRegistro);
            Name = "FormMenu";
            Text = "Menu";
            Load += FormMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnHistorial;
        private Button btnActas;
        private Button btnSituaciones;
        private Button btnNotificaciones;
        private Button btnAsignacion;
        private Button btnCalendario;
        private Button btnRegistro;
    }
}