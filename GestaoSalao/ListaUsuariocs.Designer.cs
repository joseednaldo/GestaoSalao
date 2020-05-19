namespace GestaoSalao
{
    partial class ListaUsuariocs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaUsuariocs));
            this.gridLista = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grProfissinal = new System.Windows.Forms.GroupBox();
            this.chkFiltroFuncionario = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_Profissional = new System.Windows.Forms.ComboBox();
            this.tooDespesas = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grProfissinal.SuspendLayout();
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
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.grProfissinal);
            this.groupBox3.Controls.Add(this.gridLista);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(732, 352);
            this.groupBox3.TabIndex = 108;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consulta";
            // 
            // grProfissinal
            // 
            this.grProfissinal.Controls.Add(this.chkFiltroFuncionario);
            this.grProfissinal.Controls.Add(this.button5);
            this.grProfissinal.Controls.Add(this.button1);
            this.grProfissinal.Controls.Add(this.label1);
            this.grProfissinal.Controls.Add(this.cbo_Profissional);
            this.grProfissinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grProfissinal.Location = new System.Drawing.Point(6, 19);
            this.grProfissinal.Name = "grProfissinal";
            this.grProfissinal.Size = new System.Drawing.Size(714, 75);
            this.grProfissinal.TabIndex = 92;
            this.grProfissinal.TabStop = false;
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
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(602, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 25);
            this.button5.TabIndex = 89;
            this.button5.Text = "Sair";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(603, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 27);
            this.button1.TabIndex = 87;
            this.button1.Text = "Procurar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // cbo_Profissional
            // 
            this.cbo_Profissional.BackColor = System.Drawing.SystemColors.Window;
            this.cbo_Profissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Profissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Profissional.FormattingEnabled = true;
            this.cbo_Profissional.Location = new System.Drawing.Point(9, 32);
            this.cbo_Profissional.Name = "cbo_Profissional";
            this.cbo_Profissional.Size = new System.Drawing.Size(226, 24);
            this.cbo_Profissional.TabIndex = 0;
            // 
            // tooDespesas
            // 
            this.tooDespesas.Location = new System.Drawing.Point(0, 430);
            this.tooDespesas.Name = "tooDespesas";
            this.tooDespesas.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tooDespesas.Size = new System.Drawing.Size(753, 22);
            this.tooDespesas.TabIndex = 109;
            // 
            // ListaUsuariocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 452);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tooDespesas);
            this.Name = "ListaUsuariocs";
            this.Text = "ListaUsuariocs";
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.grProfissinal.ResumeLayout(false);
            this.grProfissinal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLista;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.GroupBox grProfissinal;
        private System.Windows.Forms.CheckBox chkFiltroFuncionario;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_Profissional;
        private System.Windows.Forms.StatusStrip tooDespesas;
    }
}