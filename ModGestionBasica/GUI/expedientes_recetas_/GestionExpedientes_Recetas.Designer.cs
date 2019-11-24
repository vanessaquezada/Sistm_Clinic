namespace ModGestionBasica.expedientes_recetas_
{
    partial class GestionExpediente_Recetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionExpediente_Recetas));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnagregar = new System.Windows.Forms.ToolStripButton();
            this.txteditar = new System.Windows.Forms.ToolStripButton();
            this.txteliminar = new System.Windows.Forms.ToolStripButton();
            this.txtfiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblNumeroFilas = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtg_recetas_expedientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDExpediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_recetas_expedientes)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnagregar,
            this.txteditar,
            this.txteliminar,
            this.txtfiltrar,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(494, 25);
            this.toolStrip1.TabIndex = 0;
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
            // txteditar
            // 
            this.txteditar.Image = ((System.Drawing.Image)(resources.GetObject("txteditar.Image")));
            this.txteditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txteditar.Name = "txteditar";
            this.txteditar.Size = new System.Drawing.Size(57, 22);
            this.txteditar.Text = "Editar";
            this.txteditar.Click += new System.EventHandler(this.txteditar_Click);
            // 
            // txteliminar
            // 
            this.txteliminar.Image = ((System.Drawing.Image)(resources.GetObject("txteliminar.Image")));
            this.txteliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txteliminar.Name = "txteliminar";
            this.txteliminar.Size = new System.Drawing.Size(70, 22);
            this.txteliminar.Text = "Eliminar";
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
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNumeroFilas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(494, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblNumeroFilas
            // 
            this.lblNumeroFilas.Name = "lblNumeroFilas";
            this.lblNumeroFilas.Size = new System.Drawing.Size(133, 17);
            this.lblNumeroFilas.Text = "0 Registros Encontrados";
            // 
            // dtg_recetas_expedientes
            // 
            this.dtg_recetas_expedientes.AllowUserToAddRows = false;
            this.dtg_recetas_expedientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_recetas_expedientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IDExpediente,
            this.IDReceta});
            this.dtg_recetas_expedientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_recetas_expedientes.Location = new System.Drawing.Point(0, 25);
            this.dtg_recetas_expedientes.Name = "dtg_recetas_expedientes";
            this.dtg_recetas_expedientes.RowHeadersVisible = false;
            this.dtg_recetas_expedientes.Size = new System.Drawing.Size(494, 214);
            this.dtg_recetas_expedientes.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // IDExpediente
            // 
            this.IDExpediente.DataPropertyName = "IDExpediente";
            this.IDExpediente.HeaderText = "IDExpediente";
            this.IDExpediente.Name = "IDExpediente";
            // 
            // IDReceta
            // 
            this.IDReceta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDReceta.DataPropertyName = "IDReceta";
            this.IDReceta.HeaderText = "IDReceta";
            this.IDReceta.Name = "IDReceta";
            // 
            // GestionExpediente_Recetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 261);
            this.Controls.Add(this.dtg_recetas_expedientes);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "GestionExpediente_Recetas";
            this.Text = "GestionExpediente_Recetas";
            this.Load += new System.EventHandler(this.EdicionRecetas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_recetas_expedientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnagregar;
        private System.Windows.Forms.ToolStripButton txteditar;
        private System.Windows.Forms.ToolStripButton txteliminar;
        private System.Windows.Forms.ToolStripTextBox txtfiltrar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblNumeroFilas;
        private System.Windows.Forms.DataGridView dtg_recetas_expedientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDExpediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDReceta;
    }
}