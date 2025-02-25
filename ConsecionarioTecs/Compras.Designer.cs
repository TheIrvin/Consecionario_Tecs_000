namespace FormularioDeInicio
{
    partial class Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            this.lblxEst = new System.Windows.Forms.Label();
            this.lblCompras = new System.Windows.Forms.Label();
            this.panaleta = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dsCompañiaTecsBDD1 = new ConsecionarioTecs.dsCompañiaTecsBDD();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ttlbFiltrarComprasProvedores = new System.Windows.Forms.ToolStripLabel();
            this.tstxtFiltrarComprasProvedores = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnFiltrarComprasProvedores = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnAgregarComprasProvedores = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnModificarComprasProvedores = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnEliminarComprasProvedores = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnImprimirComprasProvedores = new System.Windows.Forms.ToolStripButton();
            this.dtgvContendorCompras = new System.Windows.Forms.DataGridView();
            this.panaleta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompañiaTecsBDD1)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContendorCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblxEst
            // 
            this.lblxEst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblxEst.AutoSize = true;
            this.lblxEst.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxEst.Location = new System.Drawing.Point(765, 0);
            this.lblxEst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblxEst.Name = "lblxEst";
            this.lblxEst.Size = new System.Drawing.Size(35, 34);
            this.lblxEst.TabIndex = 3;
            this.lblxEst.Text = "X";
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompras.Location = new System.Drawing.Point(4, 0);
            this.lblCompras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(156, 34);
            this.lblCompras.TabIndex = 2;
            this.lblCompras.Text = "COMPRAS";
            this.lblCompras.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panaleta
            // 
            this.panaleta.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panaleta.Controls.Add(this.panel1);
            this.panaleta.Controls.Add(this.lblCompras);
            this.panaleta.Controls.Add(this.lblxEst);
            this.panaleta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panaleta.Location = new System.Drawing.Point(0, 0);
            this.panaleta.Name = "panaleta";
            this.panaleta.Size = new System.Drawing.Size(800, 35);
            this.panaleta.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 32);
            this.panel1.TabIndex = 5;
            // 
            // dsCompañiaTecsBDD1
            // 
            this.dsCompañiaTecsBDD1.DataSetName = "dsCompañiaTecsBDD";
            this.dsCompañiaTecsBDD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.dtgvContendorCompras);
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 415);
            this.panel2.TabIndex = 8;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttlbFiltrarComprasProvedores,
            this.tstxtFiltrarComprasProvedores,
            this.tsbtnFiltrarComprasProvedores,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.tsbtnAgregarComprasProvedores,
            this.toolStripSeparator3,
            this.tsBtnModificarComprasProvedores,
            this.toolStripSeparator4,
            this.tsbtnEliminarComprasProvedores,
            this.toolStripSeparator5,
            this.tsbtnImprimirComprasProvedores});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 27);
            this.toolStrip2.TabIndex = 9;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // ttlbFiltrarComprasProvedores
            // 
            this.ttlbFiltrarComprasProvedores.Name = "ttlbFiltrarComprasProvedores";
            this.ttlbFiltrarComprasProvedores.Size = new System.Drawing.Size(50, 24);
            this.ttlbFiltrarComprasProvedores.Text = "Filtrar:";
            // 
            // tstxtFiltrarComprasProvedores
            // 
            this.tstxtFiltrarComprasProvedores.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxtFiltrarComprasProvedores.Name = "tstxtFiltrarComprasProvedores";
            this.tstxtFiltrarComprasProvedores.Size = new System.Drawing.Size(145, 27);
            // 
            // tsbtnFiltrarComprasProvedores
            // 
            this.tsbtnFiltrarComprasProvedores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFiltrarComprasProvedores.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFiltrarComprasProvedores.Image")));
            this.tsbtnFiltrarComprasProvedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFiltrarComprasProvedores.Name = "tsbtnFiltrarComprasProvedores";
            this.tsbtnFiltrarComprasProvedores.Size = new System.Drawing.Size(29, 24);
            this.tsbtnFiltrarComprasProvedores.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(71, 24);
            this.toolStripLabel1.Text = "Acciones:";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtnAgregarComprasProvedores
            // 
            this.tsbtnAgregarComprasProvedores.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAgregarComprasProvedores.Image")));
            this.tsbtnAgregarComprasProvedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAgregarComprasProvedores.Name = "tsbtnAgregarComprasProvedores";
            this.tsbtnAgregarComprasProvedores.Size = new System.Drawing.Size(87, 24);
            this.tsbtnAgregarComprasProvedores.Text = "Agregar";
            this.tsbtnAgregarComprasProvedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbtnAgregarComprasProvedores.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbtnAgregarComprasProvedores.Click += new System.EventHandler(this.tsbtnAgregarComprasProvedores_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tsBtnModificarComprasProvedores
            // 
            this.tsBtnModificarComprasProvedores.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnModificarComprasProvedores.Image")));
            this.tsBtnModificarComprasProvedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnModificarComprasProvedores.Name = "tsBtnModificarComprasProvedores";
            this.tsBtnModificarComprasProvedores.Size = new System.Drawing.Size(97, 24);
            this.tsBtnModificarComprasProvedores.Text = "Modificar";
            this.tsBtnModificarComprasProvedores.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtnEliminarComprasProvedores
            // 
            this.tsbtnEliminarComprasProvedores.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEliminarComprasProvedores.Image")));
            this.tsbtnEliminarComprasProvedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEliminarComprasProvedores.Name = "tsbtnEliminarComprasProvedores";
            this.tsbtnEliminarComprasProvedores.Size = new System.Drawing.Size(87, 24);
            this.tsbtnEliminarComprasProvedores.Text = "Eliminar";
            this.tsbtnEliminarComprasProvedores.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtnImprimirComprasProvedores
            // 
            this.tsbtnImprimirComprasProvedores.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnImprimirComprasProvedores.Image")));
            this.tsbtnImprimirComprasProvedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnImprimirComprasProvedores.Name = "tsbtnImprimirComprasProvedores";
            this.tsbtnImprimirComprasProvedores.Size = new System.Drawing.Size(90, 24);
            this.tsbtnImprimirComprasProvedores.Text = "Imprimir";
            this.tsbtnImprimirComprasProvedores.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // dtgvContendorCompras
            // 
            this.dtgvContendorCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvContendorCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvContendorCompras.Location = new System.Drawing.Point(0, 27);
            this.dtgvContendorCompras.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvContendorCompras.Name = "dtgvContendorCompras";
            this.dtgvContendorCompras.RowHeadersWidth = 51;
            this.dtgvContendorCompras.Size = new System.Drawing.Size(800, 388);
            this.dtgvContendorCompras.TabIndex = 10;
            this.dtgvContendorCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvContendorCompras_CellContentClick);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panaleta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            this.panaleta.ResumeLayout(false);
            this.panaleta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompañiaTecsBDD1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContendorCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblxEst;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.Panel panaleta;
        private System.Windows.Forms.Panel panel1;
        private ConsecionarioTecs.dsCompañiaTecsBDD dsCompañiaTecsBDD1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel ttlbFiltrarComprasProvedores;
        private System.Windows.Forms.ToolStripTextBox tstxtFiltrarComprasProvedores;
        private System.Windows.Forms.ToolStripButton tsbtnFiltrarComprasProvedores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnAgregarComprasProvedores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnModificarComprasProvedores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnEliminarComprasProvedores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtnImprimirComprasProvedores;
        private System.Windows.Forms.DataGridView dtgvContendorCompras;
    }
}