namespace ModGestionBasica.Doctores
{
    partial class EdicionDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionDoctor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtididoctor = new System.Windows.Forms.TextBox();
            this.txtidem = new System.Windows.Forms.TextBox();
            this.txtidespecialidad = new System.Windows.Forms.TextBox();
            this.txtturno = new System.Windows.Forms.ComboBox();
            this.btnempleado = new System.Windows.Forms.Button();
            this.btnespecialidad = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Especialidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Turno";
            // 
            // txtididoctor
            // 
            this.txtididoctor.Location = new System.Drawing.Point(243, 45);
            this.txtididoctor.Name = "txtididoctor";
            this.txtididoctor.ReadOnly = true;
            this.txtididoctor.Size = new System.Drawing.Size(51, 20);
            this.txtididoctor.TabIndex = 0;
            // 
            // txtidem
            // 
            this.txtidem.Location = new System.Drawing.Point(243, 109);
            this.txtidem.Name = "txtidem";
            this.txtidem.Size = new System.Drawing.Size(133, 20);
            this.txtidem.TabIndex = 1;
            // 
            // txtidespecialidad
            // 
            this.txtidespecialidad.Location = new System.Drawing.Point(243, 171);
            this.txtidespecialidad.Name = "txtidespecialidad";
            this.txtidespecialidad.Size = new System.Drawing.Size(133, 20);
            this.txtidespecialidad.TabIndex = 3;
            // 
            // txtturno
            // 
            this.txtturno.FormattingEnabled = true;
            this.txtturno.Items.AddRange(new object[] {
            "Diurno",
            "Nocturno",
            "Mixto"});
            this.txtturno.Location = new System.Drawing.Point(243, 211);
            this.txtturno.Name = "txtturno";
            this.txtturno.Size = new System.Drawing.Size(121, 21);
            this.txtturno.TabIndex = 5;
            // 
            // btnempleado
            // 
            this.btnempleado.Location = new System.Drawing.Point(394, 106);
            this.btnempleado.Name = "btnempleado";
            this.btnempleado.Size = new System.Drawing.Size(111, 23);
            this.btnempleado.TabIndex = 2;
            this.btnempleado.Text = "Cargar Empleados";
            this.btnempleado.UseVisualStyleBackColor = true;
            this.btnempleado.Click += new System.EventHandler(this.btnempleado_Click);
            // 
            // btnespecialidad
            // 
            this.btnespecialidad.Location = new System.Drawing.Point(394, 168);
            this.btnespecialidad.Name = "btnespecialidad";
            this.btnespecialidad.Size = new System.Drawing.Size(111, 23);
            this.btnespecialidad.TabIndex = 4;
            this.btnespecialidad.Text = "Cargar Especialiad";
            this.btnespecialidad.UseVisualStyleBackColor = true;
            this.btnespecialidad.Click += new System.EventHandler(this.btnespecialidad_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(261, 260);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(79, 29);
            this.btnagregar.TabIndex = 6;
            this.btnagregar.Text = "Agreagr";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(373, 260);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(79, 29);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // EdicionDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(517, 301);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnespecialidad);
            this.Controls.Add(this.btnempleado);
            this.Controls.Add(this.txtturno);
            this.Controls.Add(this.txtidespecialidad);
            this.Controls.Add(this.txtidem);
            this.Controls.Add(this.txtididoctor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EdicionDoctor";
            this.Text = "EdicionDoctor";
            this.Load += new System.EventHandler(this.EdicionDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtturno;
        private System.Windows.Forms.Button btnempleado;
        private System.Windows.Forms.Button btnespecialidad;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.TextBox txtididoctor;
        public System.Windows.Forms.TextBox txtidem;
        public System.Windows.Forms.TextBox txtidespecialidad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}