namespace FormularioDeInicio
{
    partial class SoporteClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoporteClientes));
            this.lblxSoporteClientes = new System.Windows.Forms.Label();
            this.lblSoporteClientes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSoporte = new System.Windows.Forms.Panel();
            this.panelContenedorSoporte = new System.Windows.Forms.Panel();
            this.tsSoporte = new System.Windows.Forms.ToolStrip();
            this.ttlbFiltrar = new System.Windows.Forms.ToolStripLabel();
            this.tstxtFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnFiltrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnAgregarCliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnModificarCliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.dtgvContenedorSoporte = new System.Windows.Forms.DataGridView();
            this.panelSoporte.SuspendLayout();
            this.panelContenedorSoporte.SuspendLayout();
            this.tsSoporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContenedorSoporte)).BeginInit();
            this.SuspendLayout();
            // 
            // lblxSoporteClientes
            // 
            this.lblxSoporteClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblxSoporteClientes.AutoSize = true;
            this.lblxSoporteClientes.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxSoporteClientes.Location = new System.Drawing.Point(770, 0);
            this.lblxSoporteClientes.Name = "lblxSoporteClientes";
            this.lblxSoporteClientes.Size = new System.Drawing.Size(27, 26);
            this.lblxSoporteClientes.TabIndex = 4;
            this.lblxSoporteClientes.Text = "X";
            this.lblxSoporteClientes.Click += new System.EventHandler(this.lblxSoporteClientes_Click);
            // 
            // lblSoporteClientes
            // 
            this.lblSoporteClientes.AutoSize = true;
            this.lblSoporteClientes.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoporteClientes.Location = new System.Drawing.Point(8, 0);
            this.lblSoporteClientes.Name = "lblSoporteClientes";
            this.lblSoporteClientes.Size = new System.Drawing.Size(121, 26);
            this.lblSoporteClientes.TabIndex = 3;
            this.lblSoporteClientes.Text = "SOPORTE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 26);
            this.panel1.TabIndex = 7;
            // 
            // panelSoporte
            // 
            this.panelSoporte.Controls.Add(this.lblSoporteClientes);
            this.panelSoporte.Controls.Add(this.lblxSoporteClientes);
            this.panelSoporte.Controls.Add(this.panel1);
            this.panelSoporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSoporte.Location = new System.Drawing.Point(0, 0);
            this.panelSoporte.Name = "panelSoporte";
            this.panelSoporte.Size = new System.Drawing.Size(800, 35);
            this.panelSoporte.TabIndex = 8;
            // 
            // panelContenedorSoporte
            // 
            this.panelContenedorSoporte.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelContenedorSoporte.Controls.Add(this.dtgvContenedorSoporte);
            this.panelContenedorSoporte.Controls.Add(this.tsSoporte);
            this.panelContenedorSoporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorSoporte.Location = new System.Drawing.Point(0, 35);
            this.panelContenedorSoporte.Name = "panelContenedorSoporte";
            this.panelContenedorSoporte.Size = new System.Drawing.Size(800, 415);
            this.panelContenedorSoporte.TabIndex = 9;
            // 
            // tsSoporte
            // 
            this.tsSoporte.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttlbFiltrar,
            this.tstxtFiltrar,
            this.tsbtnFiltrar,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.tsbtnAgregarCliente,
            this.toolStripSeparator3,
            this.tsBtnModificarCliente,
            this.toolStripSeparator4,
            this.tsbtnEliminar,
            this.toolStripSeparator5,
            this.tsbtnImprimir});
            this.tsSoporte.Location = new System.Drawing.Point(0, 0);
            this.tsSoporte.Name = "tsSoporte";
            this.tsSoporte.Size = new System.Drawing.Size(800, 25);
            this.tsSoporte.TabIndex = 1;
            // 
            // ttlbFiltrar
            // 
            this.ttlbFiltrar.Name = "ttlbFiltrar";
            this.ttlbFiltrar.Size = new System.Drawing.Size(40, 22);
            this.ttlbFiltrar.Text = "Filtrar:";
            // 
            // tstxtFiltrar
            // 
            this.tstxtFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxtFiltrar.Name = "tstxtFiltrar";
            this.tstxtFiltrar.Size = new System.Drawing.Size(110, 25);
            // 
            // tsbtnFiltrar
            // 
            this.tsbtnFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFiltrar.Image")));
            this.tsbtnFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFiltrar.Name = "tsbtnFiltrar";
            this.tsbtnFiltrar.Size = new System.Drawing.Size(23, 22);
            this.tsbtnFiltrar.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel1.Text = "Acciones:";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnAgregarCliente
            // 
            this.tsbtnAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAgregarCliente.Image")));
            this.tsbtnAgregarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAgregarCliente.Name = "tsbtnAgregarCliente";
            this.tsbtnAgregarCliente.Size = new System.Drawing.Size(69, 22);
            this.tsbtnAgregarCliente.Text = "Agregar";
            this.tsbtnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbtnAgregarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnModificarCliente
            // 
            this.tsBtnModificarCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnModificarCliente.Image")));
            this.tsBtnModificarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnModificarCliente.Name = "tsBtnModificarCliente";
            this.tsBtnModificarCliente.Size = new System.Drawing.Size(78, 22);
            this.tsBtnModificarCliente.Text = "Modificar";
            this.tsBtnModificarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnEliminar
            // 
            this.tsbtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEliminar.Image")));
            this.tsbtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEliminar.Name = "tsbtnEliminar";
            this.tsbtnEliminar.Size = new System.Drawing.Size(70, 22);
            this.tsbtnEliminar.Text = "Eliminar";
            this.tsbtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnImprimir
            // 
            this.tsbtnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnImprimir.Image")));
            this.tsbtnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnImprimir.Name = "tsbtnImprimir";
            this.tsbtnImprimir.Size = new System.Drawing.Size(73, 22);
            this.tsbtnImprimir.Text = "Imprimir";
            this.tsbtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // dtgvContenedorSoporte
            // 
            this.dtgvContenedorSoporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvContenedorSoporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvContenedorSoporte.Location = new System.Drawing.Point(0, 25);
            this.dtgvContenedorSoporte.Name = "dtgvContenedorSoporte";
            this.dtgvContenedorSoporte.Size = new System.Drawing.Size(800, 390);
            this.dtgvContenedorSoporte.TabIndex = 2;
            // 
            // SoporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedorSoporte);
            this.Controls.Add(this.panelSoporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoporteClientes";
            this.Text = "SoporteClientes";
            this.panelSoporte.ResumeLayout(false);
            this.panelSoporte.PerformLayout();
            this.panelContenedorSoporte.ResumeLayout(false);
            this.panelContenedorSoporte.PerformLayout();
            this.tsSoporte.ResumeLayout(false);
            this.tsSoporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContenedorSoporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblxSoporteClientes;
        private System.Windows.Forms.Label lblSoporteClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSoporte;
        private System.Windows.Forms.Panel panelContenedorSoporte;
        private System.Windows.Forms.ToolStrip tsSoporte;
        private System.Windows.Forms.ToolStripLabel ttlbFiltrar;
        private System.Windows.Forms.ToolStripTextBox tstxtFiltrar;
        private System.Windows.Forms.ToolStripButton tsbtnFiltrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnAgregarCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnModificarCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtnImprimir;
        private System.Windows.Forms.DataGridView dtgvContenedorSoporte;
    }
}