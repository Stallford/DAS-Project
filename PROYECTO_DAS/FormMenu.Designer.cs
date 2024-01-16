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
            btnHistorial.Location = new Point(424, 204);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(141, 23);
            btnHistorial.TabIndex = 13;
            btnHistorial.Text = "Consulta de historial";
            btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnActas
            // 
            btnActas.Location = new Point(424, 129);
            btnActas.Name = "btnActas";
            btnActas.Size = new Size(141, 23);
            btnActas.TabIndex = 12;
            btnActas.Text = "Ingreso de actas";
            btnActas.UseVisualStyleBackColor = true;
            // 
            // btnSituaciones
            // 
            btnSituaciones.Location = new Point(424, 61);
            btnSituaciones.Name = "btnSituaciones";
            btnSituaciones.Size = new Size(141, 23);
            btnSituaciones.TabIndex = 11;
            btnSituaciones.Text = "Registro de situaciones";
            btnSituaciones.UseVisualStyleBackColor = true;
            // 
            // btnNotificaciones
            // 
            btnNotificaciones.Location = new Point(107, 264);
            btnNotificaciones.Name = "btnNotificaciones";
            btnNotificaciones.Size = new Size(141, 23);
            btnNotificaciones.TabIndex = 10;
            btnNotificaciones.Text = "Notificaciones";
            btnNotificaciones.UseVisualStyleBackColor = true;
            // 
            // btnAsignacion
            // 
            btnAsignacion.Location = new Point(107, 204);
            btnAsignacion.Name = "btnAsignacion";
            btnAsignacion.Size = new Size(141, 23);
            btnAsignacion.TabIndex = 9;
            btnAsignacion.Text = "Asignacion de arbitros";
            btnAsignacion.UseVisualStyleBackColor = true;
            btnAsignacion.Click += btnAsignacion_Click;
            // 
            // btnCalendario
            // 
            btnCalendario.Location = new Point(107, 129);
            btnCalendario.Name = "btnCalendario";
            btnCalendario.Size = new Size(141, 23);
            btnCalendario.TabIndex = 8;
            btnCalendario.Text = "Registro de calendario";
            btnCalendario.UseVisualStyleBackColor = true;
            btnCalendario.Click += btnCalendario_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(107, 61);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(141, 23);
            btnRegistro.TabIndex = 7;
            btnRegistro.Text = "Registro de arbitro";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHistorial);
            Controls.Add(btnActas);
            Controls.Add(btnSituaciones);
            Controls.Add(btnNotificaciones);
            Controls.Add(btnAsignacion);
            Controls.Add(btnCalendario);
            Controls.Add(btnRegistro);
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