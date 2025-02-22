namespace FormularioDeInicio
{
    partial class CatalogoCliente
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
            this.lblCatalogoClientes = new System.Windows.Forms.Label();
            this.lblxCatalogoClientes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCatalogoClientes
            // 
            this.lblCatalogoClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCatalogoClientes.AutoSize = true;
            this.lblCatalogoClientes.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogoClientes.Location = new System.Drawing.Point(351, 0);
            this.lblCatalogoClientes.Name = "lblCatalogoClientes";
            this.lblCatalogoClientes.Size = new System.Drawing.Size(269, 26);
            this.lblCatalogoClientes.TabIndex = 1;
            this.lblCatalogoClientes.Text = "CATÁLOGO DE MOTOS";
            // 
            // lblxCatalogoClientes
            // 
            this.lblxCatalogoClientes.AutoSize = true;
            this.lblxCatalogoClientes.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxCatalogoClientes.Location = new System.Drawing.Point(0, 0);
            this.lblxCatalogoClientes.Name = "lblxCatalogoClientes";
            this.lblxCatalogoClientes.Size = new System.Drawing.Size(27, 26);
            this.lblxCatalogoClientes.TabIndex = 2;
            this.lblxCatalogoClientes.Text = "X";
            this.lblxCatalogoClientes.Click += new System.EventHandler(this.lblxCatalogoClientes_Click);
            // 
            // CatalogoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblxCatalogoClientes);
            this.Controls.Add(this.lblCatalogoClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CatalogoCliente";
            this.Text = "CatalogoCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCatalogoClientes;
        private System.Windows.Forms.Label lblxCatalogoClientes;
    }
}