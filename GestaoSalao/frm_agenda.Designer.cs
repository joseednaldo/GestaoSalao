namespace GestaoSalao
{
    partial class frmAgenda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            this.tooVeiculo = new System.Windows.Forms.StatusStrip();
            this.tabAgenda = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtvAgendamento = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAtendimentoAvulso = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.lblDia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mnuferramentas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAgendarServico = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemProfissionais = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemCtlVale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemComissao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemServicos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemCrtDebCred = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFinanceiro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemFaturamento = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusistema = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemParametros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemConfigPermissao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemCadastroUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recuperarBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.CRM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolConfirma = new System.Windows.Forms.ToolStripMenuItem();
            this.tabAgenda.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvAgendamento)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.CRM.SuspendLayout();
            this.SuspendLayout();
            // 
            // tooVeiculo
            // 
            this.tooVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tooVeiculo.Location = new System.Drawing.Point(0, 750);
            this.tooVeiculo.Name = "tooVeiculo";
            this.tooVeiculo.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tooVeiculo.Size = new System.Drawing.Size(1325, 22);
            this.tooVeiculo.TabIndex = 57;
            // 
            // tabAgenda
            // 
            this.tabAgenda.Controls.Add(this.groupBox2);
            this.tabAgenda.Controls.Add(this.groupBox1);
            this.tabAgenda.Location = new System.Drawing.Point(4, 22);
            this.tabAgenda.Name = "tabAgenda";
            this.tabAgenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgenda.Size = new System.Drawing.Size(1305, 664);
            this.tabAgenda.TabIndex = 0;
            this.tabAgenda.Text = "Dados do agendamento";
            this.tabAgenda.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtvAgendamento);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(270, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1029, 631);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Disponibilidade de horários";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dtvAgendamento
            // 
            this.dtvAgendamento.AllowUserToAddRows = false;
            this.dtvAgendamento.AllowUserToDeleteRows = false;
            this.dtvAgendamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvAgendamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtvAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvAgendamento.Location = new System.Drawing.Point(6, 29);
            this.dtvAgendamento.Name = "dtvAgendamento";
            this.dtvAgendamento.ReadOnly = true;
            this.dtvAgendamento.Size = new System.Drawing.Size(1013, 596);
            this.dtvAgendamento.TabIndex = 49;
            this.dtvAgendamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvAgendamento_CellClick_1);
            this.dtvAgendamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvAgendamento_CellContentClick);
            this.dtvAgendamento.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtvAgendamento_CellFormatting);
            this.dtvAgendamento.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvAgendamento_CellMouseEnter);
            this.dtvAgendamento.DoubleClick += new System.EventHandler(this.dtvAgendamento_DoubleClick);
            this.dtvAgendamento.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtvAgendamento_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnAtendimentoAvulso);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAgendar);
            this.groupBox1.Controls.Add(this.lblDia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 593);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Disponibilidade de dias";
            // 
            // btnAtendimentoAvulso
            // 
            this.btnAtendimentoAvulso.Image = ((System.Drawing.Image)(resources.GetObject("btnAtendimentoAvulso.Image")));
            this.btnAtendimentoAvulso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtendimentoAvulso.Location = new System.Drawing.Point(12, 351);
            this.btnAtendimentoAvulso.Name = "btnAtendimentoAvulso";
            this.btnAtendimentoAvulso.Size = new System.Drawing.Size(227, 38);
            this.btnAtendimentoAvulso.TabIndex = 82;
            this.btnAtendimentoAvulso.Text = "Atendimento Avulso";
            this.btnAtendimentoAvulso.UseVisualStyleBackColor = true;
            this.btnAtendimentoAvulso.Click += new System.EventHandler(this.btnAtendimentoAvulso_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancelar.Location = new System.Drawing.Point(12, 309);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(227, 36);
            this.btnCancelar.TabIndex = 76;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgendar
            // 
            this.btnAgendar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgendar.Image")));
            this.btnAgendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendar.Location = new System.Drawing.Point(12, 265);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(227, 38);
            this.btnAgendar.TabIndex = 57;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblDia.Location = new System.Drawing.Point(68, 62);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(111, 20);
            this.lblDia.TabIndex = 2;
            this.lblDia.Text = "(07/03/2018)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(79, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sábado";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.White;
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.ForeColor = System.Drawing.Color.White;
            this.monthCalendar1.Location = new System.Drawing.Point(12, 91);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAgenda);
            this.tabControl1.Location = new System.Drawing.Point(0, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1313, 690);
            this.tabControl1.TabIndex = 56;
            // 
            // mnuferramentas
            // 
            this.mnuferramentas.Name = "mnuferramentas";
            this.mnuferramentas.Size = new System.Drawing.Size(84, 20);
            this.mnuferramentas.Text = "&Ferramentas";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAgenda,
            this.mnuCadastro,
            this.mnuFinanceiro,
            this.mnuRelatorios,
            this.mnuferramentas,
            this.mnusistema,
            this.mnuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1325, 24);
            this.menuStrip1.TabIndex = 58;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuAgenda
            // 
            this.mnuAgenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAgendarServico,
            this.sairToolStripMenuItem});
            this.mnuAgenda.Name = "mnuAgenda";
            this.mnuAgenda.Size = new System.Drawing.Size(60, 20);
            this.mnuAgenda.Text = "&Agenda";
            // 
            // mnuItemAgendarServico
            // 
            this.mnuItemAgendarServico.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemAgendarServico.Image")));
            this.mnuItemAgendarServico.Name = "mnuItemAgendarServico";
            this.mnuItemAgendarServico.Size = new System.Drawing.Size(160, 22);
            this.mnuItemAgendarServico.Text = "Agendar Serviço";
            this.mnuItemAgendarServico.Click += new System.EventHandler(this.emitirNovoCTEToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // mnuCadastro
            // 
            this.mnuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemProfissionais,
            this.mnuItemClientes,
            this.mnuItemServicos,
            this.mnuItemProdutos,
            this.mnuItemCrtDebCred});
            this.mnuCadastro.Name = "mnuCadastro";
            this.mnuCadastro.Size = new System.Drawing.Size(71, 20);
            this.mnuCadastro.Text = "&Cadastros";
            this.mnuCadastro.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // mnuItemProfissionais
            // 
            this.mnuItemProfissionais.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemCtlVale,
            this.mnuItemComissao,
            this.mnuItemConsulta});
            this.mnuItemProfissionais.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemProfissionais.Image")));
            this.mnuItemProfissionais.Name = "mnuItemProfissionais";
            this.mnuItemProfissionais.Size = new System.Drawing.Size(204, 22);
            this.mnuItemProfissionais.Text = "&Profissionais";
            this.mnuItemProfissionais.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // mnuItemCtlVale
            // 
            this.mnuItemCtlVale.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemCtlVale.Image")));
            this.mnuItemCtlVale.Name = "mnuItemCtlVale";
            this.mnuItemCtlVale.Size = new System.Drawing.Size(161, 22);
            this.mnuItemCtlVale.Text = "Controle de Vale";
            this.mnuItemCtlVale.Click += new System.EventHandler(this.emitirValeToolStripMenuItem_Click);
            // 
            // mnuItemComissao
            // 
            this.mnuItemComissao.Name = "mnuItemComissao";
            this.mnuItemComissao.Size = new System.Drawing.Size(161, 22);
            this.mnuItemComissao.Text = "Comissões";
            // 
            // mnuItemConsulta
            // 
            this.mnuItemConsulta.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemConsulta.Image")));
            this.mnuItemConsulta.Name = "mnuItemConsulta";
            this.mnuItemConsulta.Size = new System.Drawing.Size(161, 22);
            this.mnuItemConsulta.Text = "Consulta";
            // 
            // mnuItemClientes
            // 
            this.mnuItemClientes.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemClientes.Image")));
            this.mnuItemClientes.Name = "mnuItemClientes";
            this.mnuItemClientes.Size = new System.Drawing.Size(204, 22);
            this.mnuItemClientes.Text = "Clientes";
            // 
            // mnuItemServicos
            // 
            this.mnuItemServicos.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemServicos.Image")));
            this.mnuItemServicos.Name = "mnuItemServicos";
            this.mnuItemServicos.Size = new System.Drawing.Size(204, 22);
            this.mnuItemServicos.Text = "&Serviços";
            this.mnuItemServicos.Click += new System.EventHandler(this.serviçoToolStripMenuItem_Click);
            // 
            // mnuItemProdutos
            // 
            this.mnuItemProdutos.Image = global::GestaoSalao.Properties.Resources.produtos;
            this.mnuItemProdutos.Name = "mnuItemProdutos";
            this.mnuItemProdutos.Size = new System.Drawing.Size(204, 22);
            this.mnuItemProdutos.Text = "Produtos";
            this.mnuItemProdutos.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // mnuItemCrtDebCred
            // 
            this.mnuItemCrtDebCred.Image = global::GestaoSalao.Properties.Resources.cartao3;
            this.mnuItemCrtDebCred.Name = "mnuItemCrtDebCred";
            this.mnuItemCrtDebCred.Size = new System.Drawing.Size(204, 22);
            this.mnuItemCrtDebCred.Text = "Cartões (Dédito/Crédito)";
            this.mnuItemCrtDebCred.Click += new System.EventHandler(this.cartõesDéditoCréditoToolStripMenuItem_Click);
            // 
            // mnuFinanceiro
            // 
            this.mnuFinanceiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemDespesas});
            this.mnuFinanceiro.Name = "mnuFinanceiro";
            this.mnuFinanceiro.Size = new System.Drawing.Size(74, 20);
            this.mnuFinanceiro.Text = "Financeiro";
            // 
            // mnuItemDespesas
            // 
            this.mnuItemDespesas.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemDespesas.Image")));
            this.mnuItemDespesas.Name = "mnuItemDespesas";
            this.mnuItemDespesas.Size = new System.Drawing.Size(187, 22);
            this.mnuItemDespesas.Text = "Controle de Despesas";
            this.mnuItemDespesas.Click += new System.EventHandler(this.contasAPagarToolStripMenuItem_Click);
            // 
            // mnuRelatorios
            // 
            this.mnuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemFaturamento,
            this.relatórioToolStripMenuItem});
            this.mnuRelatorios.Name = "mnuRelatorios";
            this.mnuRelatorios.Size = new System.Drawing.Size(125, 20);
            this.mnuRelatorios.Text = "Relatorios Gerencias";
            // 
            // mnuItemFaturamento
            // 
            this.mnuItemFaturamento.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemFaturamento.Image")));
            this.mnuItemFaturamento.Name = "mnuItemFaturamento";
            this.mnuItemFaturamento.Size = new System.Drawing.Size(203, 22);
            this.mnuItemFaturamento.Text = "Faturamento (Pesquisar)";
            this.mnuItemFaturamento.Click += new System.EventHandler(this.faturamentoToolStripMenuItem_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relatórioToolStripMenuItem.Image")));
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            this.relatórioToolStripMenuItem.Click += new System.EventHandler(this.relatórioToolStripMenuItem_Click);
            // 
            // mnusistema
            // 
            this.mnusistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemParametros,
            this.mnuItemConfigPermissao,
            this.mnuItemCadastroUsuarios,
            this.mnuBackup});
            this.mnusistema.Name = "mnusistema";
            this.mnusistema.Size = new System.Drawing.Size(60, 20);
            this.mnusistema.Text = "&Sistema";
            // 
            // mnuItemParametros
            // 
            this.mnuItemParametros.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemParametros.Image")));
            this.mnuItemParametros.Name = "mnuItemParametros";
            this.mnuItemParametros.Size = new System.Drawing.Size(188, 22);
            this.mnuItemParametros.Text = "&Parametros";
            // 
            // mnuItemConfigPermissao
            // 
            this.mnuItemConfigPermissao.Name = "mnuItemConfigPermissao";
            this.mnuItemConfigPermissao.Size = new System.Drawing.Size(188, 22);
            this.mnuItemConfigPermissao.Text = "Configurar permissão";
            // 
            // mnuItemCadastroUsuarios
            // 
            this.mnuItemCadastroUsuarios.Name = "mnuItemCadastroUsuarios";
            this.mnuItemCadastroUsuarios.Size = new System.Drawing.Size(188, 22);
            this.mnuItemCadastroUsuarios.Text = "Cadastrar Usuários";
            this.mnuItemCadastroUsuarios.Click += new System.EventHandler(this.cadastrarUsuáriosToolStripMenuItem_Click);
            // 
            // mnuBackup
            // 
            this.mnuBackup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarToolStripMenuItem,
            this.recuperarBackupToolStripMenuItem});
            this.mnuBackup.Name = "mnuBackup";
            this.mnuBackup.Size = new System.Drawing.Size(188, 22);
            this.mnuBackup.Text = "&Backup";
            // 
            // gerarToolStripMenuItem
            // 
            this.gerarToolStripMenuItem.Name = "gerarToolStripMenuItem";
            this.gerarToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.gerarToolStripMenuItem.Text = "&Gerar backup";
            // 
            // recuperarBackupToolStripMenuItem
            // 
            this.recuperarBackupToolStripMenuItem.Name = "recuperarBackupToolStripMenuItem";
            this.recuperarBackupToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.recuperarBackupToolStripMenuItem.Text = "&Recuperar  dados do backup";
            // 
            // mnuSair
            // 
            this.mnuSair.Image = ((System.Drawing.Image)(resources.GetObject("mnuSair.Image")));
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(54, 20);
            this.mnuSair.Text = "&Sair";
            this.mnuSair.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // CRM
            // 
            this.CRM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCancelar,
            this.toolConfirma});
            this.CRM.Name = "CRM";
            this.CRM.Size = new System.Drawing.Size(125, 48);
            // 
            // toolCancelar
            // 
            this.toolCancelar.Name = "toolCancelar";
            this.toolCancelar.Size = new System.Drawing.Size(124, 22);
            this.toolCancelar.Text = "Cancelar";
            this.toolCancelar.Click += new System.EventHandler(this.toolCancelar_Click);
            // 
            // toolConfirma
            // 
            this.toolConfirma.Name = "toolConfirma";
            this.toolConfirma.Size = new System.Drawing.Size(124, 22);
            this.toolConfirma.Text = "Confirma";
            this.toolConfirma.Click += new System.EventHandler(this.toolConfirma_Click);
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1325, 772);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tooVeiculo);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de Atendimento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAgenda_KeyDown);
            this.tabAgenda.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvAgendamento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.CRM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip tooVeiculo;
        private System.Windows.Forms.TabPage tabAgenda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtvAgendamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnAtendimentoAvulso;
        private System.Windows.Forms.ToolStripMenuItem mnuferramentas;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuAgenda;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAgendarServico;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastro;
        private System.Windows.Forms.ToolStripMenuItem mnuItemProfissionais;
        private System.Windows.Forms.ToolStripMenuItem mnuItemConsulta;
        private System.Windows.Forms.ToolStripMenuItem mnuItemServicos;
        private System.Windows.Forms.ToolStripMenuItem mnuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem mnuItemFaturamento;
        private System.Windows.Forms.ToolStripMenuItem mnuFinanceiro;
        private System.Windows.Forms.ToolStripMenuItem mnuItemDespesas;
        private System.Windows.Forms.ToolStripMenuItem mnuItemClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuItemProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnuItemCtlVale;
        private System.Windows.Forms.ToolStripMenuItem mnuItemComissao;
        private System.Windows.Forms.ContextMenuStrip CRM;
        private System.Windows.Forms.ToolStripMenuItem toolCancelar;
        private System.Windows.Forms.ToolStripMenuItem toolConfirma;
        private System.Windows.Forms.ToolStripMenuItem mnuItemCrtDebCred;
        private System.Windows.Forms.ToolStripMenuItem mnusistema;
        private System.Windows.Forms.ToolStripMenuItem mnuItemParametros;
        private System.Windows.Forms.ToolStripMenuItem mnuItemConfigPermissao;
        private System.Windows.Forms.ToolStripMenuItem mnuItemCadastroUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuBackup;
        private System.Windows.Forms.ToolStripMenuItem gerarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recuperarBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
    }
}

