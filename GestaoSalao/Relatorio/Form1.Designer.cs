namespace GestaoSalao.Relatorio
{
    partial class frmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            this.ListaPedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grProfissinal = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.chkFiltroFuncionario = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_Profissional = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPedidosBindingSource)).BeginInit();
            this.grProfissinal.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaPedidosBindingSource
            // 
            this.ListaPedidosBindingSource.DataSource = typeof(DTO_GestaoSalao.ListaPedidos);
            // 
            // grProfissinal
            // 
            this.grProfissinal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grProfissinal.Controls.Add(this.btnSair);
            this.grProfissinal.Controls.Add(this.label3);
            this.grProfissinal.Controls.Add(this.dtpDataFim);
            this.grProfissinal.Controls.Add(this.chkFiltroFuncionario);
            this.grProfissinal.Controls.Add(this.button1);
            this.grProfissinal.Controls.Add(this.label1);
            this.grProfissinal.Controls.Add(this.dtpData);
            this.grProfissinal.Controls.Add(this.label2);
            this.grProfissinal.Controls.Add(this.cbo_Profissional);
            this.grProfissinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grProfissinal.Location = new System.Drawing.Point(12, 72);
            this.grProfissinal.Name = "grProfissinal";
            this.grProfissinal.Size = new System.Drawing.Size(951, 75);
            this.grProfissinal.TabIndex = 93;
            this.grProfissinal.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(292, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Data Inicial";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataFim.Location = new System.Drawing.Point(398, 34);
            this.dtpDataFim.MinDate = new System.DateTime(2017, 11, 16, 0, 0, 0, 0);
            this.dtpDataFim.MinimumSize = new System.Drawing.Size(20, 20);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(97, 20);
            this.dtpDataFim.TabIndex = 91;
            // 
            // chkFiltroFuncionario
            // 
            this.chkFiltroFuncionario.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkFiltroFuncionario.Checked = true;
            this.chkFiltroFuncionario.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFiltroFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkFiltroFuncionario.Location = new System.Drawing.Point(84, 15);
            this.chkFiltroFuncionario.Name = "chkFiltroFuncionario";
            this.chkFiltroFuncionario.Size = new System.Drawing.Size(55, 16);
            this.chkFiltroFuncionario.TabIndex = 90;
            this.chkFiltroFuncionario.Text = "Filtro ";
            this.chkFiltroFuncionario.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(601, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 27);
            this.button1.TabIndex = 87;
            this.button1.Text = "Gerar relatório";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Profissional";
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(295, 34);
            this.dtpData.MinDate = new System.DateTime(2017, 11, 16, 0, 0, 0, 0);
            this.dtpData.MinimumSize = new System.Drawing.Size(20, 20);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(98, 20);
            this.dtpData.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(395, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "Data Final";
            // 
            // cbo_Profissional
            // 
            this.cbo_Profissional.BackColor = System.Drawing.SystemColors.Window;
            this.cbo_Profissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Profissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Profissional.FormattingEnabled = true;
            this.cbo_Profissional.Location = new System.Drawing.Point(9, 32);
            this.cbo_Profissional.Name = "cbo_Profissional";
            this.cbo_Profissional.Size = new System.Drawing.Size(265, 24);
            this.cbo_Profissional.TabIndex = 0;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsFaturamento";
            reportDataSource1.Value = this.ListaPedidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestaoSalao.Relatorio.RelatorioFaturamento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 153);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(951, 503);
            this.reportViewer1.TabIndex = 94;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(789, 29);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(153, 27);
            this.btnSair.TabIndex = 100;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 657);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.grProfissinal);
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaPedidosBindingSource)).EndInit();
            this.grProfissinal.ResumeLayout(false);
            this.grProfissinal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox grProfissinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.CheckBox chkFiltroFuncionario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Profissional;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ListaPedidosBindingSource;
        private System.Windows.Forms.Button btnSair;
    }
}