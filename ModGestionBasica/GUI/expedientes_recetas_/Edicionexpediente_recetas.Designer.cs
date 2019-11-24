namespace ModGestionBasica.expedientes_recetas_
{
    partial class Edicionexpediente_recetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edicionexpediente_recetas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtidexpediente = new System.Windows.Forms.TextBox();
            this.txtidreceta = new System.Windows.Forms.TextBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnexpediente = new System.Windows.Forms.Button();
            this.btnrecetas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IDExpediente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IDReceta";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(234, 26);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(38, 20);
            this.txtid.TabIndex = 0;
            // 
            // txtidexpediente
            // 
            this.txtidexpediente.Location = new System.Drawing.Point(234, 94);
            this.txtidexpediente.Name = "txtidexpediente";
            this.txtidexpediente.Size = new System.Drawing.Size(38, 20);
            this.txtidexpediente.TabIndex = 1;
            // 
            // txtidreceta
            // 
            this.txtidreceta.Location = new System.Drawing.Point(234, 167);
            this.txtidreceta.Name = "txtidreceta";
            this.txtidreceta.Size = new System.Drawing.Size(38, 20);
            this.txtidreceta.TabIndex = 3;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(234, 207);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 5;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(327, 207);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnexpediente
            // 
            this.btnexpediente.Location = new System.Drawing.Point(340, 94);
            this.btnexpediente.Name = "btnexpediente";
            this.btnexpediente.Size = new System.Drawing.Size(132, 23);
            this.btnexpediente.TabIndex = 2;
            this.btnexpediente.Text = "Cargar Expedientes";
            this.btnexpediente.UseVisualStyleBackColor = true;
            this.btnexpediente.Click += new System.EventHandler(this.btnexpediente_Click);
            // 
            // btnrecetas
            // 
            this.btnrecetas.Location = new System.Drawing.Point(340, 164);
            this.btnrecetas.Name = "btnrecetas";
            this.btnrecetas.Size = new System.Drawing.Size(132, 23);
            this.btnrecetas.TabIndex = 4;
            this.btnrecetas.Text = "Cargar  Receta";
            this.btnrecetas.UseVisualStyleBackColor = true;
            this.btnrecetas.Click += new System.EventHandler(this.btnrecetas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Edicionexpediente_recetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(487, 240);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnrecetas);
            this.Controls.Add(this.btnexpediente);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.txtidreceta);
            this.Controls.Add(this.txtidexpediente);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Edicionexpediente_recetas";
            this.Text = "Edicionexpediente_recetas";
            this.Load += new System.EventHandler(this.Edicionexpediente_recetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtidexpediente;
        private System.Windows.Forms.TextBox txtidreceta;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnexpediente;
        private System.Windows.Forms.Button btnrecetas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}