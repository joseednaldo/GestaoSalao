using System;
using System.Windows.Forms;
using DTO_GestaoSalao;
using dll_BS_GestaoSalao;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using Microsoft.VisualBasic;
using dll_Uteis_GestaoSalao;
using GestaoSalao.Relatorio;

namespace GestaoSalao
{
    public partial class frmAgenda : MaterialForm
    {
       public int intQtdFuncionario;
        public string strFuncionario;
        public string strHorario;
        public int qtdF;
        DateTime data;
        ToolTip tip;


        public frmAgenda()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            ValidaPermissaoUsuario(Session.Instance.UserID);
            CarregaGrid();
            

        }
   
        private void button2_Click(object sender, EventArgs e)
        {
            AgendamentoSelecionado(intQtdFuncionario);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dll_BS_GestaoSalao.ServicoBLL bll = new dll_BS_GestaoSalao.ServicoBLL();
            CarregarMostraServico(bll.ConsultaServico(7));
        }
        private void CarregarMostraServico(List<DTO_GestaoSalao.Servico> pServico)
        {
            pServico.ForEach(i => Console.WriteLine(i));
        }
        private void configuraDataGridViewFuncionarios(int qtdColGrid, List<Funcionario> List)

        {

            int qtdLinhaAgenda = List.Count;

            //Recupera funcionarios cadastrados
            var GrupoFuncionarios = List;
            var RelacaoDeFuncionarios = (from f in GrupoFuncionarios
                                         where f.nomeFuncionario != "" 
                                         && f.nomeFuncionario != "Atendente padrão" 
                                         && f.ativo == true
                                         group f by f.nomeFuncionario
                                         );

            intQtdFuncionario = RelacaoDeFuncionarios.Count();

            foreach (var agenda in RelacaoDeFuncionarios)
            {
                //dtvAgendamento.Columns.Add(agenda.Key, agenda.Key.ToUpper());
                dtvAgendamento.Columns.Add(agenda.Key, agenda.Key.ToUpper());
               // dtvAgendamento.Columns.GetColumnsWidth(444);
            }


        }
        private void configuraHorarioHorario(List<Horario> List)

        {

            dtvAgendamento.AutoGenerateColumns = false;

            int qtdColGrid = 1;
            int qtdLinhaAgenda = List.Count;


            dtvAgendamento.Columns.Add("Horario", "Horário");
            dtvAgendamento.Columns[0].HeaderText = "HORÁRIO";
            dtvAgendamento.Columns[0].DataGridView.Enabled = false;
            dtvAgendamento.Columns[0].DefaultCellStyle.BackColor = Color.LightBlue;
            dtvAgendamento.Columns[0].DefaultCellStyle.ForeColor = Color.Red;
            dtvAgendamento.Columns[0].Width = 10;

            //Retirando a duplicidade  dos horarios
            var Agenda = List;
            var Horarios = from a in Agenda
                           group a.horarioHORARIO by a.horarioHORARIO;

            int QtdHorarios = Convert.ToInt16(Horarios.Count());



            foreach (var horario in Horarios)
            {
                dtvAgendamento.Rows.Add(horario.Key);
            }

            configuraDataGridViewFuncionarios(qtdColGrid, ListaFuncionario());


        }
        private void MontaAgenda(List<Agendamento> List)

        {

           

            //Cria as coluanas conforme a quantidade e nome dos funcionarios
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].nomeCLIENTE != "")
                {
                    if (List[i].canceladoAGENDAMENTO == 0)
                    {

                        if (List[i].nomeclienteAGENDAMENTO.ToUpper() !="")
                        {
                            dtvAgendamento.Rows[List[i].linhaAGENDAMENTO].Cells[List[i].colunaAGENDAMENTO].Value = List[i].nomeclienteAGENDAMENTO.ToUpper() + " : " + List[i].descricaoSERVICO;  //"CLIENTE"; //List[i].nomeCLIENTE.ToUpper();
                        }
                        else
                        {
                            dtvAgendamento.Rows[List[i].linhaAGENDAMENTO].Cells[List[i].colunaAGENDAMENTO].Value = List[i].nomeclienteAGENDAMENTO.ToUpper();
                        }
                        
                        dtvAgendamento.Rows[List[i].linhaAGENDAMENTO].Cells[List[i].colunaAGENDAMENTO].Style.BackColor = Color.Yellow;

                    }
                    else
                    {

                        dtvAgendamento.Rows[List[i].linhaAGENDAMENTO].Cells[List[i].colunaAGENDAMENTO].Value = "";
                        dtvAgendamento.Rows[List[i].linhaAGENDAMENTO].Cells[List[i].colunaAGENDAMENTO].Style.BackColor = Color.White;
                    }

                }


            }
            dtvAgendamento.AutoResizeColumns();
        }
        private List<Agendamento> ListaParametros()
        {
            dll_BS_GestaoSalao.AgendamentoBLL bll = new dll_BS_GestaoSalao.AgendamentoBLL();
            return bll.RecuperaParametros();

        }
        private List<Agendamento> ListaAgendamento(DateTime data)
        {
            dll_BS_GestaoSalao.AgendamentoBLL bll = new dll_BS_GestaoSalao.AgendamentoBLL();
            return bll.RecuperaAgendamento(data);

        }
        private List<Horario> ListaHorario()
        {
            dll_BS_GestaoSalao.AgendamentoBLL bll = new dll_BS_GestaoSalao.AgendamentoBLL();
            return bll.RecuperaHorario();

        }
        private void CarregarParametro(List<Agendamento> List)
        {
            intQtdFuncionario = Convert.ToInt16(List[0].valorPARAMETRO);

        }
     
        private void dtvAgendamento_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            strFuncionario = dtvAgendamento.Columns[e.ColumnIndex].HeaderText;
           // strHorario = dtvAgendamento.Rows[e.RowIndex].Cells[0].Value.ToString() ;

        }
        private void AgendamentoSelecionado(int qtdColunasFuncionarios)
        {


            List<String> lista = new List<String>();

            if (dtvAgendamento.RowCount > 0)
            {
                for (int i = 0; i < dtvAgendamento.RowCount-1; i++)
                {

                    for (int j = 0;     j <= qtdColunasFuncionarios; j++)
                    {
                        if (dtvAgendamento.Rows[i].Cells[j].Selected)
                        {
                            lista.Add(dtvAgendamento.Rows[i].Cells[0].Value.ToString() + "|" + i + "|" + j);

                        }
                    }

                }
            }
  
            frmReserva reserva = new frmReserva(strFuncionario, lista,lblDia.Text);
            reserva.ShowDialog();
            CarregaGrid();
        }
        private void CancelarSelecionado(int qtdColunasFuncionarios)
        {


            List<String> lista = new List<String>();

            if (dtvAgendamento.RowCount > 0)
            {
                for (int i = 0; i < dtvAgendamento.RowCount - 1; i++)
                {

                    for (int j = 0; j <= qtdColunasFuncionarios; j++)
                    {
                        if (dtvAgendamento.Rows[i].Cells[j].Selected)
                        {
                            lista.Add(dtvAgendamento.Rows[i].Cells[0].Value.ToString() + "|" + i + "|" + j);

                        }
                    }

                }
            }

           var booMotivo= Cancelar(strFuncionario,lista, lblDia.Text);
            if (booMotivo == true)
            {
                CarregaGrid();
                strFuncionario = null;
            }
            else
            {

                strFuncionario = null;
                MessageBox.Show("Selecione o dia de cancelamneto !!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
        private bool Cancelar(string funcionario, List<String> Lista, string dataagenda)
        {

            if (funcionario==null || funcionario=="")
            {
                return false;
            }

            DateTime diaagendado = Convert.ToDateTime(dataagenda);
            string funcioanario = funcionario.ToString().Substring(0, 3);
            int codigo = Convert.ToInt32((funcioanario.Replace("-", "")));
            for (int i = 0; i < Lista.Count; i++)
            {
                String[] substrings = Lista[i].Split('|');

                int linhaAGENDAMENTO = Convert.ToInt32(substrings[1]);
                int colunaAGENDAMENTO = Convert.ToInt32(substrings[2]);

                AgendamentoBLL bll = new AgendamentoBLL();
                bll.Cancelar(codigo, linhaAGENDAMENTO, colunaAGENDAMENTO, diaagendado);

                // agenda.codigoSERVICO = codigo;
                bll = null;
            }

            return true;


        }
        private void dtvAgendamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //MessageBox.Show("oi");
        }
        private void tabAgenda_Click(object sender, EventArgs e)
        {

        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblDia.Text =monthCalendar1.SelectionRange.Start.ToString().Substring(0,10);
            switch (monthCalendar1.SelectionRange.Start.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    label1.Text = "Domingo";
                    break;
                case DayOfWeek.Monday:
                    label1.Text = "Segunda";
                    break;
                case DayOfWeek.Tuesday:
                    label1.Text = "Terça";
                    break;
                case DayOfWeek.Wednesday:
                    label1.Text = "Quarta";
                    break;
                case DayOfWeek.Thursday:
                    label1.Text = "Quinta";
                    break;
                case DayOfWeek.Friday:
                    label1.Text = "Sexta";
                    break;
                case DayOfWeek.Saturday:
                    label1.Text = "Sábado";
                    break;
                default:
                    break;
            }



            //monthCalendar1.SelectionRange.ToString()
            CarregaGrid();

        }
        private List<Funcionario> ListaFuncionario()
        {
            dll_BS_GestaoSalao.FuncionarioBLL bll = new dll_BS_GestaoSalao.FuncionarioBLL();
            return bll.ListaFuncionario();
        }
        private void CarregaGrid()
        {

            strFuncionario = "";
            dtvAgendamento.DataSource = null; //Remover a datasource
            dtvAgendamento.Columns.Clear(); //Remover as colunas
            dtvAgendamento.Rows.Clear(); //Remover as linhas
            dtvAgendamento.Refresh(); //Para a grid se actualizar
     
            lblDia.Text = monthCalendar1.SelectionStart.ToString().Substring(0, 10);
            data = Convert.ToDateTime(lblDia.Text);
          
            configuraHorarioHorario(ListaHorario());
            MontaAgenda(ListaAgendamento(data));
            dtvAgendamento.Enabled = true;

        }
        private void button5_Click(object sender, EventArgs e)
        {
           
        }
        private void dtvAgendamento_DoubleClick(object sender, EventArgs e)
        {
           // MessageBox.Show("oi");
        }

        private void frmAgenda_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyValue.Equals(27)) //ESC
            //{
            //    this.Close();
            //}
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmCadastraServico serv = new frmCadastraServico();
            serv.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmFuncionario2 func = new frmFuncionario2();
            func.ShowDialog();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            frmCadastraServico serv = new frmCadastraServico();
            serv.ShowDialog();
        }

   
        private void button1_Click_1(object sender, EventArgs e)
        {

            //bool valid = ValidaSenha();

            //if (valid)
            //{

                frmListaPedidos pedidos = new frmListaPedidos();
                pedidos.ShowDialog();

           // }

        }


        public bool  ValidaSenha()
        {

            /* usando a função VB.Net para exibir um prompt para o usuário informar a senha */

            string Prompt = "A senha é obrigatória.";

            string Titulo = "Salão de beleza";

            string Resultado = Microsoft.VisualBasic.Interaction.InputBox(Prompt, Titulo, "*", 150, 150);


            /* defina senha apenas para testar. */

            string password = "VinhoNovo";


            /* verifica se o resultado é uma string vazia o que indica que foi cancelado. */

            if (Resultado != "")

            {

                Resultado = Resultado.TrimStart();

                /* Verifica se a senha confere. */

                if (Resultado != password)

                {

                    return false;

                }

                else

                {

                    return true;

                }

            }
            else
            {
                return false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmFuncionario2 func = new frmFuncionario2();
            func.ShowDialog();
        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastraServico serv = new frmCadastraServico();
            serv.ShowDialog();
        }

        private void faturamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaPedidos pedidos = new frmListaPedidos();
            pedidos.ShowDialog();

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmControleDespesa   despesas = new frmControleDespesa ();
            despesas.ShowDialog();
        }

        private void emitirValeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmControleVale valeFuncionario = new frmControleVale();
            valeFuncionario.ShowDialog();
        }

        private void dtvAgendamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           


        }

        private void dtvAgendamento_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void dtvAgendamento_MouseDown(object sender, MouseEventArgs e)
        {
            // verifica se o item esta em edição ou se é um item novo
            if (1 == 1 || 0 == 0)
            {
                // verifica se é com o botão equerdo
                if (e.Button == MouseButtons.Right)
                {
                    // exibe o ContesteMenuStrip na posição do mouse dentro do gridcontrol
                    CRM.Show(dtvAgendamento.PointToScreen(new Point(e.X, e.Y)));
                }
            }
        }

        private void emitirNovoCTEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolEditar_Click(object sender, EventArgs e)
        {

        }

        private void toolConfirma_Click(object sender, EventArgs e)
        {

            ConfirmaAgendamento(intQtdFuncionario);
        }

        private void toolCancelar_Click(object sender, EventArgs e)
        {
            CancelarSelecionado(intQtdFuncionario);
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cartõesDéditoCréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastraCartao CadastraFormaPgto = new frmCadastraCartao();
            CadastraFormaPgto.ShowDialog();
        }
        private void ConfirmaAgendamento(int qtdColunasFuncionarios)
        {

            List<String> lista = new List<String>();

            //Recuperando o a posição do agendamento
            if (dtvAgendamento.RowCount > 0)
            {
                for (int i = 0; i < dtvAgendamento.RowCount - 1; i++)
                {
                    for (int j = 0; j <= qtdColunasFuncionarios; j++)
                    {
                        if (dtvAgendamento.Rows[i].Cells[j].Selected)
                        { lista.Add(dtvAgendamento.Rows[i].Cells[0].Value.ToString() + "|" + i + "|" + j);}
                    }
                }
            }

           

            var booMotivo = ConfirmaAgendamento(strFuncionario,lista,lblDia.Text);

            if (booMotivo == true)
            {
                CarregaGrid();
                strFuncionario = null;

                MessageBox.Show("Faturado com sucesso !!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                strFuncionario = null;
                MessageBox.Show("Selecione o agendamento para confirmação !!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private bool ConfirmaAgendamento(string funcionario, List<String> Lista, string dataagenda)
        {

            if (funcionario == null || funcionario == "")
            {
                return false;
            }

            DateTime diaagendado = Convert.ToDateTime(dataagenda);
            string funcioanario = funcionario.ToString().Substring(0, 3);
            int codigo = Convert.ToInt32((funcioanario.Replace("-", "")));


            // Tela de forma de pgto
            frmPagto frmPagto = new frmPagto();
            frmPagto.ShowDialog();

            // Verificar se foi cancelado em tela de ptgo
            int cancelado = frmPagto.Canceldo;

            if (cancelado == 1)
            {
                return false;
            }


            //Retorna a forma de pgto
            Enum TipoPgto = frmPagto.RetornaTipoPagto();

            var tipoPagto = frmPagto.RetornaTipoPagto().ToString() == "DINHEIRO" ? 0 : 1;


            if (TipoPgto.ToString() == "" || TipoPgto.ToString() == null)
            {
                MessageBox.Show("Por favor escolha forma de pagamento !!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            for (int i = 0; i < Lista.Count; i++)
            {
                String[] substrings = Lista[i].Split('|');

                int linhaAGENDAMENTO = Convert.ToInt32(substrings[1]);
                int colunaAGENDAMENTO = Convert.ToInt32(substrings[2]);

                AgendamentoBLL bll = new AgendamentoBLL();

                // ATENÇÃO - RECUPERAR A FORMA DE PGTO EM NUMERO PARA COLOCAR ABAIXO NA FUNÇÃO.
                bll.ConfirmaAgendamento(codigo, linhaAGENDAMENTO, colunaAGENDAMENTO, diaagendado, tipoPagto);

                bll = null;
            }

            return true;

                
        }

        private void cadastrarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario usuario = new frmCadastroUsuario();
            usuario.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        public void ValidaPermissaoUsuario(int usuario)
        {
            try
            {


                // 

                this.Cursor = Cursors.WaitCursor;

                dll_BS_GestaoSalao.PermissaoUsuarioBLL permissao = new dll_BS_GestaoSalao.PermissaoUsuarioBLL();
                var listaPermissao = permissao.RecuperaPermissao(usuario);

                //Lista apenas permissao 0= nao tem acesso.
                var ListaSemPermissao = listaPermissao.Where(l => l.statusACESSOUSUARIO == 0).ToList();

                foreach (var ItemPermissao in ListaSemPermissao)
                {
                    switch (ItemPermissao.Modulo.nomeMODULO.ToUpper())
                    {
                        case "MNUCADASTRO":  //mnuCadastro
                            if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals("MNUITEMSERVICOS"))//mnuItemServicos
                            { mnuItemServicos.Enabled = false; }
                            if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals("MNUITEMCLIENTES"))//mnuItemClientes
                            { mnuItemClientes.Enabled = false; }
                            if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals("MNUITEMPRODUTOS"))//MNUITEMPRODUTOS
                            { mnuItemProdutos.Enabled = false; }
                            if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals("MNUITEMCRTDEBCRED"))//mnuItemCrtDebCred
                            { mnuItemCrtDebCred.Enabled = false; }
                            if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals("MNUITEMPROFISSIONAIS"))//mnuItemProfissionais
                            { mnuItemCrtDebCred.Enabled = false; }
                            if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals("MNUITEMCTLVALE"))//mnuItemCtlVale
                            { mnuItemCtlVale.Enabled = false; }
                            if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals("MNUITEMCOMISSAO"))//MNUITEMCOMISSAO
                            { mnuItemComissao.Enabled = false; }
                            if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals("MNUITEMCONSULTA"))//MNUITEMCOMISSAO
                            { mnuItemConsulta.Enabled = false; }

                            if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals("MNUITEMPROFISSIONAIS"))//mnuItemProfissionais
                            { mnuItemProfissionais.Enabled = false; }

                            break;

                        //case "MNUFERRAMENTAS": 
                        //    if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals("MNUITEMCADASTROUSUARIOS"))//"mnuItemCadastroUsuarios"
                        //    { mnuItemCadastroUsuarios.Enabled = false; }
                        //    break;

                        case "MNUFINANCEIRO":
                            if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals("MNUITEMDESPESAS"))
                            { mnuItemDespesas.Enabled = false; }
                            break;

                        case "MNURELATORIOS"://mnuRelatorios//mnuItemFaturamento
                            if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals("MNUITEMFATURAMENTO"))  
                            {
                                mnuItemFaturamento.Enabled = false;
                            }

                            if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals("RELATÓRIOTOOLSTRIPMENUITEM")) 
                            {
                                relatórioToolStripMenuItem.Enabled = false;
                            }


                            break;

                        case "MenuLateral":
                            if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals(""))
                            { mnuItemCadastroUsuarios.Enabled = false; }
                            break;

                        case "MNUAGENDA":
                            if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals("MNUITEMAGENDARSERVICO"))
                            { mnuItemAgendarServico.Enabled = false; }
                            break;

                        case "MENULATERAL":

                            if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals("FRMATENDIMENTOAVULSO"))
                            {
                                btnAtendimentoAvulso.Visible = false;
                               

                            }
                            if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals("BTNAGENDAR"))
                            {
                                btnAgendar.Visible = false;

                            }
                            if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals("BTNCANCELAR"))
                            {
                                btnCancelar.Visible = false;

                            }
                            break;

                        case "MNUSISTEMA":
                            if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals("MNUITEMCADASTROUSUARIOS"))//"mnuItemCadastroUsuarios"
                            { mnuItemCadastroUsuarios.Enabled = false; }
                            if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals("MNUITEMPARAMETROS"))//"mnuItemParametros"
                            { mnuItemCadastroUsuarios.Enabled = false; }

                            if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals("MNUBACKUP"))//"mnuItemConfigPermissao"
                            { mnuBackup.Enabled = false; }

                            if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals("MNUITEMCONFIGPERMISSAO"))//"mnuItemConfigPermissao"
                            { mnuItemConfigPermissao.Enabled = false; }


                            if (ItemPermissao.Componente.nomeCOMPONENTE.ToUpper().Equals("MNUITEMPARAMETROS"))//"mnuItemParametros"
                            { mnuItemParametros.Enabled = false; }

                            break;

                        default:
                            break;
                    }
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Ocorreu um erro contate o administrador!");
            }
        }

        private void btnAtendimentoAvulso_Click(object sender, EventArgs e)
        {
            frmAtendimentoAvulso atendAvulso = new frmAtendimentoAvulso();
            atendAvulso.ShowDialog();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarSelecionado(intQtdFuncionario);
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            try
            {

                if (strFuncionario == null || strFuncionario == "")
                {
                    MessageBox.Show("Selecione o dia na agenda !!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                AgendamentoSelecionado(intQtdFuncionario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DesabilitaBotoes()
        {
            btnAgendar.Visible = false;
            btnCancelar.Visible = false;
            btnAtendimentoAvulso.Visible = false;
        }

        private void  HabilitarBotoes()
        {
            btnAgendar.Visible = false;
            btnCancelar.Visible = false;
            btnAtendimentoAvulso.Visible = false;
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorio faturamento = new frmRelatorio();
            faturamento.ShowDialog();
        }
    }

}