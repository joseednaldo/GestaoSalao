namespace GestaoSalao
{
    partial class frmFuncionario2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionario2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEmitente = new System.Windows.Forms.TabPage();
            this.gridMotorista = new System.Windows.Forms.GroupBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtFone2 = new System.Windows.Forms.MaskedTextBox();
            this.txtFone1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btEditar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btIncuir = new System.Windows.Forms.Button();
            this.tooVeiculo = new System.Windows.Forms.StatusStrip();
            this.tabControl1.SuspendLayout();
            this.tabEmitente.SuspendLayout();
            this.gridMotorista.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEmitente);
            this.tabControl1.Location = new System.Drawing.Point(12, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 449);
            this.tabControl1.TabIndex = 81;
            // 
            // tabEmitente
            // 
            this.tabEmitente.Controls.Add(this.gridMotorista);
            this.tabEmitente.Location = new System.Drawing.Point(4, 22);
            this.tabEmitente.Name = "tabEmitente";
            this.tabEmitente.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmitente.Size = new System.Drawing.Size(790, 423);
            this.tabEmitente.TabIndex = 0;
            this.tabEmitente.Text = "Dados Gerais";
            this.tabEmitente.UseVisualStyleBackColor = true;
            // 
            // gridMotorista
            // 
            this.gridMotorista.Controls.Add(this.txtCpf);
            this.gridMotorista.Controls.Add(this.txtFone2);
            this.gridMotorista.Controls.Add(this.txtFone1);
            this.gridMotorista.Controls.Add(this.groupBox4);
            this.gridMotorista.Controls.Add(this.chkAtivo);
            this.gridMotorista.Controls.Add(this.label16);
            this.gridMotorista.Controls.Add(this.label17);
            this.gridMotorista.Controls.Add(this.groupBox3);
            this.gridMotorista.Controls.Add(this.dtpNascimento);
            this.gridMotorista.Controls.Add(this.txtCodigo);
            this.gridMotorista.Controls.Add(this.label8);
            this.gridMotorista.Controls.Add(this.txtNomeFuncionario);
            this.gridMotorista.Controls.Add(this.label1);
            this.gridMotorista.Controls.Add(this.label14);
            this.gridMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridMotorista.Location = new System.Drawing.Point(6, 6);
            this.gridMotorista.Name = "gridMotorista";
            this.gridMotorista.Size = new System.Drawing.Size(768, 400);
            this.gridMotorista.TabIndex = 20;
            this.gridMotorista.TabStop = false;
            this.gridMotorista.Text = "Informações gerais";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(322, 46);
            this.txtCpf.Mask = "999.999.999-99";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(108, 20);
            this.txtCpf.TabIndex = 1;
            // 
            // txtFone2
            // 
            this.txtFone2.Location = new System.Drawing.Point(531, 47);
            this.txtFone2.Mask = "0000-0000";
            this.txtFone2.Name = "txtFone2";
            this.txtFone2.Size = new System.Drawing.Size(100, 20);
            this.txtFone2.TabIndex = 3;
            // 
            // txtFone1
            // 
            this.txtFone1.Location = new System.Drawing.Point(436, 46);
            this.txtFone1.Mask = "00000-0000";
            this.txtFone1.Name = "txtFone1";
            this.txtFone1.Size = new System.Drawing.Size(89, 20);
            this.txtFone1.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.maskedTextBox2);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.textBox9);
            this.groupBox4.Controls.Add(this.textBox11);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(747, 235);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(25, 126);
            this.groupBox4.TabIndex = 84;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informe os endereços";
            this.groupBox4.Visible = false;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(113, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 20);
            this.button2.TabIndex = 81;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(9, 38);
            this.maskedTextBox2.Mask = "00000-000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(98, 20);
            this.maskedTextBox2.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Cep";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = "Cidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(194, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 75;
            this.label10.Text = "UF";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SP",
            "RJ"});
            this.comboBox1.Location = new System.Drawing.Point(194, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(59, 24);
            this.comboBox1.TabIndex = 74;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(639, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 70;
            this.label11.Text = "Número";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(256, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 70;
            this.label12.Text = "Compl.";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(9, 86);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(179, 20);
            this.textBox6.TabIndex = 67;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(453, 38);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(183, 20);
            this.textBox7.TabIndex = 68;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(259, 86);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(444, 20);
            this.textBox8.TabIndex = 69;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(642, 38);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(61, 20);
            this.textBox9.TabIndex = 68;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(149, 38);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(298, 20);
            this.textBox11.TabIndex = 69;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(146, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "Endereço";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(450, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 65;
            this.label18.Text = "Bairro";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(400, -26);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 13);
            this.label24.TabIndex = 66;
            this.label24.Text = "Logradouro";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(637, 50);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(55, 17);
            this.chkAtivo.TabIndex = 4;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            this.chkAtivo.CheckedChanged += new System.EventHandler(this.chkAtivo_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(528, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 13);
            this.label16.TabIndex = 82;
            this.label16.Text = "Tel. Residencial";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(433, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 80;
            this.label17.Text = "Celular";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvFuncionarios);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(741, 309);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de funcionarios";
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(15, 19);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionarios.Size = new System.Drawing.Size(711, 270);
            this.dgvFuncionarios.TabIndex = 49;
            this.dgvFuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellContentClick);
            this.dgvFuncionarios.Click += new System.EventHandler(this.dgvFuncionarios_Click);
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNascimento.Location = new System.Drawing.Point(631, 342);
            this.dtpNascimento.MinDate = new System.DateTime(2017, 11, 16, 0, 0, 0, 0);
            this.dtpNascimento.MinimumSize = new System.Drawing.Size(20, 20);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(102, 20);
            this.dtpNascimento.TabIndex = 61;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(9, 46);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(47, 20);
            this.txtCodigo.TabIndex = 59;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(6, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Código";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(62, 46);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(254, 20);
            this.txtNomeFuncionario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(319, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "CPF";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label14.Location = new System.Drawing.Point(59, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Nome funcionário";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(816, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Data Nasc.";
            // 
            // btEditar
            // 
            this.btEditar.Enabled = false;
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEditar.Location = new System.Drawing.Point(596, 526);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(103, 27);
            this.btEditar.TabIndex = 89;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Image = ((System.Drawing.Image)(resources.GetObject("btNovo.Image")));
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(371, 526);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(107, 27);
            this.btNovo.TabIndex = 5;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(705, 526);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(105, 27);
            this.btExcluir.TabIndex = 86;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btIncuir
            // 
            this.btIncuir.Image = ((System.Drawing.Image)(resources.GetObject("btIncuir.Image")));
            this.btIncuir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIncuir.Location = new System.Drawing.Point(484, 526);
            this.btIncuir.Name = "btIncuir";
            this.btIncuir.Size = new System.Drawing.Size(106, 27);
            this.btIncuir.TabIndex = 87;
            this.btIncuir.Text = "Incluir";
            this.btIncuir.UseVisualStyleBackColor = true;
            this.btIncuir.Click += new System.EventHandler(this.btIncuir_Click);
            // 
            // tooVeiculo
            // 
            this.tooVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tooVeiculo.Location = new System.Drawing.Point(0, 563);
            this.tooVeiculo.Name = "tooVeiculo";
            this.tooVeiculo.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tooVeiculo.Size = new System.Drawing.Size(818, 22);
            this.tooVeiculo.TabIndex = 85;
            // 
            // frmFuncionario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 585);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btIncuir);
            this.Controls.Add(this.tooVeiculo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label6);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFuncionario2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de funcionários";
            this.Load += new System.EventHandler(this.frmFuncionario2_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFuncionario2_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabEmitente.ResumeLayout(false);
            this.gridMotorista.ResumeLayout(false);
            this.gridMotorista.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEmitente;
        private System.Windows.Forms.GroupBox gridMotorista;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btIncuir;
        private System.Windows.Forms.StatusStrip tooVeiculo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtFone1;
        private System.Windows.Forms.MaskedTextBox txtFone2;
        private System.Windows.Forms.MaskedTextBox txtCpf;
    }
}