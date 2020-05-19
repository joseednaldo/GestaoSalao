namespace GestaoSalao
{
    partial class frmAtendimentoAvulso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtendimentoAvulso));
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_servico = new System.Windows.Forms.ComboBox();
            this.txtPrecoServico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvServico = new System.Windows.Forms.DataGridView();
            this.groupCFOP = new System.Windows.Forms.GroupBox();
            this.btSalvarItem = new System.Windows.Forms.Button();
            this.grProfissinal = new System.Windows.Forms.GroupBox();
            this.DtMovimentacao = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_Profissional = new System.Windows.Forms.ComboBox();
            this.tooCFOP = new System.Windows.Forms.StatusStrip();
            this.btIncuir = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
            this.groupCFOP.SuspendLayout();
            this.grProfissinal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(286, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "Valor";
            // 
            // cbo_servico
            // 
            this.cbo_servico.BackColor = System.Drawing.SystemColors.Window;
            this.cbo_servico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_servico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_servico.FormattingEnabled = true;
            this.cbo_servico.Location = new System.Drawing.Point(17, 109);
            this.cbo_servico.Name = "cbo_servico";
            this.cbo_servico.Size = new System.Drawing.Size(266, 24);
            this.cbo_servico.TabIndex = 1;
            // 
            // txtPrecoServico
            // 
            this.txtPrecoServico.Location = new System.Drawing.Point(289, 109);
            this.txtPrecoServico.Multiline = true;
            this.txtPrecoServico.Name = "txtPrecoServico";
            this.txtPrecoServico.Size = new System.Drawing.Size(64, 24);
            this.txtPrecoServico.TabIndex = 2;
            this.txtPrecoServico.TextChanged += new System.EventHandler(this.txtPrecoServico_TextChanged);
            this.txtPrecoServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoServico_KeyPress);
            this.txtPrecoServico.Leave += new System.EventHandler(this.txtPrecoServico_Leave_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 103;
            this.label1.Text = "Serviço";
            // 
            // dgvServico
            // 
            this.dgvServico.AllowUserToAddRows = false;
            this.dgvServico.AllowUserToDeleteRows = false;
            this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServico.Location = new System.Drawing.Point(17, 139);
            this.dgvServico.Name = "dgvServico";
            this.dgvServico.ReadOnly = true;
            this.dgvServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServico.Size = new System.Drawing.Size(371, 88);
            this.dgvServico.TabIndex = 93;
            this.dgvServico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServico_CellContentClick_1);
            this.dgvServico.DoubleClick += new System.EventHandler(this.dgvServico_DoubleClick_1);
            // 
            // groupCFOP
            // 
            this.groupCFOP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupCFOP.Controls.Add(this.btSalvarItem);
            this.groupCFOP.Controls.Add(this.label3);
            this.groupCFOP.Controls.Add(this.cbo_servico);
            this.groupCFOP.Controls.Add(this.txtPrecoServico);
            this.groupCFOP.Controls.Add(this.label1);
            this.groupCFOP.Controls.Add(this.dgvServico);
            this.groupCFOP.Controls.Add(this.grProfissinal);
            this.groupCFOP.Location = new System.Drawing.Point(12, 73);
            this.groupCFOP.Name = "groupCFOP";
            this.groupCFOP.Size = new System.Drawing.Size(402, 243);
            this.groupCFOP.TabIndex = 106;
            this.groupCFOP.TabStop = false;
            // 
            // btSalvarItem
            // 
            this.btSalvarItem.Image = ((System.Drawing.Image)(resources.GetObject("btSalvarItem.Image")));
            this.btSalvarItem.Location = new System.Drawing.Point(359, 109);
            this.btSalvarItem.Name = "btSalvarItem";
            this.btSalvarItem.Size = new System.Drawing.Size(27, 24);
            this.btSalvarItem.TabIndex = 3;
            this.btSalvarItem.UseVisualStyleBackColor = true;
            this.btSalvarItem.Click += new System.EventHandler(this.btSalvarItem_Click_1);
            // 
            // grProfissinal
            // 
            this.grProfissinal.Controls.Add(this.DtMovimentacao);
            this.grProfissinal.Controls.Add(this.label6);
            this.grProfissinal.Controls.Add(this.cbo_Profissional);
            this.grProfissinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grProfissinal.Location = new System.Drawing.Point(17, 16);
            this.grProfissinal.Name = "grProfissinal";
            this.grProfissinal.Size = new System.Drawing.Size(371, 68);
            this.grProfissinal.TabIndex = 90;
            this.grProfissinal.TabStop = false;
            this.grProfissinal.Text = "Profissional";
            // 
            // DtMovimentacao
            // 
            this.DtMovimentacao.Enabled = false;
            this.DtMovimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtMovimentacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtMovimentacao.Location = new System.Drawing.Point(263, 31);
            this.DtMovimentacao.MinDate = new System.DateTime(2017, 11, 16, 0, 0, 0, 0);
            this.DtMovimentacao.MinimumSize = new System.Drawing.Size(20, 20);
            this.DtMovimentacao.Name = "DtMovimentacao";
            this.DtMovimentacao.Size = new System.Drawing.Size(102, 20);
            this.DtMovimentacao.TabIndex = 114;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(263, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 113;
            this.label6.Text = "Movimentação";
            // 
            // cbo_Profissional
            // 
            this.cbo_Profissional.BackColor = System.Drawing.SystemColors.Window;
            this.cbo_Profissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Profissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Profissional.FormattingEnabled = true;
            this.cbo_Profissional.Location = new System.Drawing.Point(9, 29);
            this.cbo_Profissional.Name = "cbo_Profissional";
            this.cbo_Profissional.Size = new System.Drawing.Size(248, 24);
            this.cbo_Profissional.TabIndex = 0;
            // 
            // tooCFOP
            // 
            this.tooCFOP.Location = new System.Drawing.Point(0, 355);
            this.tooCFOP.Name = "tooCFOP";
            this.tooCFOP.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tooCFOP.Size = new System.Drawing.Size(428, 22);
            this.tooCFOP.TabIndex = 105;
            // 
            // btIncuir
            // 
            this.btIncuir.Image = ((System.Drawing.Image)(resources.GetObject("btIncuir.Image")));
            this.btIncuir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIncuir.Location = new System.Drawing.Point(220, 322);
            this.btIncuir.Name = "btIncuir";
            this.btIncuir.Size = new System.Drawing.Size(99, 27);
            this.btIncuir.TabIndex = 4;
            this.btIncuir.Text = "OK";
            this.btIncuir.UseVisualStyleBackColor = true;
            this.btIncuir.Click += new System.EventHandler(this.btIncuir_Click_1);
            // 
            // btExcluir
            // 
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(325, 322);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(89, 27);
            this.btExcluir.TabIndex = 5;
            this.btExcluir.TabStop = false;
            this.btExcluir.Text = "Cancelar";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click_1);
            // 
            // frmAtendimentoAvulso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 377);
            this.Controls.Add(this.btIncuir);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.groupCFOP);
            this.Controls.Add(this.tooCFOP);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAtendimentoAvulso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atendimento Avulso";
            this.Load += new System.EventHandler(this.frmAtendimentoAvulso_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAtendimentoAvulso_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
            this.groupCFOP.ResumeLayout(false);
            this.groupCFOP.PerformLayout();
            this.grProfissinal.ResumeLayout(false);
            this.grProfissinal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_servico;
        private System.Windows.Forms.TextBox txtPrecoServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvServico;
        private System.Windows.Forms.GroupBox groupCFOP;
        private System.Windows.Forms.StatusStrip tooCFOP;
        private System.Windows.Forms.Button btIncuir;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.ComboBox cbo_Profissional;
        public System.Windows.Forms.GroupBox grProfissinal;
        
        private System.Windows.Forms.Button btSalvarItem;
        private System.Windows.Forms.DateTimePicker DtMovimentacao;
        private System.Windows.Forms.Label label6;
    }
}