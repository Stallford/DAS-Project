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
            btnHistorial.Location = new Point(455, 273);
            btnHistorial.Margin = new Padding(3, 4, 3, 4);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(241, 51);
            btnHistorial.TabIndex = 13;
            btnHistorial.Text = "Consulta de historial";
            btnHistorial.UseVisualStyleBackColor = false;
            // 
            // btnActas
            // 
            btnActas.BackColor = Color.FromArgb(109, 151, 136);
            btnActas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnActas.ForeColor = Color.FromArgb(230, 225, 194);
            btnActas.Location = new Point(455, 173);
            btnActas.Margin = new Padding(3, 4, 3, 4);
            btnActas.Name = "btnActas";
            btnActas.Size = new Size(241, 51);
            btnActas.TabIndex = 12;
            btnActas.Text = "Ingreso de actas";
            btnActas.UseVisualStyleBackColor = false;
            // 
            // btnSituaciones
            // 
            btnSituaciones.BackColor = Color.FromArgb(126, 28, 19);
            btnSituaciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSituaciones.ForeColor = Color.FromArgb(230, 225, 194);
            btnSituaciones.Location = new Point(455, 82);
            btnSituaciones.Margin = new Padding(3, 4, 3, 4);
            btnSituaciones.Name = "btnSituaciones";
            btnSituaciones.Size = new Size(241, 51);
            btnSituaciones.TabIndex = 11;
            btnSituaciones.Text = "Registro de situaciones";
            btnSituaciones.UseVisualStyleBackColor = false;
            // 
            // btnNotificaciones
            // 
            btnNotificaciones.BackColor = Color.FromArgb(191, 10, 13);
            btnNotificaciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNotificaciones.ForeColor = Color.FromArgb(230, 225, 194);
            btnNotificaciones.Location = new Point(278, 372);
            btnNotificaciones.Margin = new Padding(3, 4, 3, 4);
            btnNotificaciones.Name = "btnNotificaciones";
            btnNotificaciones.Size = new Size(241, 51);
            btnNotificaciones.TabIndex = 10;
            btnNotificaciones.Text = "Notificaciones";
            btnNotificaciones.UseVisualStyleBackColor = false;
            // 
            // btnAsignacion
            // 
            btnAsignacion.BackColor = Color.FromArgb(126, 28, 19);
            btnAsignacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAsignacion.ForeColor = Color.FromArgb(230, 225, 194);
            btnAsignacion.Location = new Point(92, 273);
            btnAsignacion.Margin = new Padding(3, 4, 3, 4);
            btnAsignacion.Name = "btnAsignacion";
            btnAsignacion.Size = new Size(241, 51);
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
            btnCalendario.Location = new Point(92, 173);
            btnCalendario.Margin = new Padding(3, 4, 3, 4);
            btnCalendario.Name = "btnCalendario";
            btnCalendario.Size = new Size(241, 51);
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
            btnRegistro.Location = new Point(92, 82);
            btnRegistro.Margin = new Padding(3, 4, 3, 4);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(241, 51);
            btnRegistro.TabIndex = 7;
            btnRegistro.Text = "Registro de arbitro";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(781, 468);
            Controls.Add(btnHistorial);
            Controls.Add(btnActas);
            Controls.Add(btnSituaciones);
            Controls.Add(btnNotificaciones);
            Controls.Add(btnAsignacion);
            Controls.Add(btnCalendario);
            Controls.Add(btnRegistro);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMenu";
            Text = "FormMenu";
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