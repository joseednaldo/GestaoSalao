namespace GestaoSalao
{
    partial class frmControleVale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControleVale));
            this.gridLista = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTotalGeral = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grProfissinal = new System.Windows.Forms.GroupBox();
            this.btn_relatorio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.chkFiltroFuncionario = new System.Windows.Forms.CheckBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_Profissional = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grProfissinal.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.gridLista.Click += new System.EventHandler(this.gridLista_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtTotalGeral);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.grProfissinal);
            this.groupBox3.Controls.Add(this.gridLista);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(730, 380);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consulta";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(344, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 27);
            this.button1.TabIndex = 95;
            this.button1.Text = "Imprimir vale";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.txtTotalGeral.TextChanged += new System.EventHandler(this.txtTotalGeral_TextChanged);
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
            this.grProfissinal.Controls.Add(this.btn_relatorio);
            this.grProfissinal.Controls.Add(this.label3);
            this.grProfissinal.Controls.Add(this.dtpDataFim);
            this.grProfissinal.Controls.Add(this.chkFiltroFuncionario);
            this.grProfissinal.Controls.Add(this.btnBusca);
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
            // btn_relatorio
            // 
            this.btn_relatorio.Image = ((System.Drawing.Image)(resources.GetObject("btn_relatorio.Image")));
            this.btn_relatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_relatorio.Location = new System.Drawing.Point(582, 42);
            this.btn_relatorio.Name = "btn_relatorio";
            this.btn_relatorio.Size = new System.Drawing.Size(126, 27);
            this.btn_relatorio.TabIndex = 93;
            this.btn_relatorio.Text = "Relatório";
            this.btn_relatorio.UseVisualStyleBackColor = true;
            this.btn_relatorio.Click += new System.EventHandler(this.btn_relatorio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(293, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Data Inicial";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataFim.Location = new System.Drawing.Point(411, 36);
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
            // btnBusca
            // 
            this.btnBusca.Image = ((System.Drawing.Image)(resources.GetObject("btnBusca.Image")));
            this.btnBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.Location = new System.Drawing.Point(582, 15);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(126, 27);
            this.btnBusca.TabIndex = 87;
            this.btnBusca.Text = "Procurar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
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
            this.dtpData.Location = new System.Drawing.Point(296, 36);
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
            this.label2.Location = new System.Drawing.Point(408, 18);
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
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnIncluir);
            this.groupBox1.Controls.Add(this.btEditar);
            this.groupBox1.Controls.Add(this.btExcluir);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 457);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 58);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(615, 19);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(105, 25);
            this.btnSair.TabIndex = 99;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(392, 19);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(106, 27);
            this.btnIncluir.TabIndex = 98;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btEditar
            // 
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEditar.Location = new System.Drawing.Point(15, 19);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(28, 27);
            this.btEditar.TabIndex = 97;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Visible = false;
            // 
            // btExcluir
            // 
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(504, 19);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(105, 27);
            this.btExcluir.TabIndex = 95;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // frmControleVale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmControleVale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de vales";
            this.Load += new System.EventHandler(this.frmControleVale_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmControleVale_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grProfissinal.ResumeLayout(false);
            this.grProfissinal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLista;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTotalGeral;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.GroupBox grProfissinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.CheckBox chkFiltroFuncionario;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Profissional;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btn_relatorio;
        private System.Windows.Forms.Button button1;
    }
}