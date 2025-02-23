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
            this.lblxEst = new System.Windows.Forms.Label();
            this.lblEstadisticas1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblxEst
            // 
            this.lblxEst.AutoSize = true;
            this.lblxEst.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxEst.Location = new System.Drawing.Point(0, 0);
            this.lblxEst.Name = "lblxEst";
            this.lblxEst.Size = new System.Drawing.Size(27, 26);
            this.lblxEst.TabIndex = 3;
            this.lblxEst.Text = "X";
            // 
            // lblEstadisticas1
            // 
            this.lblEstadisticas1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstadisticas1.AutoSize = true;
            this.lblEstadisticas1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadisticas1.Location = new System.Drawing.Point(351, 0);
            this.lblEstadisticas1.Name = "lblEstadisticas1";
            this.lblEstadisticas1.Size = new System.Drawing.Size(125, 26);
            this.lblEstadisticas1.TabIndex = 2;
            this.lblEstadisticas1.Text = "COMPRAS";
            this.lblEstadisticas1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 69);
            this.dataGridView1.TabIndex = 4;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblxEst);
            this.Controls.Add(this.lblEstadisticas1);
            this.Name = "Compras";
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblxEst;
        private System.Windows.Forms.Label lblEstadisticas1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}