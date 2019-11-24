namespace ModGestionBasica.Usuarios_
{
    partial class EdicionUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnempleados = new System.Windows.Forms.Button();
            this.btngrupo = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtidusuario = new System.Windows.Forms.TextBox();
            this.txtidempleado = new System.Windows.Forms.TextBox();
            this.txtidgrupo = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcredencial = new System.Windows.Forms.TextBox();
            this.txtconectado = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID_Empleaado ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID_Grupo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Credencial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Conectado";
            // 
            // btnempleados
            // 
            this.btnempleados.Location = new System.Drawing.Point(302, 78);
            this.btnempleados.Name = "btnempleados";
            this.btnempleados.Size = new System.Drawing.Size(75, 23);
            this.btnempleados.TabIndex = 2;
            this.btnempleados.Text = "Cargar_Empleados";
            this.btnempleados.UseVisualStyleBackColor = true;
            this.btnempleados.Click += new System.EventHandler(this.btnempleados_Click);
            // 
            // btngrupo
            // 
            this.btngrupo.BackColor = System.Drawing.SystemColors.Control;
            this.btngrupo.Location = new System.Drawing.Point(302, 121);
            this.btngrupo.Name = "btngrupo";
            this.btngrupo.Size = new System.Drawing.Size(84, 23);
            this.btngrupo.TabIndex = 4;
            this.btngrupo.Text = "Cargar_Grupo";
            this.btngrupo.UseVisualStyleBackColor = false;
            this.btngrupo.Click += new System.EventHandler(this.btngrupo_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnagregar.Location = new System.Drawing.Point(260, 169);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(84, 23);
            this.btnagregar.TabIndex = 8;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btncancelar.Location = new System.Drawing.Point(386, 169);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(84, 23);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtidusuario
            // 
            this.txtidusuario.Location = new System.Drawing.Point(219, 44);
            this.txtidusuario.Name = "txtidusuario";
            this.txtidusuario.ReadOnly = true;
            this.txtidusuario.Size = new System.Drawing.Size(50, 20);
            this.txtidusuario.TabIndex = 0;
            // 
            // txtidempleado
            // 
            this.txtidempleado.Location = new System.Drawing.Point(219, 81);
            this.txtidempleado.Name = "txtidempleado";
            this.txtidempleado.ReadOnly = true;
            this.txtidempleado.Size = new System.Drawing.Size(50, 20);
            this.txtidempleado.TabIndex = 1;
            // 
            // txtidgrupo
            // 
            this.txtidgrupo.Location = new System.Drawing.Point(219, 123);
            this.txtidgrupo.Name = "txtidgrupo";
            this.txtidgrupo.ReadOnly = true;
            this.txtidgrupo.Size = new System.Drawing.Size(50, 20);
            this.txtidgrupo.TabIndex = 3;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(409, 44);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(140, 20);
            this.txtusuario.TabIndex = 5;
            // 
            // txtcredencial
            // 
            this.txtcredencial.Location = new System.Drawing.Point(409, 90);
            this.txtcredencial.Name = "txtcredencial";
            this.txtcredencial.Size = new System.Drawing.Size(140, 20);
            this.txtcredencial.TabIndex = 6;
            // 
            // txtconectado
            // 
            this.txtconectado.FormattingEnabled = true;
            this.txtconectado.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.txtconectado.Location = new System.Drawing.Point(409, 130);
            this.txtconectado.Name = "txtconectado";
            this.txtconectado.Size = new System.Drawing.Size(140, 21);
            this.txtconectado.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // EdicionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(572, 204);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtconectado);
            this.Controls.Add(this.txtcredencial);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtidgrupo);
            this.Controls.Add(this.txtidempleado);
            this.Controls.Add(this.txtidusuario);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btngrupo);
            this.Controls.Add(this.btnempleados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EdicionUsuario";
            this.Text = "EdicionUsuario";
            this.Load += new System.EventHandler(this.EdicionUsuario_Load);
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
        private System.Windows.Forms.Button btnempleados;
        private System.Windows.Forms.Button btngrupo;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtidusuario;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcredencial;
        private System.Windows.Forms.ComboBox txtconectado;
        public System.Windows.Forms.TextBox txtidempleado;
        public System.Windows.Forms.TextBox txtidgrupo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}