namespace App
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSentencia = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSentencia
            // 
            this.btnSentencia.Location = new System.Drawing.Point(88, 37);
            this.btnSentencia.Name = "btnSentencia";
            this.btnSentencia.Size = new System.Drawing.Size(112, 72);
            this.btnSentencia.TabIndex = 0;
            this.btnSentencia.Text = "Ejecucion de Sentencia";
            this.btnSentencia.UseVisualStyleBackColor = true;
            this.btnSentencia.Click += new System.EventHandler(this.btnSentencia_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(88, 135);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(112, 72);
            this.btnConsulta.TabIndex = 1;
            this.btnConsulta.Text = "Ejecucion de Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 241);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnSentencia);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prueba de Componente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSentencia;
        private System.Windows.Forms.Button btnConsulta;
    }
}

