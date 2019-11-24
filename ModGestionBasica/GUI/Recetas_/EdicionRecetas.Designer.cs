namespace ModGestionBasica.Recetas_
{
    partial class EdicionRecetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionRecetas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtidreceta = new System.Windows.Forms.TextBox();
            this.txtiddoctor = new System.Windows.Forms.TextBox();
            this.txtidpaciente = new System.Windows.Forms.TextBox();
            this.txtidmedicina = new System.Windows.Forms.TextBox();
            this.txtdocis = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btndoctor = new System.Windows.Forms.Button();
            this.btnpaciente = new System.Windows.Forms.Button();
            this.btnmedicina = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtcantidad = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IDDoctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IDPaciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "IDMedicina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(475, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dosis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad";
            // 
            // txtidreceta
            // 
            this.txtidreceta.Location = new System.Drawing.Point(240, 42);
            this.txtidreceta.Name = "txtidreceta";
            this.txtidreceta.Size = new System.Drawing.Size(100, 20);
            this.txtidreceta.TabIndex = 0;
            // 
            // txtiddoctor
            // 
            this.txtiddoctor.Location = new System.Drawing.Point(240, 102);
            this.txtiddoctor.Name = "txtiddoctor";
            this.txtiddoctor.Size = new System.Drawing.Size(100, 20);
            this.txtiddoctor.TabIndex = 1;
            // 
            // txtidpaciente
            // 
            this.txtidpaciente.Location = new System.Drawing.Point(240, 162);
            this.txtidpaciente.Name = "txtidpaciente";
            this.txtidpaciente.Size = new System.Drawing.Size(100, 20);
            this.txtidpaciente.TabIndex = 3;
            // 
            // txtidmedicina
            // 
            this.txtidmedicina.Location = new System.Drawing.Point(478, 51);
            this.txtidmedicina.Name = "txtidmedicina";
            this.txtidmedicina.Size = new System.Drawing.Size(100, 20);
            this.txtidmedicina.TabIndex = 5;
            // 
            // txtdocis
            // 
            this.txtdocis.Location = new System.Drawing.Point(478, 102);
            this.txtdocis.Name = "txtdocis";
            this.txtdocis.Size = new System.Drawing.Size(100, 20);
            this.txtdocis.TabIndex = 7;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(347, 213);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 9;
            this.btnagregar.Text = "agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(451, 213);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.Text = "cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btndoctor
            // 
            this.btndoctor.Location = new System.Drawing.Point(347, 102);
            this.btndoctor.Name = "btndoctor";
            this.btndoctor.Size = new System.Drawing.Size(114, 23);
            this.btndoctor.TabIndex = 2;
            this.btndoctor.Text = "Cargar Doctor";
            this.btndoctor.UseVisualStyleBackColor = true;
            this.btndoctor.Click += new System.EventHandler(this.btndoctor_Click);
            // 
            // btnpaciente
            // 
            this.btnpaciente.Location = new System.Drawing.Point(347, 159);
            this.btnpaciente.Name = "btnpaciente";
            this.btnpaciente.Size = new System.Drawing.Size(114, 23);
            this.btnpaciente.TabIndex = 4;
            this.btnpaciente.Text = "Cargar Paciente";
            this.btnpaciente.UseVisualStyleBackColor = true;
            this.btnpaciente.Click += new System.EventHandler(this.btnpaciente_Click);
            // 
            // btnmedicina
            // 
            this.btnmedicina.Location = new System.Drawing.Point(585, 48);
            this.btnmedicina.Name = "btnmedicina";
            this.btnmedicina.Size = new System.Drawing.Size(114, 23);
            this.btnmedicina.TabIndex = 6;
            this.btnmedicina.Text = "Cargar Medicina";
            this.btnmedicina.UseVisualStyleBackColor = true;
            this.btnmedicina.Click += new System.EventHandler(this.btnmedicina_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(478, 159);
            this.txtcantidad.Mask = "00";
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(48, 20);
            this.txtcantidad.TabIndex = 12;
            // 
            // EdicionRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(709, 244);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnmedicina);
            this.Controls.Add(this.btnpaciente);
            this.Controls.Add(this.btndoctor);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtdocis);
            this.Controls.Add(this.txtidmedicina);
            this.Controls.Add(this.txtidpaciente);
            this.Controls.Add(this.txtiddoctor);
            this.Controls.Add(this.txtidreceta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EdicionRecetas";
            this.Text = "EdicionRecetas";
            this.Load += new System.EventHandler(this.EdicionRecetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtidreceta;
        private System.Windows.Forms.TextBox txtiddoctor;
        private System.Windows.Forms.TextBox txtidpaciente;
        private System.Windows.Forms.TextBox txtidmedicina;
        private System.Windows.Forms.TextBox txtdocis;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btndoctor;
        private System.Windows.Forms.Button btnpaciente;
        private System.Windows.Forms.Button btnmedicina;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txtcantidad;
    }
}