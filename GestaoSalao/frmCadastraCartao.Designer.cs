namespace GestaoSalao
{
    partial class frmCadastraCartao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastraCartao));
            this.tabFormaPgto = new System.Windows.Forms.TabControl();
            this.tabEmitente = new System.Windows.Forms.TabPage();
            this.chkParcelamento = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescricaoCartao = new System.Windows.Forms.TextBox();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCartoes = new System.Windows.Forms.DataGridView();
            this.btEditar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btIncuir = new System.Windows.Forms.Button();
            this.tooCartoes = new System.Windows.Forms.StatusStrip();
            this.tabFormaPgto.SuspendLayout();
            this.tabEmitente.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartoes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFormaPgto
            // 
            this.tabFormaPgto.Controls.Add(this.tabEmitente);
            this.tabFormaPgto.Location = new System.Drawing.Point(12, 77);
            this.tabFormaPgto.Name = "tabFormaPgto";
            this.tabFormaPgto.SelectedIndex = 0;
            this.tabFormaPgto.Size = new System.Drawing.Size(419, 276);
            this.tabFormaPgto.TabIndex = 109;
            // 
            // tabEmitente
            // 
            this.tabEmitente.Controls.Add(this.chkParcelamento);
            this.tabEmitente.Controls.Add(this.label1);
            this.tabEmitente.Controls.Add(this.label11);
            this.tabEmitente.Controls.Add(this.txtDescricaoCartao);
            this.tabEmitente.Controls.Add(this.txtTaxa);
            this.tabEmitente.Controls.Add(this.lblDescricao);
            this.tabEmitente.Controls.Add(this.groupBox3);
            this.tabEmitente.Location = new System.Drawing.Point(4, 22);
            this.tabEmitente.Name = "tabEmitente";
            this.tabEmitente.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmitente.Size = new System.Drawing.Size(411, 250);
            this.tabEmitente.TabIndex = 0;
            this.tabEmitente.Text = "Escolha a forma de pagamento";
            this.tabEmitente.UseVisualStyleBackColor = true;
            // 
            // chkParcelamento
            // 
            this.chkParcelamento.AutoSize = true;
            this.chkParcelamento.Location = new System.Drawing.Point(9, 54);
            this.chkParcelamento.Name = "chkParcelamento";
            this.chkParcelamento.Size = new System.Drawing.Size(210, 17);
            this.chkParcelamento.TabIndex = 84;
            this.chkParcelamento.Text = "Não permitir pacelamento nesse cartão";
            this.chkParcelamento.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(226, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(195, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Taxa ";
            // 
            // txtDescricaoCartao
            // 
            this.txtDescricaoCartao.Location = new System.Drawing.Point(9, 28);
            this.txtDescricaoCartao.Name = "txtDescricaoCartao";
            this.txtDescricaoCartao.Size = new System.Drawing.Size(183, 20);
            this.txtDescricaoCartao.TabIndex = 72;
            // 
            // txtTaxa
            // 
            this.txtTaxa.Location = new System.Drawing.Point(198, 28);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(87, 20);
            this.txtTaxa.TabIndex = 73;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDescricao.ForeColor = System.Drawing.Color.Black;
            this.lblDescricao.Location = new System.Drawing.Point(6, 12);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(64, 13);
            this.lblDescricao.TabIndex = 71;
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCartoes);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 157);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de cartões";
            // 
            // dgvCartoes
            // 
            this.dgvCartoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartoes.Location = new System.Drawing.Point(6, 19);
            this.dgvCartoes.Name = "dgvCartoes";
            this.dgvCartoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCartoes.Size = new System.Drawing.Size(380, 127);
            this.dgvCartoes.TabIndex = 49;
            // 
            // btEditar
            // 
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEditar.Location = new System.Drawing.Point(241, 359);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(92, 27);
            this.btEditar.TabIndex = 113;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // btNovo
            // 
            this.btNovo.Image = ((System.Drawing.Image)(resources.GetObject("btNovo.Image")));
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(48, 359);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(92, 27);
            this.btNovo.TabIndex = 110;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(339, 359);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(92, 27);
            this.btExcluir.TabIndex = 111;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btIncuir
            // 
            this.btIncuir.Image = ((System.Drawing.Image)(resources.GetObject("btIncuir.Image")));
            this.btIncuir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIncuir.Location = new System.Drawing.Point(146, 359);
            this.btIncuir.Name = "btIncuir";
            this.btIncuir.Size = new System.Drawing.Size(92, 27);
            this.btIncuir.TabIndex = 112;
            this.btIncuir.Text = "Incluir";
            this.btIncuir.UseVisualStyleBackColor = true;
            this.btIncuir.Click += new System.EventHandler(this.btIncuir_Click);
            // 
            // tooCartoes
            // 
            this.tooCartoes.Location = new System.Drawing.Point(0, 392);
            this.tooCartoes.Name = "tooCartoes";
            this.tooCartoes.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tooCartoes.Size = new System.Drawing.Size(441, 22);
            this.tooCartoes.TabIndex = 114;
            // 
            // frmCadastraCartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 414);
            this.Controls.Add(this.tooCartoes);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btIncuir);
            this.Controls.Add(this.tabFormaPgto);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastraCartao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cartões de Crédito / Débito";
            this.Load += new System.EventHandler(this.frmCadastraCartao_Load);
            this.tabFormaPgto.ResumeLayout(false);
            this.tabEmitente.ResumeLayout(false);
            this.tabEmitente.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabFormaPgto;
        private System.Windows.Forms.TabPage tabEmitente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCartoes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescricaoCartao;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkParcelamento;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btIncuir;
        private System.Windows.Forms.StatusStrip tooCartoes;
    }
}