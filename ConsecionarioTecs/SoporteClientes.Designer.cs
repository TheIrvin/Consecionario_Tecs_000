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
            this.lblxSoporteClientes = new System.Windows.Forms.Label();
            this.lblSoporteClientes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblxSoporteClientes
            // 
            this.lblxSoporteClientes.AutoSize = true;
            this.lblxSoporteClientes.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxSoporteClientes.Location = new System.Drawing.Point(0, 0);
            this.lblxSoporteClientes.Name = "lblxSoporteClientes";
            this.lblxSoporteClientes.Size = new System.Drawing.Size(27, 26);
            this.lblxSoporteClientes.TabIndex = 4;
            this.lblxSoporteClientes.Text = "X";
            this.lblxSoporteClientes.Click += new System.EventHandler(this.lblxSoporteClientes_Click);
            // 
            // lblSoporteClientes
            // 
            this.lblSoporteClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSoporteClientes.AutoSize = true;
            this.lblSoporteClientes.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoporteClientes.Location = new System.Drawing.Point(351, 0);
            this.lblSoporteClientes.Name = "lblSoporteClientes";
            this.lblSoporteClientes.Size = new System.Drawing.Size(121, 26);
            this.lblSoporteClientes.TabIndex = 3;
            this.lblSoporteClientes.Text = "SOPORTE";
            // 
            // SoporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblxSoporteClientes);
            this.Controls.Add(this.lblSoporteClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoporteClientes";
            this.Text = "SoporteClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblxSoporteClientes;
        private System.Windows.Forms.Label lblSoporteClientes;
    }
}