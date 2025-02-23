namespace FormularioDeInicio
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.lblxUsuarios = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContenedorUsuarios = new System.Windows.Forms.Panel();
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
            this.tsUsuarios = new System.Windows.Forms.ToolStrip();
            this.dtgvContenedorUsuarios = new System.Windows.Forms.DataGridView();
            this.panelUsuarios.SuspendLayout();
            this.panelContenedorUsuarios.SuspendLayout();
            this.tsUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContenedorUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblxUsuarios
            // 
            this.lblxUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblxUsuarios.AutoSize = true;
            this.lblxUsuarios.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxUsuarios.Location = new System.Drawing.Point(770, 0);
            this.lblxUsuarios.Name = "lblxUsuarios";
            this.lblxUsuarios.Size = new System.Drawing.Size(27, 26);
            this.lblxUsuarios.TabIndex = 3;
            this.lblxUsuarios.Text = "X";
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Location = new System.Drawing.Point(8, 0);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(132, 26);
            this.lblUsuarios.TabIndex = 2;
            this.lblUsuarios.Text = "USUARIOS";
            this.lblUsuarios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelUsuarios.Controls.Add(this.panel2);
            this.panelUsuarios.Controls.Add(this.lblUsuarios);
            this.panelUsuarios.Controls.Add(this.lblxUsuarios);
            this.panelUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsuarios.Location = new System.Drawing.Point(0, 0);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(800, 35);
            this.panelUsuarios.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 26);
            this.panel2.TabIndex = 6;
            // 
            // panelContenedorUsuarios
            // 
            this.panelContenedorUsuarios.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelContenedorUsuarios.Controls.Add(this.dtgvContenedorUsuarios);
            this.panelContenedorUsuarios.Controls.Add(this.tsUsuarios);
            this.panelContenedorUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorUsuarios.Location = new System.Drawing.Point(0, 35);
            this.panelContenedorUsuarios.Name = "panelContenedorUsuarios";
            this.panelContenedorUsuarios.Size = new System.Drawing.Size(800, 415);
            this.panelContenedorUsuarios.TabIndex = 9;
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
            // tsUsuarios
            // 
            this.tsUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tsUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tsUsuarios.Name = "tsUsuarios";
            this.tsUsuarios.Size = new System.Drawing.Size(800, 25);
            this.tsUsuarios.TabIndex = 9;
            this.tsUsuarios.Text = "toolStrip1";
            // 
            // dtgvContenedorUsuarios
            // 
            this.dtgvContenedorUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvContenedorUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvContenedorUsuarios.Location = new System.Drawing.Point(0, 25);
            this.dtgvContenedorUsuarios.Name = "dtgvContenedorUsuarios";
            this.dtgvContenedorUsuarios.Size = new System.Drawing.Size(800, 390);
            this.dtgvContenedorUsuarios.TabIndex = 10;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedorUsuarios);
            this.Controls.Add(this.panelUsuarios);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panelUsuarios.ResumeLayout(false);
            this.panelUsuarios.PerformLayout();
            this.panelContenedorUsuarios.ResumeLayout(false);
            this.panelContenedorUsuarios.PerformLayout();
            this.tsUsuarios.ResumeLayout(false);
            this.tsUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContenedorUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblxUsuarios;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContenedorUsuarios;
        private System.Windows.Forms.ToolStrip tsUsuarios;
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
        private System.Windows.Forms.DataGridView dtgvContenedorUsuarios;
    }
}