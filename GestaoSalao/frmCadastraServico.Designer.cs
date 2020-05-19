namespace GestaoSalao
{
    partial class frmCadastraServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastraServico));
            this.tooCFOP = new System.Windows.Forms.StatusStrip();
            this.btNovo = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btIncuir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvServico = new System.Windows.Forms.DataGridView();
            this.txtPrecoServico = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.groupCFOP = new System.Windows.Forms.GroupBox();
            this.btEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
            this.groupCFOP.SuspendLayout();
            this.SuspendLayout();
            // 
            // tooCFOP
            // 
            this.tooCFOP.Location = new System.Drawing.Point(0, 440);
            this.tooCFOP.Name = "tooCFOP";
            this.tooCFOP.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tooCFOP.Size = new System.Drawing.Size(538, 22);
            this.tooCFOP.TabIndex = 48;
            // 
            // btNovo
            // 
            this.btNovo.Image = ((System.Drawing.Image)(resources.GetObject("btNovo.Image")));
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(92, 407);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(107, 27);
            this.btNovo.TabIndex = 2;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(426, 407);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(105, 27);
            this.btExcluir.TabIndex = 60;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btIncuir
            // 
            this.btIncuir.Image = ((System.Drawing.Image)(resources.GetObject("btIncuir.Image")));
            this.btIncuir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIncuir.Location = new System.Drawing.Point(205, 407);
            this.btIncuir.Name = "btIncuir";
            this.btIncuir.Size = new System.Drawing.Size(106, 27);
            this.btIncuir.TabIndex = 61;
            this.btIncuir.Text = "Incluir";
            this.btIncuir.UseVisualStyleBackColor = true;
            this.btIncuir.Click += new System.EventHandler(this.btIncuir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Preço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Serviço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Código";
            // 
            // dgvServico
            // 
            this.dgvServico.AllowUserToAddRows = false;
            this.dgvServico.AllowUserToDeleteRows = false;
            this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServico.Location = new System.Drawing.Point(6, 64);
            this.dgvServico.Name = "dgvServico";
            this.dgvServico.ReadOnly = true;
            this.dgvServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServico.Size = new System.Drawing.Size(517, 265);
            this.dgvServico.TabIndex = 48;
            this.dgvServico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServico_CellContentClick);
            this.dgvServico.Click += new System.EventHandler(this.dgvServico_Click);
            // 
            // txtPrecoServico
            // 
            this.txtPrecoServico.Location = new System.Drawing.Point(397, 38);
            this.txtPrecoServico.Name = "txtPrecoServico";
            this.txtPrecoServico.Size = new System.Drawing.Size(123, 20);
            this.txtPrecoServico.TabIndex = 1;
            this.txtPrecoServico.TextChanged += new System.EventHandler(this.txtPrecoServico_TextChanged);
            this.txtPrecoServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoServico_KeyPress);
            this.txtPrecoServico.Leave += new System.EventHandler(this.txtPrecoServico_Leave);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(50, 38);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(341, 20);
            this.txtDescricao.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.HideSelection = false;
            this.txtCodigo.Location = new System.Drawing.Point(4, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(40, 20);
            this.txtCodigo.TabIndex = 46;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupCFOP
            // 
            this.groupCFOP.Controls.Add(this.label3);
            this.groupCFOP.Controls.Add(this.label2);
            this.groupCFOP.Controls.Add(this.label1);
            this.groupCFOP.Controls.Add(this.dgvServico);
            this.groupCFOP.Controls.Add(this.txtPrecoServico);
            this.groupCFOP.Controls.Add(this.txtDescricao);
            this.groupCFOP.Controls.Add(this.txtCodigo);
            this.groupCFOP.Location = new System.Drawing.Point(0, 66);
            this.groupCFOP.Name = "groupCFOP";
            this.groupCFOP.Size = new System.Drawing.Size(531, 335);
            this.groupCFOP.TabIndex = 59;
            this.groupCFOP.TabStop = false;
            // 
            // btEditar
            // 
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEditar.Location = new System.Drawing.Point(317, 407);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(103, 27);
            this.btEditar.TabIndex = 63;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // frmCadastraServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 462);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btIncuir);
            this.Controls.Add(this.groupCFOP);
            this.Controls.Add(this.tooCFOP);
            this.KeyPreview = true;
            this.Name = "frmCadastraServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de serviço";
            this.Load += new System.EventHandler(this.frmCadastraServico_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastraServico_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
            this.groupCFOP.ResumeLayout(false);
            this.groupCFOP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip tooCFOP;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btIncuir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvServico;
        private System.Windows.Forms.TextBox txtPrecoServico;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupCFOP;
        private System.Windows.Forms.Button btEditar;
    }
}