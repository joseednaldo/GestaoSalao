namespace GestaoSalao
{
    partial class frmCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUsuario));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUsuario = new System.Windows.Forms.TabPage();
            this.txtcodUsuario = new System.Windows.Forms.TextBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_funcionario = new System.Windows.Forms.ComboBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.btIncuir = new System.Windows.Forms.Button();
            this.cbo_situacao = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.cbo_pefil = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRedefinirSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabUsuario.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUsuario);
            this.tabControl1.Location = new System.Drawing.Point(6, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 455);
            this.tabControl1.TabIndex = 82;
            // 
            // tabUsuario
            // 
            this.tabUsuario.Controls.Add(this.txtcodUsuario);
            this.tabUsuario.Controls.Add(this.btExcluir);
            this.tabUsuario.Controls.Add(this.label1);
            this.tabUsuario.Controls.Add(this.cbo_funcionario);
            this.tabUsuario.Controls.Add(this.btNovo);
            this.tabUsuario.Controls.Add(this.groupBox3);
            this.tabUsuario.Controls.Add(this.btIncuir);
            this.tabUsuario.Controls.Add(this.cbo_situacao);
            this.tabUsuario.Controls.Add(this.label6);
            this.tabUsuario.Controls.Add(this.txtLogin);
            this.tabUsuario.Controls.Add(this.cbo_pefil);
            this.tabUsuario.Controls.Add(this.label5);
            this.tabUsuario.Controls.Add(this.label4);
            this.tabUsuario.Controls.Add(this.txtRedefinirSenha);
            this.tabUsuario.Controls.Add(this.label2);
            this.tabUsuario.Controls.Add(this.txtSenha);
            this.tabUsuario.Controls.Add(this.label3);
            this.tabUsuario.Location = new System.Drawing.Point(4, 22);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuario.Size = new System.Drawing.Size(554, 429);
            this.tabUsuario.TabIndex = 0;
            this.tabUsuario.Text = "Usuários";
            this.tabUsuario.UseVisualStyleBackColor = true;
            // 
            // txtcodUsuario
            // 
            this.txtcodUsuario.Location = new System.Drawing.Point(438, 30);
            this.txtcodUsuario.Name = "txtcodUsuario";
            this.txtcodUsuario.Size = new System.Drawing.Size(36, 20);
            this.txtcodUsuario.TabIndex = 136;
            this.txtcodUsuario.Visible = false;
            // 
            // btExcluir
            // 
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(438, 396);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(105, 27);
            this.btExcluir.TabIndex = 135;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 134;
            this.label1.Text = "Informe um funcionário";
            // 
            // cbo_funcionario
            // 
            this.cbo_funcionario.BackColor = System.Drawing.SystemColors.Window;
            this.cbo_funcionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_funcionario.FormattingEnabled = true;
            this.cbo_funcionario.Location = new System.Drawing.Point(10, 136);
            this.cbo_funcionario.Name = "cbo_funcionario";
            this.cbo_funcionario.Size = new System.Drawing.Size(415, 24);
            this.cbo_funcionario.TabIndex = 129;
            // 
            // btNovo
            // 
            this.btNovo.Image = ((System.Drawing.Image)(resources.GetObject("btNovo.Image")));
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(228, 396);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(92, 27);
            this.btNovo.TabIndex = 133;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgUsuarios);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 224);
            this.groupBox3.TabIndex = 132;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de usuários";
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.AllowUserToAddRows = false;
            this.dgUsuarios.AllowUserToDeleteRows = false;
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Location = new System.Drawing.Point(6, 19);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.ReadOnly = true;
            this.dgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsuarios.Size = new System.Drawing.Size(521, 199);
            this.dgUsuarios.TabIndex = 49;
            this.dgUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuarios_CellContentClick);
            this.dgUsuarios.Click += new System.EventHandler(this.dgUsuarios_Click);
            // 
            // btIncuir
            // 
            this.btIncuir.Image = ((System.Drawing.Image)(resources.GetObject("btIncuir.Image")));
            this.btIncuir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIncuir.Location = new System.Drawing.Point(326, 396);
            this.btIncuir.Name = "btIncuir";
            this.btIncuir.Size = new System.Drawing.Size(106, 27);
            this.btIncuir.TabIndex = 83;
            this.btIncuir.Text = "OK";
            this.btIncuir.UseVisualStyleBackColor = true;
            this.btIncuir.Click += new System.EventHandler(this.btIncuir_Click);
            // 
            // cbo_situacao
            // 
            this.cbo_situacao.BackColor = System.Drawing.SystemColors.Window;
            this.cbo_situacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_situacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_situacao.FormattingEnabled = true;
            this.cbo_situacao.Location = new System.Drawing.Point(10, 72);
            this.cbo_situacao.Name = "cbo_situacao";
            this.cbo_situacao.Size = new System.Drawing.Size(121, 24);
            this.cbo_situacao.TabIndex = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 126;
            this.label6.Text = "Situação";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(6, 30);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(205, 20);
            this.txtLogin.TabIndex = 117;
            // 
            // cbo_pefil
            // 
            this.cbo_pefil.BackColor = System.Drawing.SystemColors.Window;
            this.cbo_pefil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_pefil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_pefil.FormattingEnabled = true;
            this.cbo_pefil.Location = new System.Drawing.Point(137, 72);
            this.cbo_pefil.Name = "cbo_pefil";
            this.cbo_pefil.Size = new System.Drawing.Size(288, 24);
            this.cbo_pefil.TabIndex = 123;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(134, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 124;
            this.label5.Text = "Perfil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(317, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 122;
            this.label4.Text = "Confirme a senha";
            // 
            // txtRedefinirSenha
            // 
            this.txtRedefinirSenha.Location = new System.Drawing.Point(320, 30);
            this.txtRedefinirSenha.Name = "txtRedefinirSenha";
            this.txtRedefinirSenha.PasswordChar = '*';
            this.txtRedefinirSenha.Size = new System.Drawing.Size(105, 20);
            this.txtRedefinirSenha.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(214, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 120;
            this.label2.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(217, 30);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(97, 20);
            this.txtSenha.TabIndex = 119;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 116;
            this.label3.Text = "E-mail de login";
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 532);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.frmCadastroUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroUsuario_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabUsuario.ResumeLayout(false);
            this.tabUsuario.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRedefinirSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_situacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_pefil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btIncuir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.ComboBox cbo_funcionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.TextBox txtcodUsuario;
    }
}