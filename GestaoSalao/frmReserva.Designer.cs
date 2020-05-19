namespace GestaoSalao
{
    partial class frmReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReserva));
            this.btExcluir = new System.Windows.Forms.Button();
            this.tooCFOP = new System.Windows.Forms.StatusStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.groupCFOP = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_servico = new System.Windows.Forms.ComboBox();
            this.txtPrecoServico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btIncluir = new System.Windows.Forms.Button();
            this.dgvServico = new System.Windows.Forms.DataGridView();
            this.txtFone1 = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.grProfissinal = new System.Windows.Forms.GroupBox();
            this.txtProfissional = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDetalhe = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_profissional = new System.Windows.Forms.ComboBox();
            this.btIncuir = new System.Windows.Forms.Button();
            this.txtDiaAgendamento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.cbo_Cliente = new System.Windows.Forms.ComboBox();
            this.groupCFOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
            this.grProfissinal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btExcluir
            // 
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(306, 490);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(105, 27);
            this.btExcluir.TabIndex = 5;
            this.btExcluir.TabStop = false;
            this.btExcluir.Text = "Cancelar";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // tooCFOP
            // 
            this.tooCFOP.Location = new System.Drawing.Point(0, 524);
            this.tooCFOP.Name = "tooCFOP";
            this.tooCFOP.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tooCFOP.Size = new System.Drawing.Size(426, 22);
            this.tooCFOP.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Cliente";
            // 
            // groupCFOP
            // 
            this.groupCFOP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupCFOP.Controls.Add(this.label3);
            this.groupCFOP.Controls.Add(this.txtCliente);
            this.groupCFOP.Controls.Add(this.cbo_servico);
            this.groupCFOP.Controls.Add(this.txtPrecoServico);
            this.groupCFOP.Controls.Add(this.label1);
            this.groupCFOP.Controls.Add(this.btIncluir);
            this.groupCFOP.Controls.Add(this.dgvServico);
            this.groupCFOP.Controls.Add(this.txtFone1);
            this.groupCFOP.Controls.Add(this.label17);
            this.groupCFOP.Controls.Add(this.grProfissinal);
            this.groupCFOP.Controls.Add(this.label7);
            this.groupCFOP.Controls.Add(this.txtDetalhe);
            this.groupCFOP.Controls.Add(this.label2);
            this.groupCFOP.Location = new System.Drawing.Point(12, 77);
            this.groupCFOP.Name = "groupCFOP";
            this.groupCFOP.Size = new System.Drawing.Size(399, 407);
            this.groupCFOP.TabIndex = 65;
            this.groupCFOP.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(288, 143);
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
            this.cbo_servico.Location = new System.Drawing.Point(19, 159);
            this.cbo_servico.Name = "cbo_servico";
            this.cbo_servico.Size = new System.Drawing.Size(266, 24);
            this.cbo_servico.TabIndex = 105;
            // 
            // txtPrecoServico
            // 
            this.txtPrecoServico.Location = new System.Drawing.Point(291, 159);
            this.txtPrecoServico.Multiline = true;
            this.txtPrecoServico.Name = "txtPrecoServico";
            this.txtPrecoServico.Size = new System.Drawing.Size(58, 24);
            this.txtPrecoServico.TabIndex = 0;
            this.txtPrecoServico.TextChanged += new System.EventHandler(this.txtPrecoServico_TextChanged);
            this.txtPrecoServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoServico_KeyPress);
            this.txtPrecoServico.Leave += new System.EventHandler(this.txtPrecoServico_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 103;
            this.label1.Text = "Serviço";
            // 
            // btIncluir
            // 
            this.btIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btIncluir.Image")));
            this.btIncluir.Location = new System.Drawing.Point(355, 159);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(33, 27);
            this.btIncluir.TabIndex = 1;
            this.btIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // dgvServico
            // 
            this.dgvServico.AllowUserToAddRows = false;
            this.dgvServico.AllowUserToDeleteRows = false;
            this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServico.Location = new System.Drawing.Point(17, 192);
            this.dgvServico.Name = "dgvServico";
            this.dgvServico.ReadOnly = true;
            this.dgvServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServico.Size = new System.Drawing.Size(371, 113);
            this.dgvServico.TabIndex = 93;
            this.dgvServico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServico_CellContentClick);
            this.dgvServico.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvServico_UserDeletedRow);
            this.dgvServico.DoubleClick += new System.EventHandler(this.dgvServico_DoubleClick);
            // 
            // txtFone1
            // 
            this.txtFone1.Location = new System.Drawing.Point(294, 111);
            this.txtFone1.Mask = "00000-0000";
            this.txtFone1.Name = "txtFone1";
            this.txtFone1.Size = new System.Drawing.Size(97, 20);
            this.txtFone1.TabIndex = 91;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(291, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 92;
            this.label17.Text = "Celular";
            // 
            // grProfissinal
            // 
            this.grProfissinal.Controls.Add(this.txtProfissional);
            this.grProfissinal.Enabled = false;
            this.grProfissinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grProfissinal.Location = new System.Drawing.Point(17, 16);
            this.grProfissinal.Name = "grProfissinal";
            this.grProfissinal.Size = new System.Drawing.Size(371, 68);
            this.grProfissinal.TabIndex = 90;
            this.grProfissinal.TabStop = false;
            this.grProfissinal.Text = "Profissional";
            // 
            // txtProfissional
            // 
            this.txtProfissional.Location = new System.Drawing.Point(17, 29);
            this.txtProfissional.Multiline = true;
            this.txtProfissional.Name = "txtProfissional";
            this.txtProfissional.Size = new System.Drawing.Size(339, 23);
            this.txtProfissional.TabIndex = 91;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "Observações";
            // 
            // txtDetalhe
            // 
            this.txtDetalhe.Location = new System.Drawing.Point(17, 338);
            this.txtDetalhe.Multiline = true;
            this.txtDetalhe.Name = "txtDetalhe";
            this.txtDetalhe.Size = new System.Drawing.Size(371, 53);
            this.txtDetalhe.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(866, 185);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 108);
            this.textBox1.TabIndex = 96;
            this.textBox1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(917, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "Horário";
            this.label4.Visible = false;
            // 
            // cbo_profissional
            // 
            this.cbo_profissional.BackColor = System.Drawing.SystemColors.Window;
            this.cbo_profissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_profissional.FormattingEnabled = true;
            this.cbo_profissional.Location = new System.Drawing.Point(912, 311);
            this.cbo_profissional.Name = "cbo_profissional";
            this.cbo_profissional.Size = new System.Drawing.Size(53, 24);
            this.cbo_profissional.TabIndex = 75;
            this.cbo_profissional.Visible = false;
            // 
            // btIncuir
            // 
            this.btIncuir.Image = ((System.Drawing.Image)(resources.GetObject("btIncuir.Image")));
            this.btIncuir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIncuir.Location = new System.Drawing.Point(194, 490);
            this.btIncuir.Name = "btIncuir";
            this.btIncuir.Size = new System.Drawing.Size(106, 27);
            this.btIncuir.TabIndex = 4;
            this.btIncuir.Text = "OK";
            this.btIncuir.UseVisualStyleBackColor = true;
            this.btIncuir.Click += new System.EventHandler(this.btIncuir_Click);
            // 
            // txtDiaAgendamento
            // 
            this.txtDiaAgendamento.Location = new System.Drawing.Point(866, 256);
            this.txtDiaAgendamento.Multiline = true;
            this.txtDiaAgendamento.Name = "txtDiaAgendamento";
            this.txtDiaAgendamento.Size = new System.Drawing.Size(82, 108);
            this.txtDiaAgendamento.TabIndex = 97;
            this.txtDiaAgendamento.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(915, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 101;
            this.label6.Text = "Serviço";
            this.label6.Visible = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(899, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 104;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(20, 111);
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(268, 20);
            this.txtCliente.TabIndex = 108;
            // 
            // cbo_Cliente
            // 
            this.cbo_Cliente.BackColor = System.Drawing.SystemColors.Window;
            this.cbo_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Cliente.FormattingEnabled = true;
            this.cbo_Cliente.Location = new System.Drawing.Point(879, 415);
            this.cbo_Cliente.Name = "cbo_Cliente";
            this.cbo_Cliente.Size = new System.Drawing.Size(86, 24);
            this.cbo_Cliente.TabIndex = 109;
            this.cbo_Cliente.Visible = false;
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 546);
            this.Controls.Add(this.cbo_Cliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiaAgendamento);
            this.Controls.Add(this.btIncuir);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.tooCFOP);
            this.Controls.Add(this.groupCFOP);
            this.Controls.Add(this.cbo_profissional);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar";
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmReserva_KeyDown);
            this.groupCFOP.ResumeLayout(false);
            this.groupCFOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
            this.grProfissinal.ResumeLayout(false);
            this.grProfissinal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.StatusStrip tooCFOP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupCFOP;
        private System.Windows.Forms.TextBox txtDetalhe;
        private System.Windows.Forms.ComboBox cbo_profissional;
        private System.Windows.Forms.Button btIncuir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grProfissinal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProfissional;
        private System.Windows.Forms.MaskedTextBox txtFone1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDiaAgendamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvServico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_servico;
        private System.Windows.Forms.TextBox txtPrecoServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ComboBox cbo_Cliente;
    }
}