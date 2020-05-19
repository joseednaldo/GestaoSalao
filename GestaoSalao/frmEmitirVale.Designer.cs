namespace GestaoSalao
{
    partial class frmEmitirVale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmitirVale));
            this.label3 = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btIncuir = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.cbo_funcionario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtVale = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorVale = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabEmitente = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tooDespesas = new System.Windows.Forms.StatusStrip();
            this.tabEmitente.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 110;
            this.label3.Text = "Descrição";
            // 
            // btExcluir
            // 
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(451, 261);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(105, 27);
            this.btExcluir.TabIndex = 86;
            this.btExcluir.TabStop = false;
            this.btExcluir.Text = "Cancelar";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btIncuir
            // 
            this.btIncuir.Image = ((System.Drawing.Image)(resources.GetObject("btIncuir.Image")));
            this.btIncuir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIncuir.Location = new System.Drawing.Point(339, 261);
            this.btIncuir.Name = "btIncuir";
            this.btIncuir.Size = new System.Drawing.Size(106, 27);
            this.btIncuir.TabIndex = 85;
            this.btIncuir.Text = "OK";
            this.btIncuir.UseVisualStyleBackColor = true;
            this.btIncuir.Click += new System.EventHandler(this.btIncuir_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(9, 84);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(520, 56);
            this.txtObservacao.TabIndex = 109;
            // 
            // cbo_funcionario
            // 
            this.cbo_funcionario.BackColor = System.Drawing.SystemColors.Window;
            this.cbo_funcionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_funcionario.FormattingEnabled = true;
            this.cbo_funcionario.Location = new System.Drawing.Point(9, 31);
            this.cbo_funcionario.Name = "cbo_funcionario";
            this.cbo_funcionario.Size = new System.Drawing.Size(325, 24);
            this.cbo_funcionario.TabIndex = 107;
            this.cbo_funcionario.TextChanged += new System.EventHandler(this.cbo_funcionario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Funcionário";
            // 
            // dtVale
            // 
            this.dtVale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVale.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtVale.Location = new System.Drawing.Point(340, 33);
            this.dtVale.MinDate = new System.DateTime(2017, 11, 16, 0, 0, 0, 0);
            this.dtVale.MinimumSize = new System.Drawing.Size(20, 20);
            this.dtVale.Name = "dtVale";
            this.dtVale.Size = new System.Drawing.Size(102, 20);
            this.dtVale.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(337, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Data";
            // 
            // txtValorVale
            // 
            this.txtValorVale.Location = new System.Drawing.Point(448, 33);
            this.txtValorVale.Name = "txtValorVale";
            this.txtValorVale.Size = new System.Drawing.Size(81, 20);
            this.txtValorVale.TabIndex = 65;
            this.txtValorVale.TextChanged += new System.EventHandler(this.txtValorVale_TextChanged);
            this.txtValorVale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVale_KeyPress);
            this.txtValorVale.Leave += new System.EventHandler(this.txtValorVale_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(445, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Valor";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabEmitente
            // 
            this.tabEmitente.Controls.Add(this.label3);
            this.tabEmitente.Controls.Add(this.txtObservacao);
            this.tabEmitente.Controls.Add(this.cbo_funcionario);
            this.tabEmitente.Controls.Add(this.label1);
            this.tabEmitente.Controls.Add(this.dtVale);
            this.tabEmitente.Controls.Add(this.label6);
            this.tabEmitente.Controls.Add(this.txtValorVale);
            this.tabEmitente.Controls.Add(this.label8);
            this.tabEmitente.Location = new System.Drawing.Point(4, 22);
            this.tabEmitente.Name = "tabEmitente";
            this.tabEmitente.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmitente.Size = new System.Drawing.Size(541, 163);
            this.tabEmitente.TabIndex = 0;
            this.tabEmitente.Text = "Vale";
            this.tabEmitente.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEmitente);
            this.tabControl1.Location = new System.Drawing.Point(7, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 189);
            this.tabControl1.TabIndex = 84;
            // 
            // tooDespesas
            // 
            this.tooDespesas.Location = new System.Drawing.Point(0, 287);
            this.tooDespesas.Name = "tooDespesas";
            this.tooDespesas.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tooDespesas.Size = new System.Drawing.Size(564, 22);
            this.tooDespesas.TabIndex = 107;
            // 
            // frmEmitirVale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 309);
            this.Controls.Add(this.tooDespesas);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btIncuir);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmitirVale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançar vale";
            this.Load += new System.EventHandler(this.frmEmitirVale_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEmitirVale_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmEmitirVale_KeyPress);
            this.Leave += new System.EventHandler(this.frmEmitirVale_Leave);
            this.tabEmitente.ResumeLayout(false);
            this.tabEmitente.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btIncuir;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.ComboBox cbo_funcionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtVale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorVale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabEmitente;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.StatusStrip tooDespesas;
    }
}