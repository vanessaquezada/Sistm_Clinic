namespace ModGestionBasica.Permisos_
{
    partial class EdicionPermisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionPermisos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidpermiso = new System.Windows.Forms.TextBox();
            this.txtidgrupo = new System.Windows.Forms.TextBox();
            this.txtidopcion = new System.Windows.Forms.TextBox();
            this.btncargargrupo = new System.Windows.Forms.Button();
            this.btnopciones = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IDGupo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IDOpcion";
            // 
            // txtidpermiso
            // 
            this.txtidpermiso.Location = new System.Drawing.Point(255, 29);
            this.txtidpermiso.Name = "txtidpermiso";
            this.txtidpermiso.ReadOnly = true;
            this.txtidpermiso.Size = new System.Drawing.Size(49, 20);
            this.txtidpermiso.TabIndex = 0;
            // 
            // txtidgrupo
            // 
            this.txtidgrupo.Location = new System.Drawing.Point(255, 88);
            this.txtidgrupo.Name = "txtidgrupo";
            this.txtidgrupo.Size = new System.Drawing.Size(100, 20);
            this.txtidgrupo.TabIndex = 1;
            // 
            // txtidopcion
            // 
            this.txtidopcion.Location = new System.Drawing.Point(255, 129);
            this.txtidopcion.Name = "txtidopcion";
            this.txtidopcion.Size = new System.Drawing.Size(100, 20);
            this.txtidopcion.TabIndex = 3;
            // 
            // btncargargrupo
            // 
            this.btncargargrupo.Location = new System.Drawing.Point(361, 85);
            this.btncargargrupo.Name = "btncargargrupo";
            this.btncargargrupo.Size = new System.Drawing.Size(118, 23);
            this.btncargargrupo.TabIndex = 2;
            this.btncargargrupo.Text = "Cargar Grupo";
            this.btncargargrupo.UseVisualStyleBackColor = true;
            this.btncargargrupo.Click += new System.EventHandler(this.btncargargrupo_Click);
            // 
            // btnopciones
            // 
            this.btnopciones.Location = new System.Drawing.Point(361, 128);
            this.btnopciones.Name = "btnopciones";
            this.btnopciones.Size = new System.Drawing.Size(118, 21);
            this.btnopciones.TabIndex = 4;
            this.btnopciones.Text = "Cargar Opciones";
            this.btnopciones.UseVisualStyleBackColor = true;
            this.btnopciones.Click += new System.EventHandler(this.btnopciones_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(255, 177);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(63, 21);
            this.btnagregar.TabIndex = 5;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(361, 177);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(63, 21);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // EdicionPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(496, 210);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnopciones);
            this.Controls.Add(this.btncargargrupo);
            this.Controls.Add(this.txtidopcion);
            this.Controls.Add(this.txtidgrupo);
            this.Controls.Add(this.txtidpermiso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EdicionPermisos";
            this.Text = "EdicionPermisos";
            this.Load += new System.EventHandler(this.EdicionPermisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidpermiso;
        private System.Windows.Forms.TextBox txtidgrupo;
        private System.Windows.Forms.TextBox txtidopcion;
        private System.Windows.Forms.Button btncargargrupo;
        private System.Windows.Forms.Button btnopciones;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}