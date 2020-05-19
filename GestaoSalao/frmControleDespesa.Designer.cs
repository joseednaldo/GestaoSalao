namespace GestaoSalao
{
    partial class frmControleDespesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControleDespesa));
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDespesaAberta = new System.Windows.Forms.TextBox();
            this.txtTotalGeral = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDespesaQuitada = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grProfissinal = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_Profissional = new System.Windows.Forms.ComboBox();
            this.btn_relatorio = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_SituacaoDespesa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_tipo_despesa = new System.Windows.Forms.ComboBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.gridLista = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnEstorna = new System.Windows.Forms.Button();
            this.tooMovimentacao = new System.Windows.Forms.StatusStrip();
            this.groupBox3.SuspendLayout();
            this.grProfissinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(422, 18);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(122, 27);
            this.btnIncluir.TabIndex = 98;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(550, 18);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(122, 27);
            this.btExcluir.TabIndex = 95;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Período";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataFim.Location = new System.Drawing.Point(183, 74);
            this.dtpDataFim.MinDate = new System.DateTime(2017, 11, 16, 0, 0, 0, 0);
            this.dtpDataFim.MinimumSize = new System.Drawing.Size(20, 20);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(97, 20);
            this.dtpDataFim.TabIndex = 91;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(216, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "Em Aberto";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.txtDespesaAberta);
            this.groupBox3.Controls.Add(this.txtTotalGeral);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtDespesaQuitada);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.grProfissinal);
            this.groupBox3.Controls.Add(this.gridLista);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(817, 479);
            this.groupBox3.TabIndex = 95;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consulta";
            // 
            // txtDespesaAberta
            // 
            this.txtDespesaAberta.BackColor = System.Drawing.Color.OrangeRed;
            this.txtDespesaAberta.Enabled = false;
            this.txtDespesaAberta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDespesaAberta.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDespesaAberta.Location = new System.Drawing.Point(287, 451);
            this.txtDespesaAberta.Multiline = true;
            this.txtDespesaAberta.Name = "txtDespesaAberta";
            this.txtDespesaAberta.Size = new System.Drawing.Size(116, 24);
            this.txtDespesaAberta.TabIndex = 99;
            this.txtDespesaAberta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalGeral
            // 
            this.txtTotalGeral.BackColor = System.Drawing.Color.Yellow;
            this.txtTotalGeral.Enabled = false;
            this.txtTotalGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGeral.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTotalGeral.Location = new System.Drawing.Point(692, 451);
            this.txtTotalGeral.Multiline = true;
            this.txtTotalGeral.Name = "txtTotalGeral";
            this.txtTotalGeral.Size = new System.Drawing.Size(114, 24);
            this.txtTotalGeral.TabIndex = 98;
            this.txtTotalGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(588, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 97;
            this.label7.Text = "Total Geral  R$:";
            // 
            // txtDespesaQuitada
            // 
            this.txtDespesaQuitada.BackColor = System.Drawing.Color.YellowGreen;
            this.txtDespesaQuitada.Enabled = false;
            this.txtDespesaQuitada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDespesaQuitada.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDespesaQuitada.Location = new System.Drawing.Point(466, 451);
            this.txtDespesaQuitada.Multiline = true;
            this.txtDespesaQuitada.Name = "txtDespesaQuitada";
            this.txtDespesaQuitada.Size = new System.Drawing.Size(116, 24);
            this.txtDespesaQuitada.TabIndex = 96;
            this.txtDespesaQuitada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(409, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "Quitada";
            // 
            // grProfissinal
            // 
            this.grProfissinal.Controls.Add(this.label1);
            this.grProfissinal.Controls.Add(this.cbo_Profissional);
            this.grProfissinal.Controls.Add(this.btn_relatorio);
            this.grProfissinal.Controls.Add(this.label8);
            this.grProfissinal.Controls.Add(this.cbo_SituacaoDespesa);
            this.grProfissinal.Controls.Add(this.label5);
            this.grProfissinal.Controls.Add(this.cbo_tipo_despesa);
            this.grProfissinal.Controls.Add(this.label3);
            this.grProfissinal.Controls.Add(this.dtpDataFim);
            this.grProfissinal.Controls.Add(this.btnBusca);
            this.grProfissinal.Controls.Add(this.dtpData);
            this.grProfissinal.Controls.Add(this.label2);
            this.grProfissinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grProfissinal.Location = new System.Drawing.Point(6, 19);
            this.grProfissinal.Name = "grProfissinal";
            this.grProfissinal.Size = new System.Drawing.Size(800, 113);
            this.grProfissinal.TabIndex = 92;
            this.grProfissinal.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(422, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Profissional";
            // 
            // cbo_Profissional
            // 
            this.cbo_Profissional.BackColor = System.Drawing.SystemColors.Window;
            this.cbo_Profissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Profissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Profissional.FormattingEnabled = true;
            this.cbo_Profissional.Location = new System.Drawing.Point(425, 32);
            this.cbo_Profissional.Name = "cbo_Profissional";
            this.cbo_Profissional.Size = new System.Drawing.Size(255, 24);
            this.cbo_Profissional.TabIndex = 98;
            // 
            // btn_relatorio
            // 
            this.btn_relatorio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_relatorio.Image = ((System.Drawing.Image)(resources.GetObject("btn_relatorio.Image")));
            this.btn_relatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_relatorio.Location = new System.Drawing.Point(554, 71);
            this.btn_relatorio.Name = "btn_relatorio";
            this.btn_relatorio.Size = new System.Drawing.Size(126, 27);
            this.btn_relatorio.TabIndex = 97;
            this.btn_relatorio.Text = "Relatório";
            this.btn_relatorio.UseVisualStyleBackColor = true;
            this.btn_relatorio.Click += new System.EventHandler(this.btn_relatorio_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 96;
            this.label8.Text = "Situação";
            // 
            // cbo_SituacaoDespesa
            // 
            this.cbo_SituacaoDespesa.BackColor = System.Drawing.SystemColors.Window;
            this.cbo_SituacaoDespesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_SituacaoDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_SituacaoDespesa.FormattingEnabled = true;
            this.cbo_SituacaoDespesa.Items.AddRange(new object[] {
            "(TODOS)",
            "Em aberto",
            "Quitada"});
            this.cbo_SituacaoDespesa.Location = new System.Drawing.Point(9, 32);
            this.cbo_SituacaoDespesa.Name = "cbo_SituacaoDespesa";
            this.cbo_SituacaoDespesa.Size = new System.Drawing.Size(148, 24);
            this.cbo_SituacaoDespesa.TabIndex = 95;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(163, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "Despesa";
            // 
            // cbo_tipo_despesa
            // 
            this.cbo_tipo_despesa.BackColor = System.Drawing.SystemColors.Window;
            this.cbo_tipo_despesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo_despesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tipo_despesa.FormattingEnabled = true;
            this.cbo_tipo_despesa.Location = new System.Drawing.Point(163, 32);
            this.cbo_tipo_despesa.Name = "cbo_tipo_despesa";
            this.cbo_tipo_despesa.Size = new System.Drawing.Size(256, 24);
            this.cbo_tipo_despesa.TabIndex = 93;
            // 
            // btnBusca
            // 
            this.btnBusca.Image = ((System.Drawing.Image)(resources.GetObject("btnBusca.Image")));
            this.btnBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.Location = new System.Drawing.Point(425, 71);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(126, 27);
            this.btnBusca.TabIndex = 87;
            this.btnBusca.Text = "Procurar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(59, 74);
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
            this.label2.Location = new System.Drawing.Point(163, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "à";
            // 
            // gridLista
            // 
            this.gridLista.AllowUserToAddRows = false;
            this.gridLista.AllowUserToDeleteRows = false;
            this.gridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLista.Location = new System.Drawing.Point(7, 138);
            this.gridLista.Name = "gridLista";
            this.gridLista.ReadOnly = true;
            this.gridLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLista.Size = new System.Drawing.Size(799, 290);
            this.gridLista.TabIndex = 49;
            this.gridLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLista_CellContentClick);
            this.gridLista.Click += new System.EventHandler(this.gridLista_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.btnConfirma);
            this.groupBox1.Controls.Add(this.btnEstorna);
            this.groupBox1.Controls.Add(this.btnIncluir);
            this.groupBox1.Controls.Add(this.btExcluir);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 552);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 58);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(677, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 27);
            this.button5.TabIndex = 101;
            this.button5.Text = "Sair";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirma.Image")));
            this.btnConfirma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirma.Location = new System.Drawing.Point(172, 18);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(127, 27);
            this.btnConfirma.TabIndex = 100;
            this.btnConfirma.Text = "Quitar";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Visible = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnEstorna
            // 
            this.btnEstorna.Image = ((System.Drawing.Image)(resources.GetObject("btnEstorna.Image")));
            this.btnEstorna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstorna.Location = new System.Drawing.Point(15, 18);
            this.btnEstorna.Name = "btnEstorna";
            this.btnEstorna.Size = new System.Drawing.Size(129, 27);
            this.btnEstorna.TabIndex = 99;
            this.btnEstorna.Text = "Estorna";
            this.btnEstorna.UseVisualStyleBackColor = true;
            this.btnEstorna.Visible = false;
            // 
            // tooMovimentacao
            // 
            this.tooMovimentacao.Location = new System.Drawing.Point(0, 615);
            this.tooMovimentacao.Name = "tooMovimentacao";
            this.tooMovimentacao.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tooMovimentacao.Size = new System.Drawing.Size(839, 22);
            this.tooMovimentacao.TabIndex = 107;
            // 
            // frmControleDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 637);
            this.Controls.Add(this.tooMovimentacao);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmControleDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Despesas";
            this.Load += new System.EventHandler(this.frmControleDespesa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmControleDespesa_KeyDown);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grProfissinal.ResumeLayout(false);
            this.grProfissinal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.GroupBox grProfissinal;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDespesaQuitada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_tipo_despesa;
        private System.Windows.Forms.TextBox txtDespesaAberta;
        private System.Windows.Forms.TextBox txtTotalGeral;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_SituacaoDespesa;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnEstorna;
        private System.Windows.Forms.StatusStrip tooMovimentacao;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_relatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_Profissional;
    }
}