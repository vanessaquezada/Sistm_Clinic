namespace ModGestionBasica.Expedientes_
{
    partial class GestionExpedientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionExpedientes));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblNumeroFilas = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnagregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btneditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btneliminar = new System.Windows.Forms.ToolStripButton();
            this.txtfiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dtgexpediente = new System.Windows.Forms.DataGridView();
            this.IDExpediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreqCardiaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreqRespiratoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sintomas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indicaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgexpediente)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNumeroFilas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1080, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblNumeroFilas
            // 
            this.lblNumeroFilas.Name = "lblNumeroFilas";
            this.lblNumeroFilas.Size = new System.Drawing.Size(133, 17);
            this.lblNumeroFilas.Text = "0 Registros Encontrados";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnagregar,
            this.toolStripSeparator1,
            this.btneditar,
            this.toolStripSeparator2,
            this.btneliminar,
            this.txtfiltrar,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1080, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnagregar
            // 
            this.btnagregar.Image = ((System.Drawing.Image)(resources.GetObject("btnagregar.Image")));
            this.btnagregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(69, 22);
            this.btnagregar.Text = "Agregar";
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btneditar
            // 
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(57, 22);
            this.btneditar.Text = "Editar";
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(70, 22);
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtfiltrar
            // 
            this.txtfiltrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtfiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfiltrar.Name = "txtfiltrar";
            this.txtfiltrar.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel1.Text = "Buscar";
            // 
            // dtgexpediente
            // 
            this.dtgexpediente.AllowUserToAddRows = false;
            this.dtgexpediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgexpediente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDExpediente,
            this.IDDoctor,
            this.IDPaciente,
            this.FreqCardiaca,
            this.FreqRespiratoria,
            this.Temperatura,
            this.PesoActual,
            this.Altura,
            this.Sintomas,
            this.Diagnostico,
            this.Indicaciones});
            this.dtgexpediente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgexpediente.Location = new System.Drawing.Point(0, 25);
            this.dtgexpediente.Name = "dtgexpediente";
            this.dtgexpediente.RowHeadersVisible = false;
            this.dtgexpediente.Size = new System.Drawing.Size(1080, 214);
            this.dtgexpediente.TabIndex = 2;
            this.dtgexpediente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgexpediente_CellDoubleClick);
            // 
            // IDExpediente
            // 
            this.IDExpediente.DataPropertyName = "IDExpediente";
            this.IDExpediente.HeaderText = "ID";
            this.IDExpediente.Name = "IDExpediente";
            // 
            // IDDoctor
            // 
            this.IDDoctor.DataPropertyName = "IDDoctor";
            this.IDDoctor.HeaderText = "IDDoctor";
            this.IDDoctor.Name = "IDDoctor";
            // 
            // IDPaciente
            // 
            this.IDPaciente.DataPropertyName = "IDPaciente";
            this.IDPaciente.HeaderText = "IDPaciente";
            this.IDPaciente.Name = "IDPaciente";
            // 
            // FreqCardiaca
            // 
            this.FreqCardiaca.DataPropertyName = "FreqCardiaca";
            this.FreqCardiaca.HeaderText = "FreqCardiaca";
            this.FreqCardiaca.Name = "FreqCardiaca";
            // 
            // FreqRespiratoria
            // 
            this.FreqRespiratoria.DataPropertyName = "FreqRespiratoria";
            this.FreqRespiratoria.HeaderText = "FreqRespiratoria";
            this.FreqRespiratoria.Name = "FreqRespiratoria";
            // 
            // Temperatura
            // 
            this.Temperatura.DataPropertyName = "Temperatura";
            this.Temperatura.HeaderText = "Temperatura";
            this.Temperatura.Name = "Temperatura";
            // 
            // PesoActual
            // 
            this.PesoActual.DataPropertyName = "PesoActual";
            this.PesoActual.HeaderText = "PesoActual";
            this.PesoActual.Name = "PesoActual";
            // 
            // Altura
            // 
            this.Altura.DataPropertyName = "Altura";
            this.Altura.HeaderText = "Altura";
            this.Altura.Name = "Altura";
            // 
            // Sintomas
            // 
            this.Sintomas.DataPropertyName = "Sintomas";
            this.Sintomas.HeaderText = "Sintomas";
            this.Sintomas.Name = "Sintomas";
            // 
            // Diagnostico
            // 
            this.Diagnostico.DataPropertyName = "Diagnostico";
            this.Diagnostico.HeaderText = "Diagnostico";
            this.Diagnostico.Name = "Diagnostico";
            // 
            // Indicaciones
            // 
            this.Indicaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Indicaciones.DataPropertyName = "Indicaciones";
            this.Indicaciones.HeaderText = "Indicaciones";
            this.Indicaciones.Name = "Indicaciones";
            // 
            // GestionExpedientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 261);
            this.Controls.Add(this.dtgexpediente);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "GestionExpedientes";
            this.Text = "GestionExpedientes";
            this.Load += new System.EventHandler(this.GestionExpedientes_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgexpediente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblNumeroFilas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnagregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btneditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btneliminar;
        private System.Windows.Forms.ToolStripTextBox txtfiltrar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dtgexpediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDExpediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreqCardiaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreqRespiratoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temperatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sintomas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indicaciones;
    }
}