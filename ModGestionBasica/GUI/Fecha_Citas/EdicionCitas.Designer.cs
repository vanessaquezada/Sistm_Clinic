namespace ModGestionBasica.Fecha_Citas
{
    partial class EdicionCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionCitas));
            this.txtidcita = new System.Windows.Forms.TextBox();
            this.txtidpaciente = new System.Windows.Forms.TextBox();
            this.txtiddoctor = new System.Windows.Forms.TextBox();
            this.txtidconsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnpaciente = new System.Windows.Forms.Button();
            this.btndoctor = new System.Windows.Forms.Button();
            this.btnmedicina = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtidcita
            // 
            this.txtidcita.Location = new System.Drawing.Point(276, 59);
            this.txtidcita.Name = "txtidcita";
            this.txtidcita.ReadOnly = true;
            this.txtidcita.Size = new System.Drawing.Size(47, 20);
            this.txtidcita.TabIndex = 0;
            // 
            // txtidpaciente
            // 
            this.txtidpaciente.Location = new System.Drawing.Point(276, 123);
            this.txtidpaciente.Name = "txtidpaciente";
            this.txtidpaciente.Size = new System.Drawing.Size(47, 20);
            this.txtidpaciente.TabIndex = 1;
            // 
            // txtiddoctor
            // 
            this.txtiddoctor.Location = new System.Drawing.Point(276, 171);
            this.txtiddoctor.Name = "txtiddoctor";
            this.txtiddoctor.Size = new System.Drawing.Size(47, 20);
            this.txtiddoctor.TabIndex = 3;
            // 
            // txtidconsulta
            // 
            this.txtidconsulta.Location = new System.Drawing.Point(520, 56);
            this.txtidconsulta.Name = "txtidconsulta";
            this.txtidconsulta.Size = new System.Drawing.Size(56, 20);
            this.txtidconsulta.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "IDPaciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "IDDoctor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha Proxima cita";
            // 
            // btnpaciente
            // 
            this.btnpaciente.Location = new System.Drawing.Point(382, 119);
            this.btnpaciente.Name = "btnpaciente";
            this.btnpaciente.Size = new System.Drawing.Size(104, 23);
            this.btnpaciente.TabIndex = 2;
            this.btnpaciente.Text = "Cargar Pacientes";
            this.btnpaciente.UseVisualStyleBackColor = true;
            this.btnpaciente.Click += new System.EventHandler(this.btnpaciente_Click);
            // 
            // btndoctor
            // 
            this.btndoctor.Location = new System.Drawing.Point(382, 171);
            this.btndoctor.Name = "btndoctor";
            this.btndoctor.Size = new System.Drawing.Size(104, 23);
            this.btndoctor.TabIndex = 4;
            this.btndoctor.Text = "Cargar Doctores";
            this.btndoctor.UseVisualStyleBackColor = true;
            this.btndoctor.Click += new System.EventHandler(this.btndoctor_Click);
            // 
            // btnmedicina
            // 
            this.btnmedicina.Location = new System.Drawing.Point(624, 53);
            this.btnmedicina.Name = "btnmedicina";
            this.btnmedicina.Size = new System.Drawing.Size(104, 23);
            this.btnmedicina.TabIndex = 6;
            this.btnmedicina.Text = "Cargar Consultas";
            this.btnmedicina.UseVisualStyleBackColor = true;
            this.btnmedicina.Click += new System.EventHandler(this.btnmedicina_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(334, 225);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(104, 23);
            this.btnagregar.TabIndex = 8;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(496, 225);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(104, 23);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "IDConsulta";
            // 
            // txtfecha
            // 
            this.txtfecha.CustomFormat = "yyyy-MM-dd";
            this.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtfecha.Location = new System.Drawing.Point(521, 165);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(164, 20);
            this.txtfecha.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // EdicionCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(735, 263);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnmedicina);
            this.Controls.Add(this.btndoctor);
            this.Controls.Add(this.btnpaciente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidconsulta);
            this.Controls.Add(this.txtiddoctor);
            this.Controls.Add(this.txtidpaciente);
            this.Controls.Add(this.txtidcita);
            this.Name = "EdicionCitas";
            this.Text = "EdicionCitas";
            this.Load += new System.EventHandler(this.EdicionCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtidcita;
        private System.Windows.Forms.TextBox txtidpaciente;
        private System.Windows.Forms.TextBox txtiddoctor;
        private System.Windows.Forms.TextBox txtidconsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnpaciente;
        private System.Windows.Forms.Button btndoctor;
        private System.Windows.Forms.Button btnmedicina;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtfecha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}