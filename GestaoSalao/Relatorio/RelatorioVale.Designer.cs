namespace GestaoSalao.Relatorio
{
    partial class RelatorioVale
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportVale = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ValeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ValeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportVale
            // 
            this.reportVale.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsVale";
            reportDataSource1.Value = this.ValeBindingSource;
            this.reportVale.LocalReport.DataSources.Add(reportDataSource1);
            this.reportVale.LocalReport.ReportEmbeddedResource = "GestaoSalao.Relatorio.dsVale.rdlc";
            this.reportVale.Location = new System.Drawing.Point(0, 0);
            this.reportVale.Name = "reportVale";
            this.reportVale.Size = new System.Drawing.Size(820, 428);
            this.reportVale.TabIndex = 0;
            // 
            // ValeBindingSource
            // 
            this.ValeBindingSource.DataSource = typeof(DTO_GestaoSalao.Vale);
            // 
            // RelatorioVale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 428);
            this.Controls.Add(this.reportVale);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RelatorioVale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RelatorioVale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ValeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportVale;
        private System.Windows.Forms.BindingSource ValeBindingSource;
    }
}