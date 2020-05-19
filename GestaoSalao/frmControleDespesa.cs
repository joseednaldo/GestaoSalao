using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using DTO_GestaoSalao;
using dll_BS_GestaoSalao;

namespace GestaoSalao
{
    public partial class frmControleDespesa : MaterialForm
    {
        public frmControleDespesa()
        {
            InitializeComponent();
        }

        private void frmControleDespesa_Load(object sender, EventArgs e)
        {
            CarregarTipoDespesa(ListaTipoDespesa());
            cbo_tipo_despesa.SelectedValue = "";
            CarregarFuncionario(ListaFuncionario());

        }
        private List<TipoDespesa> ListaTipoDespesa()
        {
            dll_BS_GestaoSalao.TipoDespesaBLL bll = new dll_BS_GestaoSalao.TipoDespesaBLL();
            return bll.ListaTipoDespesa();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            frmDespesas despesas = new frmDespesas();
            despesas.TelaAcao((int)dll_Uteis_GestaoSalao.Uteis.AcaoTela.Incluir);
            despesas.ShowDialog();
        }

        private void frmControleDespesa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            CarregarDespesas();
        }

        private void CarregarTipoDespesa(List<TipoDespesa> List)
        {

            cbo_tipo_despesa.DataSource = List;
            cbo_tipo_despesa.DisplayMember = "descricaoTIPODESPESA";
            cbo_tipo_despesa.ValueMember = "codigoTIPODESPESA";
 
        }

        private void CarregarDespesas()
        {

            var dataPesquisaInicio = dtpData.Value.ToString();
            var dataPesquisaFim = dtpDataFim.Value.ToString();
            int situacaoDespesa = 0;
            int tipoDespesa = 0;


            //Verificando o status da despesa
            if (cbo_SituacaoDespesa.Text == "(TODOS)"){
                situacaoDespesa = 0;
            }else if (cbo_SituacaoDespesa.Text == "Em aberto"){
                situacaoDespesa = 1;
            }
            else if (cbo_SituacaoDespesa.Text == "Quitada")
            {
                situacaoDespesa = 2;
            }

            if (cbo_tipo_despesa.Text == "(TODOS)")
            {
                 tipoDespesa = 0;

            }else
            {
                tipoDespesa = Convert.ToInt32(cbo_tipo_despesa.SelectedValue);
            }
                // var atendente = Convert.ToInt32(cbo_Profissional.SelectedValue);



            dll_BS_GestaoSalao.DespesasBLL bll = new dll_BS_GestaoSalao.DespesasBLL();
            DtDespesa(bll.ListaDespesa(Convert.ToDateTime(dataPesquisaInicio), Convert.ToDateTime(dataPesquisaFim), situacaoDespesa, tipoDespesa));

        }

        private void DtDespesa(DataTable dtDespsa)
        {

            gridLista.DataSource = null; //Remover a datasource
            gridLista.Columns.Clear(); //Remover as colunas
            gridLista.Rows.Clear(); //Remover as linhas
            gridLista.Refresh(); //Para a grid se actualizar

            configuraDataDespesa();
            gridLista.DataSource = dtDespsa;
            //txtTotalGeral.Text = "";
            //txtTotalGeral.Text = ValorTotal().ToString("c");

         Somar(dtDespsa);

            
        }

        private void configuraDataDespesa()
        {

            gridLista.AutoGenerateColumns = false;
            gridLista.ColumnCount = 9;

            gridLista.Columns[0].HeaderText = "Código";
            gridLista.Columns[1].HeaderText = "Descrição";
            gridLista.Columns[2].HeaderText = "Despesa";
            gridLista.Columns[3].HeaderText = "Valor";
            gridLista.Columns[4].HeaderText = "Vencimento";
            gridLista.Columns[5].HeaderText = "Situação";

            gridLista.Columns[6].HeaderText = "Documento";
            gridLista.Columns[7].HeaderText = "Funcionário";
            gridLista.Columns[8].HeaderText = "Observação";

            //Reverenciando as colunas do grid com as colunas vinda da tabela
            gridLista.Columns[0].DataPropertyName = "codigoDESPESA";
            gridLista.Columns[1].DataPropertyName = "descricaoDESPESA";
            gridLista.Columns[2].DataPropertyName = "descricaoTIPODESPESA";
            gridLista.Columns[3].DataPropertyName = "valorDESPESA";
            gridLista.Columns[4].DataPropertyName = "dataDESPESA";
            gridLista.Columns[5].DataPropertyName = "situacao";
            gridLista.Columns[6].DataPropertyName = "documentoDESPESA";
            gridLista.Columns[7].DataPropertyName = "nomeFUNCIONARIO";
            gridLista.Columns[8].DataPropertyName = "observacaoDESPESA";

            //visible 
            // gridLista.Columns[1].Visible = false;

            //Redimenciona cada coluna
            gridLista.Columns[0].Width = 50;
            gridLista.Columns[1].Width = 250;
            gridLista.Columns[2].Width = 250;
            gridLista.Columns[3].Width = 80;
            gridLista.Columns[4].Width = 100;
            gridLista.Columns[5].Width = 100;
            gridLista.Columns[6].Width = 150;
            gridLista.Columns[7].Width = 200;
            gridLista.Columns[8].Width = 350;

            ////Trata o campo valor
            gridLista.Columns[3].DefaultCellStyle.Format = "C2";

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

            if (gridLista.CurrentRow.Cells[5].Value.ToString()=="Quitada")
                {
                MessageBox.Show("Despesa quitada não pode ser excluida, por favor efetue  o extorno !!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return;

            }
            if (MessageBox.Show("Deseja excluir a despesa !!!", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (gridLista.SelectedRows.Count > 0)
                {

                    DespesasBLL bll = new DespesasBLL();
                    bool mensagem = bll.ExcluirCadastro(Convert.ToInt32(gridLista.CurrentRow.Cells[0].Value.ToString()));
                    CarregarDespesas();

                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_relatorio_Click(object sender, EventArgs e)
        {
            var dataPesquisaInicio = dtpData.Value.ToString();
            var dataPesquisaFim = dtpDataFim.Value.ToString();
            int situacaoDespesa = 0;
            int tipoDespesa = 0;


            //Verificando o status da despesa
            if (cbo_SituacaoDespesa.Text == "(TODOS)")
            {
                situacaoDespesa = 0;
            }
            else if (cbo_SituacaoDespesa.Text == "Em aberto")
            {
                situacaoDespesa = 1;
            }
            else if (cbo_SituacaoDespesa.Text == "Quitada")
            {
                situacaoDespesa = 2;
            }

            if (cbo_tipo_despesa.Text == "(TODOS)")
            {
                tipoDespesa = 0;

            }
            else
            {
                tipoDespesa = Convert.ToInt32(cbo_tipo_despesa.SelectedValue);
            }




            Relatorio.frmRelatorioDespesas reldepesas = new Relatorio.frmRelatorioDespesas();
            reldepesas.CarregaRelatorio(Convert.ToDateTime(dataPesquisaInicio), Convert.ToDateTime(dataPesquisaFim), situacaoDespesa, tipoDespesa);
            reldepesas.ShowDialog();




        }

        private void CarregarFuncionario(List<Funcionario> List)
        {

            cbo_Profissional.DataSource = List;
            cbo_Profissional.DisplayMember = "nomeFUNCIONARIO";
            cbo_Profissional.ValueMember = "Id";
            cbo_Profissional.SelectedIndex = cbo_Profissional.FindStringExact("Nenhum");
        }

        private List<Funcionario> ListaFuncionario()
        {
            dll_BS_GestaoSalao.FuncionarioBLL bll = new dll_BS_GestaoSalao.FuncionarioBLL();
            return bll.ListaFuncionarioSemID();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {

        }

        private void gridLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridLista_Click(object sender, EventArgs e)
        {
            if (gridLista.SelectedRows.Count > 0)
            {

               int codigoDespesa = Convert.ToInt32(gridLista.CurrentRow.Cells[0].Value);

                frmDespesas despesas = new frmDespesas();
                despesas.TelaAcao((int)dll_Uteis_GestaoSalao.Uteis.AcaoTela.Editar, codigoDespesa);
                despesas.ShowDialog();

            }

        }



        public  void Somar(DataTable dt)

        {
            decimal TotalGeral = 0;

            var ListaDespesa = dt.AsEnumerable().Select(linha => new Despesas
            {
                codigoDESPESA = Convert.ToInt32(linha["codigoDESPESA"].ToString()),
                descricaoDESPESA = linha["descricaoDESPESA"].ToString(),
                valorDESPESA = Convert.ToDecimal(linha["valorDESPESA"]),
                dataDESPESA = Convert.ToDateTime(linha["dataDESPESA"]),
                situacaoDESPESA = Convert.ToInt32(linha["sitDespesa"]),
                documentoDESPESA = linha["documentoDESPESA"].ToString(),
                observacaoDESPESA = linha["observacaoDESPESA"].ToString(),

            }).ToList();

            var DespesasQuitada = from despesa in ListaDespesa
                             where despesa.situacaoDESPESA == 2
                             select despesa.valorDESPESA;
            txtDespesaQuitada.Text = DespesasQuitada.Sum().ToString("C") ;

            var DespesasAberta = from despesa in ListaDespesa
                                  where despesa.situacaoDESPESA == 1
                                  select despesa.valorDESPESA;
            txtDespesaAberta.Text = DespesasAberta.Sum().ToString("C");

            TotalGeral = DespesasAberta.Sum() + DespesasQuitada.Sum();

            txtTotalGeral.Text = TotalGeral.ToString("C");

            //// soma dos saldos de todas as contas
            //double saldoTotal = ListaDespesa.Sum(c => c.valorDESPESA).ToString("C");

        }

    }
}
