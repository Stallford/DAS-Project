namespace PROYECTO_DAS
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
            dataGridView1 = new DataGridView();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            btnGuardar = new Button();
            txtEstadio = new TextBox();
            txtClubvisitante = new TextBox();
            txtClublocal = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 317);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(754, 150);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(657, 256);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(96, 40);
            btnEliminar.TabIndex = 28;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(401, 256);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(96, 40);
            btnEditar.TabIndex = 27;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(272, 256);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(96, 40);
            btnNuevo.TabIndex = 26;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(533, 256);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(96, 40);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtEstadio
            // 
            txtEstadio.Location = new Point(490, 178);
            txtEstadio.Name = "txtEstadio";
            txtEstadio.Size = new Size(200, 23);
            txtEstadio.TabIndex = 24;
            // 
            // txtClubvisitante
            // 
            txtClubvisitante.Location = new Point(490, 133);
            txtClubvisitante.Name = "txtClubvisitante";
            txtClubvisitante.Size = new Size(200, 23);
            txtClubvisitante.TabIndex = 23;
            // 
            // txtClublocal
            // 
            txtClublocal.Location = new Point(490, 89);
            txtClublocal.Name = "txtClublocal";
            txtClublocal.Size = new Size(200, 23);
            txtClublocal.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(490, 47);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(338, 181);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 20;
            label5.Text = "Nombre del estadio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(338, 136);
            label4.Name = "label4";
            label4.Size = new Size(146, 15);
            label4.TabIndex = 19;
            label4.Text = "Nombre del club visitante ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 92);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 18;
            label3.Text = "Nombre del club local";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 53);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 17;
            label2.Text = "Hora del encuentro";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(17, 53);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 20);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 15;
            label1.Text = "Fecha de encuentro";
            // 
            // FormCalendario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(btnGuardar);
            Controls.Add(txtEstadio);
            Controls.Add(txtClubvisitante);
            Controls.Add(txtClublocal);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(monthCalendar1);
            Controls.Add(label1);
            Name = "FormCalendario";
            Text = "FormCalendario";
            Load += FormCalendario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnNuevo;
        private Button btnGuardar;
        private TextBox txtEstadio;
        private TextBox txtClubvisitante;
        private TextBox txtClublocal;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private MonthCalendar monthCalendar1;
        private Label label1;
    }
}