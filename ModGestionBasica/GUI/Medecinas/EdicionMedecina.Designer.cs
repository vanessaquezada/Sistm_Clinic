namespace ModGestionBasica.Medecinas
{
    partial class EdicionMedecina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionMedecina));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtidmedicina = new System.Windows.Forms.TextBox();
            this.txtmedicamento = new System.Windows.Forms.TextBox();
            this.txtconcentrado = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtforma = new System.Windows.Forms.ComboBox();
            this.txtvia = new System.Windows.Forms.ComboBox();
            this.txtestado = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medicamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Concentrado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Forma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Via";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado";
            // 
            // txtidmedicina
            // 
            this.txtidmedicina.Location = new System.Drawing.Point(204, 39);
            this.txtidmedicina.Name = "txtidmedicina";
            this.txtidmedicina.ReadOnly = true;
            this.txtidmedicina.Size = new System.Drawing.Size(38, 20);
            this.txtidmedicina.TabIndex = 0;
            // 
            // txtmedicamento
            // 
            this.txtmedicamento.Location = new System.Drawing.Point(204, 86);
            this.txtmedicamento.Name = "txtmedicamento";
            this.txtmedicamento.Size = new System.Drawing.Size(169, 20);
            this.txtmedicamento.TabIndex = 1;
            this.txtmedicamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmedicamento_KeyPress);
            // 
            // txtconcentrado
            // 
            this.txtconcentrado.Location = new System.Drawing.Point(204, 137);
            this.txtconcentrado.Name = "txtconcentrado";
            this.txtconcentrado.Size = new System.Drawing.Size(169, 20);
            this.txtconcentrado.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(310, 180);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(404, 180);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // txtforma
            // 
            this.txtforma.FormattingEnabled = true;
            this.txtforma.Items.AddRange(new object[] {
            "Solución Inyectable",
            "Comprimidos",
            "Solución Oral",
            "Cápsulas/Tabletas",
            "Suspensión Oral",
            "Ungüento",
            "Crema"});
            this.txtforma.Location = new System.Drawing.Point(435, 39);
            this.txtforma.Name = "txtforma";
            this.txtforma.Size = new System.Drawing.Size(153, 21);
            this.txtforma.TabIndex = 3;
            // 
            // txtvia
            // 
            this.txtvia.FormattingEnabled = true;
            this.txtvia.Items.AddRange(new object[] {
            "Intramuscular",
            "Intravenosa",
            "Oral",
            "Subcutánea",
            "Tópica"});
            this.txtvia.Location = new System.Drawing.Point(435, 79);
            this.txtvia.Name = "txtvia";
            this.txtvia.Size = new System.Drawing.Size(153, 21);
            this.txtvia.TabIndex = 4;
            // 
            // txtestado
            // 
            this.txtestado.FormattingEnabled = true;
            this.txtestado.Items.AddRange(new object[] {
            "Activa",
            "Inactiva"});
            this.txtestado.Location = new System.Drawing.Point(435, 126);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(153, 21);
            this.txtestado.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // EdicionMedecina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(604, 213);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.txtvia);
            this.Controls.Add(this.txtforma);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtconcentrado);
            this.Controls.Add(this.txtmedicamento);
            this.Controls.Add(this.txtidmedicina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EdicionMedecina";
            this.Text = "EdicionMedecina";
            this.Load += new System.EventHandler(this.EdicionMedecina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtidmedicina;
        public System.Windows.Forms.TextBox txtmedicamento;
        public System.Windows.Forms.TextBox txtconcentrado;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.ComboBox txtforma;
        public System.Windows.Forms.ComboBox txtvia;
        public System.Windows.Forms.ComboBox txtestado;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}