﻿namespace PROYECTO_DAS
{
    partial class FormCalendario
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
            dataGridView1 = new DataGridView();
            btnEliminar = new Button();
            btnNuevo = new Button();
            btnGuardar = new Button();
            txtEstadio = new TextBox();
            txtClubvisitante = new TextBox();
            txtClublocal = new TextBox();
            dtpHora = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            monthCalendar1 = new MonthCalendar();
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(17, 317);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(754, 180);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(459, 261);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(96, 40);
            btnEliminar.TabIndex = 28;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.Location = new Point(219, 261);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(96, 40);
            btnNuevo.TabIndex = 26;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(335, 261);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(96, 40);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtEstadio
            // 
            txtEstadio.Enabled = false;
            txtEstadio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEstadio.Location = new Point(506, 69);
            txtEstadio.Name = "txtEstadio";
            txtEstadio.Size = new Size(265, 29);
            txtEstadio.TabIndex = 24;
            // 
            // txtClubvisitante
            // 
            txtClubvisitante.Enabled = false;
            txtClubvisitante.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtClubvisitante.Location = new Point(506, 163);
            txtClubvisitante.Name = "txtClubvisitante";
            txtClubvisitante.Size = new Size(265, 29);
            txtClubvisitante.TabIndex = 23;
            // 
            // txtClublocal
            // 
            txtClublocal.Enabled = false;
            txtClublocal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtClublocal.Location = new Point(506, 114);
            txtClublocal.Name = "txtClublocal";
            txtClublocal.Size = new Size(265, 29);
            txtClublocal.TabIndex = 22;
            // 
            // dtpHora
            // 
            dtpHora.CustomFormat = "";
            dtpHora.Enabled = false;
            dtpHora.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(506, 24);
            dtpHora.Name = "dtpHora";
            dtpHora.Size = new Size(265, 29);
            dtpHora.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(350, 72);
            label5.Name = "label5";
            label5.Size = new Size(150, 21);
            label5.TabIndex = 20;
            label5.Text = "Nombre del estadio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(309, 166);
            label4.Name = "label4";
            label4.Size = new Size(191, 21);
            label4.TabIndex = 19;
            label4.Text = "Nombre del club visitante:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(335, 117);
            label3.Name = "label3";
            label3.Size = new Size(165, 21);
            label3.TabIndex = 18;
            label3.Text = "Nombre del club local:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(354, 30);
            label2.Name = "label2";
            label2.Size = new Size(146, 21);
            label2.TabIndex = 17;
            label2.Text = "Hora del encuentro:";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Enabled = false;
            monthCalendar1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            monthCalendar1.Location = new Point(17, 30);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEstadio);
            groupBox1.Controls.Add(txtClubvisitante);
            groupBox1.Controls.Add(txtClublocal);
            groupBox1.Controls.Add(dtpHora);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(monthCalendar1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(778, 217);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fecha del encuentro:";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(219, 261);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 40);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormCalendario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(btnGuardar);
            Name = "FormCalendario";
            Text = "FormCalendario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button btnGuardar;
        private TextBox txtEstadio;
        private TextBox txtClubvisitante;
        private TextBox txtClublocal;
        private DateTimePicker dtpHora;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private MonthCalendar monthCalendar1;
        private GroupBox groupBox1;
        private Button btnCancelar;
    }
}