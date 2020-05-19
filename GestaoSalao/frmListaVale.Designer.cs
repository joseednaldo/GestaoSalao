namespace GestaoSalao
{
    partial class frmListaVale
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
            this.gridLista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLista
            // 
            this.gridLista.AllowUserToAddRows = false;
            this.gridLista.AllowUserToDeleteRows = false;
            this.gridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLista.Location = new System.Drawing.Point(1, 65);
            this.gridLista.Name = "gridLista";
            this.gridLista.ReadOnly = true;
            this.gridLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLista.Size = new System.Drawing.Size(541, 147);
            this.gridLista.TabIndex = 50;
            // 
            // frmListaVale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 214);
            this.Controls.Add(this.gridLista);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListaVale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Lista de vales";
            this.Load += new System.EventHandler(this.frmListaVale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLista;
    }
}