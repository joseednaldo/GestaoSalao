namespace GestaoSalao
{
    partial class frmDespesas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDespesas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEmitente = new System.Windows.Forms.TabPage();
            this.chkQuitarDespesa = new System.Windows.Forms.CheckBox();
            this.txtObserv = new System.Windows.Forms.TextBox();
            this.cbo_Profissional = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.cbo_fornecedores = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_tipo_despesa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDespesa = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorDespesa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tooDespesas = new System.Windows.Forms.StatusStrip();
            this.lblVale = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btIncuir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabEmitente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEmitente);
            this.tabControl1.Location = new System.Drawing.Point(8, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 284);
            this.tabControl1.TabIndex = 81;
            // 
            // tabEmitente
            // 
            this.tabEmitente.Controls.Add(this.lblVale);
            this.tabEmitente.Controls.Add(this.chkQuitarDespesa);
            this.tabEmitente.Controls.Add(this.txtObserv);
            this.tabEmitente.Controls.Add(this.cbo_Profissional);
            this.tabEmitente.Controls.Add(this.label3);
            this.tabEmitente.Controls.Add(this.txtDescricao);
            this.tabEmitente.Controls.Add(this.label5);
            this.tabEmitente.Controls.Add(this.txtDocumento);
            this.tabEmitente.Controls.Add(this.cbo_fornecedores);
            this.tabEmitente.Controls.Add(this.lblTitulo);
            this.tabEmitente.Controls.Add(this.label2);
            this.tabEmitente.Controls.Add(this.cbo_tipo_despesa);
            this.tabEmitente.Controls.Add(this.label1);
            this.tabEmitente.Controls.Add(this.dtpDespesa);
            this.tabEmitente.Controls.Add(this.label6);
            this.tabEmitente.Controls.Add(this.txtValorDespesa);
            this.tabEmitente.Controls.Add(this.label8);
            this.tabEmitente.Location = new System.Drawing.Point(4, 22);
            this.tabEmitente.Name = "tabEmitente";
            this.tabEmitente.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmitente.Size = new System.Drawing.Size(638, 258);
            this.tabEmitente.TabIndex = 0;
            this.tabEmitente.Text = "Despesas";
            this.tabEmitente.UseVisualStyleBackColor = true;
            // 
            // chkQuitarDespesa
            // 
            this.chkQuitarDespesa.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkQuitarDespesa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkQuitarDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkQuitarDespesa.Location = new System.Drawing.Point(207, 135);
            this.chkQuitarDespesa.Name = "chkQuitarDespesa";
            this.chkQuitarDespesa.Size = new System.Drawing.Size(128, 20);
            this.chkQuitarDespesa.TabIndex = 117;
            this.chkQuitarDespesa.Text = "Quitar Despesa";
            this.chkQuitarDespesa.UseVisualStyleBackColor = true;
            this.chkQuitarDespesa.Visible = false;
            // 
            // txtObserv
            // 
            this.txtObserv.Location = new System.Drawing.Point(9, 181);
            this.txtObserv.Multiline = true;
            this.txtObserv.Name = "txtObserv";
            this.txtObserv.Size = new System.Drawing.Size(619, 59);
            this.txtObserv.TabIndex = 6;
            // 
            // cbo_Profissional
            // 
            this.cbo_Profissional.BackColor = System.Drawing.SystemColors.Window;
            this.cbo_Profissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Profissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Profissional.FormattingEnabled = true;
            this.cbo_Profissional.Location = new System.Drawing.Point(326, 76);
            this.cbo_Profissional.Name = "cbo_Profissional";
            this.cbo_Profissional.Size = new System.Drawing.Size(302, 24);
            this.cbo_Profissional.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 116;
            this.label3.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(8, 30);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(312, 20);
            this.txtDescricao.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(323, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 114;
            this.label5.Text = "Número do Doc.";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(326, 30);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(303, 20);
            this.txtDocumento.TabIndex = 1;
            // 
            // cbo_fornecedores
            // 
            this.cbo_fornecedores.BackColor = System.Drawing.SystemColors.Window;
            this.cbo_fornecedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_fornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_fornecedores.FormattingEnabled = true;
            this.cbo_fornecedores.Location = new System.Drawing.Point(326, 76);
            this.cbo_fornecedores.Name = "cbo_fornecedores";
            this.cbo_fornecedores.Size = new System.Drawing.Size(256, 24);
            this.cbo_fornecedores.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(323, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(70, 13);
            this.lblTitulo.TabIndex = 111;
            this.lblTitulo.Text = "Favorecido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 108;
            this.label2.Text = "Observação";
            // 
            // cbo_tipo_despesa
            // 
            this.cbo_tipo_despesa.BackColor = System.Drawing.SystemColors.Window;
            this.cbo_tipo_despesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo_despesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tipo_despesa.FormattingEnabled = true;
            this.cbo_tipo_despesa.Location = new System.Drawing.Point(8, 76);
            this.cbo_tipo_despesa.Name = "cbo_tipo_despesa";
            this.cbo_tipo_despesa.Size = new System.Drawing.Size(312, 24);
            this.cbo_tipo_despesa.TabIndex = 2;
            this.cbo_tipo_despesa.SelectedIndexChanged += new System.EventHandler(this.cbo_tipo_despesa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Despesa";
            // 
            // dtpDespesa
            // 
            this.dtpDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDespesa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDespesa.Location = new System.Drawing.Point(99, 135);
            this.dtpDespesa.MinDate = new System.DateTime(2017, 11, 16, 0, 0, 0, 0);
            this.dtpDespesa.MinimumSize = new System.Drawing.Size(20, 20);
            this.dtpDespesa.Name = "dtpDespesa";
            this.dtpDespesa.Size = new System.Drawing.Size(102, 20);
            this.dtpDespesa.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Vencimento";
            // 
            // txtValorDespesa
            // 
            this.txtValorDespesa.Location = new System.Drawing.Point(12, 135);
            this.txtValorDespesa.Name = "txtValorDespesa";
            this.txtValorDespesa.Size = new System.Drawing.Size(81, 20);
            this.txtValorDespesa.TabIndex = 4;
            this.txtValorDespesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorDespesa_KeyPress);
            this.txtValorDespesa.Leave += new System.EventHandler(this.txtValorDespesa_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Valor";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tooDespesas
            // 
            this.tooDespesas.Location = new System.Drawing.Point(0, 392);
            this.tooDespesas.Name = "tooDespesas";
            this.tooDespesas.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tooDespesas.Size = new System.Drawing.Size(676, 22);
            this.tooDespesas.TabIndex = 106;
            // 
            // lblVale
            // 
            this.lblVale.AutoSize = true;
            this.lblVale.BackColor = System.Drawing.Color.Aqua;
            this.lblVale.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblVale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVale.ForeColor = System.Drawing.Color.Black;
            this.lblVale.Location = new System.Drawing.Point(399, 60);
            this.lblVale.Name = "lblVale";
            this.lblVale.Size = new System.Drawing.Size(106, 13);
            this.lblVale.TabIndex = 118;
            this.lblVale.Text = "Ver Ùltimos Vales";
            this.lblVale.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblVale.Visible = false;
            this.lblVale.Click += new System.EventHandler(this.lblVale_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(549, 356);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(105, 27);
            this.btExcluir.TabIndex = 9;
            this.btExcluir.TabStop = false;
            this.btExcluir.Text = "Cancelar";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click_1);
            // 
            // btIncuir
            // 
            this.btIncuir.Image = ((System.Drawing.Image)(resources.GetObject("btIncuir.Image")));
            this.btIncuir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIncuir.Location = new System.Drawing.Point(437, 356);
            this.btIncuir.Name = "btIncuir";
            this.btIncuir.Size = new System.Drawing.Size(106, 27);
            this.btIncuir.TabIndex = 6;
            this.btIncuir.Text = "OK";
            this.btIncuir.UseVisualStyleBackColor = true;
            this.btIncuir.Click += new System.EventHandler(this.btIncuir_Click);
            // 
            // frmDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 414);
            this.Controls.Add(this.tooDespesas);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btIncuir);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançar despesas";
            this.Load += new System.EventHandler(this.frmDespesas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDespesas_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabEmitente.ResumeLayout(false);
            this.tabEmitente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEmitente;
        private System.Windows.Forms.DateTimePicker dtpDespesa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorDespesa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_tipo_despesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btIncuir;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.ComboBox cbo_fornecedores;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.StatusStrip tooDespesas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cbo_Profissional;
        private System.Windows.Forms.TextBox txtObserv;
        private System.Windows.Forms.CheckBox chkQuitarDespesa;
        private System.Windows.Forms.Label lblVale;
    }
}