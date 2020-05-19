namespace GestaoSalao
{
    partial class frmLogin
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
            this.tabLogin = new System.Windows.Forms.TabControl();
            this.tabEmitente = new System.Windows.Forms.TabPage();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.tabLogin.SuspendLayout();
            this.tabEmitente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.tabEmitente);
            this.tabLogin.Location = new System.Drawing.Point(3, 69);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.SelectedIndex = 0;
            this.tabLogin.Size = new System.Drawing.Size(419, 165);
            this.tabLogin.TabIndex = 110;
            // 
            // tabEmitente
            // 
            this.tabEmitente.Controls.Add(this.btnAcessar);
            this.tabEmitente.Controls.Add(this.pictureBox1);
            this.tabEmitente.Controls.Add(this.btnSair);
            this.tabEmitente.Controls.Add(this.txtSenha);
            this.tabEmitente.Controls.Add(this.label1);
            this.tabEmitente.Controls.Add(this.txtLogin);
            this.tabEmitente.Controls.Add(this.lblDescricao);
            this.tabEmitente.Location = new System.Drawing.Point(4, 22);
            this.tabEmitente.Name = "tabEmitente";
            this.tabEmitente.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmitente.Size = new System.Drawing.Size(411, 139);
            this.tabEmitente.TabIndex = 0;
            this.tabEmitente.Text = "Acesso Restrito";
            this.tabEmitente.UseVisualStyleBackColor = true;
            // 
            // btnAcessar
            // 
            this.btnAcessar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcessar.Location = new System.Drawing.Point(280, 67);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(64, 27);
            this.btnAcessar.TabIndex = 3;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = true;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestaoSalao.Properties.Resources.users_person;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 128);
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(210, 67);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(64, 27);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(210, 41);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(134, 20);
            this.txtSenha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(161, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Senha:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(210, 15);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(134, 20);
            this.txtLogin.TabIndex = 0;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDescricao.ForeColor = System.Drawing.Color.Black;
            this.lblDescricao.Location = new System.Drawing.Point(161, 18);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(42, 13);
            this.lblDescricao.TabIndex = 71;
            this.lblDescricao.Text = "Login:";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 241);
            this.Controls.Add(this.tabLogin);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticação de usuário";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.tabLogin.ResumeLayout(false);
            this.tabEmitente.ResumeLayout(false);
            this.tabEmitente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLogin;
        private System.Windows.Forms.TabPage tabEmitente;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAcessar;
    }
}