namespace GestaoSalao
{
    partial class frmListaPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaPedidos));
            this.gridLista = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalGeral = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grProfissinal = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.chkFiltroFuncionario = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_Profissional = new System.Windows.Forms.ComboBox();
            this.tooDespesas = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grProfissinal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridLista
            // 
            this.gridLista.AllowUserToAddRows = false;
            this.gridLista.AllowUserToDeleteRows = false;
            this.gridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLista.Location = new System.Drawing.Point(6, 100);
            this.gridLista.Name = "gridLista";
            this.gridLista.ReadOnly = true;
            this.gridLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLista.Size = new System.Drawing.Size(714, 236);
            this.gridLista.TabIndex = 49;
            this.gridLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLista_CellContentClick);
            this.gridLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLista_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtTotalGeral);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.grProfissinal);
            this.groupBox3.Controls.Add(this.gridLista);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(732, 374);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consulta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 13);
            this.label5.TabIndex = 95;
            this.label5.Text = "Obs: Para excluir de (Duplo  Click) na linha do faturamento";
            // 
            // txtTotalGeral
            // 
            this.txtTotalGeral.BackColor = System.Drawing.Color.Yellow;
            this.txtTotalGeral.Enabled = false;
            this.txtTotalGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGeral.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTotalGeral.Location = new System.Drawing.Point(573, 344);
            this.txtTotalGeral.Multiline = true;
            this.txtTotalGeral.Name = "txtTotalGeral";
            this.txtTotalGeral.Size = new System.Drawing.Size(147, 24);
            this.txtTotalGeral.TabIndex = 94;
            this.txtTotalGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(476, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "Total Geral  R$:";
            // 
            // grProfissinal
            // 
            this.grProfissinal.Controls.Add(this.label3);
            this.grProfissinal.Controls.Add(this.dtpDataFim);
            this.grProfissinal.Controls.Add(this.chkFiltroFuncionario);
            this.grProfissinal.Controls.Add(this.button5);
            this.grProfissinal.Controls.Add(this.button1);
            this.grProfissinal.Controls.Add(this.label1);
            this.grProfissinal.Controls.Add(this.dtpData);
            this.grProfissinal.Controls.Add(this.label2);
            this.grProfissinal.Controls.Add(this.cbo_Profissional);
            this.grProfissinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grProfissinal.Location = new System.Drawing.Point(6, 19);
            this.grProfissinal.Name = "grProfissinal";
            this.grProfissinal.Size = new System.Drawing.Size(714, 75);
            this.grProfissinal.TabIndex = 92;
            this.grProfissinal.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(269, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Data Inicial";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataFim.Location = new System.Drawing.Point(375, 36);
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
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(603, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 27);
            this.button5.TabIndex = 89;
            this.button5.Text = "Sair";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(492, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 27);
            this.button1.TabIndex = 87;
            this.button1.Text = "Procurar";
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
            this.dtpData.Location = new System.Drawing.Point(272, 36);
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
            this.label2.Location = new System.Drawing.Point(372, 18);
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
            this.cbo_Profissional.Size = new System.Drawing.Size(247, 24);
            this.cbo_Profissional.TabIndex = 0;
            this.cbo_Profissional.SelectedIndexChanged += new System.EventHandler(this.cbo_Profissional_SelectedIndexChanged);
            // 
            // tooDespesas
            // 
            this.tooDespesas.Location = new System.Drawing.Point(0, 453);
            this.tooDespesas.Name = "tooDespesas";
            this.tooDespesas.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tooDespesas.Size = new System.Drawing.Size(751, 22);
            this.tooDespesas.TabIndex = 107;
            // 
            // frmListaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 475);
            this.Controls.Add(this.tooDespesas);
            this.Controls.Add(this.groupBox3);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListaPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta  de Faturamento";
            this.Load += new System.EventHandler(this.frmListaPedidos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmListaPedidos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grProfissinal.ResumeLayout(false);
            this.grProfissinal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLista;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.GroupBox grProfissinal;
        private System.Windows.Forms.ComboBox cbo_Profissional;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.CheckBox chkFiltroFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalGeral;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip tooDespesas;
    }
}