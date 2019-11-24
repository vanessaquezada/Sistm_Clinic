namespace ModGestionBasica.Fecha_Citas
{
    partial class GestionFechaCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionFechaCitas));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblNumeroFilas = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnagregar = new System.Windows.Forms.ToolStripButton();
            this.btneditar = new System.Windows.Forms.ToolStripButton();
            this.btneliminar = new System.Windows.Forms.ToolStripButton();
            this.txtfiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dtgfichacitas = new System.Windows.Forms.DataGridView();
            this.IDCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaProxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgfichacitas)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNumeroFilas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 212);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(518, 22);
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
            this.btneditar,
            this.btneliminar,
            this.txtfiltrar,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(518, 25);
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
            // btneditar
            // 
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(57, 22);
            this.btneditar.Text = "Editar";
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
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
            this.txtfiltrar.TextChanged += new System.EventHandler(this.txtfiltrar_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel1.Text = "Buscar";
            // 
            // dtgfichacitas
            // 
            this.dtgfichacitas.AllowUserToAddRows = false;
            this.dtgfichacitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgfichacitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCita,
            this.IDPaciente,
            this.IDDoctor,
            this.IDConsulta,
            this.FechaProxima});
            this.dtgfichacitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgfichacitas.Location = new System.Drawing.Point(0, 25);
            this.dtgfichacitas.Name = "dtgfichacitas";
            this.dtgfichacitas.RowHeadersVisible = false;
            this.dtgfichacitas.Size = new System.Drawing.Size(518, 187);
            this.dtgfichacitas.TabIndex = 2;
            // 
            // IDCita
            // 
            this.IDCita.DataPropertyName = "IDCita";
            this.IDCita.HeaderText = "ID";
            this.IDCita.Name = "IDCita";
            // 
            // IDPaciente
            // 
            this.IDPaciente.DataPropertyName = "IDPaciente";
            this.IDPaciente.HeaderText = "IDPaciente";
            this.IDPaciente.Name = "IDPaciente";
            // 
            // IDDoctor
            // 
            this.IDDoctor.DataPropertyName = "IDDoctor";
            this.IDDoctor.HeaderText = "IDDoctor";
            this.IDDoctor.Name = "IDDoctor";
            // 
            // IDConsulta
            // 
            this.IDConsulta.DataPropertyName = "IDConsulta";
            this.IDConsulta.HeaderText = "IDConsulta";
            this.IDConsulta.Name = "IDConsulta";
            // 
            // FechaProxima
            // 
            this.FechaProxima.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaProxima.DataPropertyName = "FechaProxima";
            this.FechaProxima.HeaderText = "FechaProxima";
            this.FechaProxima.Name = "FechaProxima";
            // 
            // GestionFechaCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 234);
            this.Controls.Add(this.dtgfichacitas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "GestionFechaCitas";
            this.Text = "GestionFechaCitas";
            this.Load += new System.EventHandler(this.GestionFechaCitas_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgfichacitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblNumeroFilas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnagregar;
        private System.Windows.Forms.ToolStripButton btneditar;
        private System.Windows.Forms.ToolStripButton btneliminar;
        private System.Windows.Forms.ToolStripTextBox txtfiltrar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dtgfichacitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaProxima;
    }
}