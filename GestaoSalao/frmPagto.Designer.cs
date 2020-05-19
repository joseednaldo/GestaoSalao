namespace GestaoSalao
{
    partial class frmPagto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagto));
            this.btIncuir = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.tabEmitente = new System.Windows.Forms.TabPage();
            this.OptCartaoDebito = new System.Windows.Forms.RadioButton();
            this.OptDinheiro = new System.Windows.Forms.RadioButton();
            this.tooDespesas = new System.Windows.Forms.StatusStrip();
            this.tabFormaPgto = new System.Windows.Forms.TabControl();
            this.tabEmitente.SuspendLayout();
            this.tabFormaPgto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btIncuir
            // 
            this.btIncuir.Image = ((System.Drawing.Image)(resources.GetObject("btIncuir.Image")));
            this.btIncuir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIncuir.Location = new System.Drawing.Point(51, 193);
            this.btIncuir.Name = "btIncuir";
            this.btIncuir.Size = new System.Drawing.Size(87, 27);
            this.btIncuir.TabIndex = 109;
            this.btIncuir.Text = "OK";
            this.btIncuir.UseVisualStyleBackColor = true;
            this.btIncuir.Click += new System.EventHandler(this.btIncuir_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(144, 193);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(86, 27);
            this.btExcluir.TabIndex = 110;
            this.btExcluir.TabStop = false;
            this.btExcluir.Text = "Cancelar";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // tabEmitente
            // 
            this.tabEmitente.Controls.Add(this.OptCartaoDebito);
            this.tabEmitente.Controls.Add(this.OptDinheiro);
            this.tabEmitente.Location = new System.Drawing.Point(4, 22);
            this.tabEmitente.Name = "tabEmitente";
            this.tabEmitente.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmitente.Size = new System.Drawing.Size(214, 92);
            this.tabEmitente.TabIndex = 0;
            this.tabEmitente.Text = "Escolha a forma de pagamento";
            this.tabEmitente.UseVisualStyleBackColor = true;
            // 
            // OptCartaoDebito
            // 
            this.OptCartaoDebito.AutoSize = true;
            this.OptCartaoDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptCartaoDebito.Location = new System.Drawing.Point(6, 39);
            this.OptCartaoDebito.Name = "OptCartaoDebito";
            this.OptCartaoDebito.Size = new System.Drawing.Size(62, 17);
            this.OptCartaoDebito.TabIndex = 1;
            this.OptCartaoDebito.Text = "Cartão";
            this.OptCartaoDebito.UseVisualStyleBackColor = true;
            // 
            // OptDinheiro
            // 
            this.OptDinheiro.AutoSize = true;
            this.OptDinheiro.Checked = true;
            this.OptDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptDinheiro.Location = new System.Drawing.Point(6, 16);
            this.OptDinheiro.Name = "OptDinheiro";
            this.OptDinheiro.Size = new System.Drawing.Size(72, 17);
            this.OptDinheiro.TabIndex = 0;
            this.OptDinheiro.TabStop = true;
            this.OptDinheiro.Text = "Dinheiro";
            this.OptDinheiro.UseVisualStyleBackColor = true;
            this.OptDinheiro.CheckedChanged += new System.EventHandler(this.OptDinheiro_CheckedChanged);
            // 
            // tooDespesas
            // 
            this.tooDespesas.Location = new System.Drawing.Point(0, 235);
            this.tooDespesas.Name = "tooDespesas";
            this.tooDespesas.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tooDespesas.Size = new System.Drawing.Size(243, 22);
            this.tooDespesas.TabIndex = 111;
            // 
            // tabFormaPgto
            // 
            this.tabFormaPgto.Controls.Add(this.tabEmitente);
            this.tabFormaPgto.Location = new System.Drawing.Point(12, 73);
            this.tabFormaPgto.Name = "tabFormaPgto";
            this.tabFormaPgto.SelectedIndex = 0;
            this.tabFormaPgto.Size = new System.Drawing.Size(222, 118);
            this.tabFormaPgto.TabIndex = 108;
            // 
            // frmPagto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 257);
            this.ControlBox = false;
            this.Controls.Add(this.btIncuir);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.tooDespesas);
            this.Controls.Add(this.tabFormaPgto);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPagto";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma de Pagamento";
            this.Load += new System.EventHandler(this.frmPagto_Load);
            this.tabEmitente.ResumeLayout(false);
            this.tabEmitente.PerformLayout();
            this.tabFormaPgto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIncuir;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.TabPage tabEmitente;
        private System.Windows.Forms.StatusStrip tooDespesas;
        private System.Windows.Forms.TabControl tabFormaPgto;
        private System.Windows.Forms.RadioButton OptCartaoDebito;
        private System.Windows.Forms.RadioButton OptDinheiro;
    }
}