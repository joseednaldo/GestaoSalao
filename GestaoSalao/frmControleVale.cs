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
using GestaoSalao.Relatorio;

namespace GestaoSalao
{
    public partial class frmControleVale : MaterialForm
    {
     
        public int CodigoVale { get; set; }

        public frmControleVale()
        {
            InitializeComponent();
        }

        private void frmControleVale_Load(object sender, EventArgs e)
        {
            CarregarFuncionario(ListaFuncionario());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEmitirVale valeFuncionario = new frmEmitirVale();
            valeFuncionario.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBusca_Click(object sender, EventArgs e)
        {
            CarregarVales();
        }

        private void CarregarVales()
        {

            var dataPesquisaInicio = dtpData.Value.ToString();
            var dataPesquisaFim = dtpDataFim.Value.ToString();
            int filtroFunc = 0;

            if (chkFiltroFuncionario.Checked == true)
            {
                filtroFunc = 1;
            }
            else
            {
                filtroFunc = 0;
            }

            var atendente = Convert.ToInt32(cbo_Profissional.SelectedValue);

            dll_BS_GestaoSalao.ValeBLL bll = new dll_BS_GestaoSalao.ValeBLL();
            DtVele(bll.ListaVale(atendente, Convert.ToDateTime(dataPesquisaInicio), Convert.ToDateTime(dataPesquisaFim), filtroFunc));



        }

        private void CarregarVele(List<Vale> List)
        {

            gridLista.DataSource = null; //Remover a datasource
            gridLista.Columns.Clear(); //Remover as colunas
            gridLista.Rows.Clear(); //Remover as linhas
            gridLista.Refresh(); //Para a grid se actualizar

            configuraDataGridView();
            gridLista.DataSource = List;
            txtTotalGeral.Text = "";
            txtTotalGeral.Text = Somar(List);

        }

        private void DtVele(DataTable dtVale)
        {

            gridLista.DataSource = null; //Remover a datasource
            gridLista.Columns.Clear(); //Remover as colunas
            gridLista.Rows.Clear(); //Remover as linhas
            gridLista.Refresh(); //Para a grid se actualizar

            configuraDataGridView();
            gridLista.DataSource = dtVale;
            txtTotalGeral.Text = "";
            txtTotalGeral.Text = ValorTotal().ToString("c");
        }

        private void CarregarFuncionario(List<Funcionario> List)
        {

            cbo_Profissional.DataSource = List;
            cbo_Profissional.DisplayMember = "nomeFUNCIONARIO";
            cbo_Profissional.ValueMember = "Id";
        }

        private List<Funcionario> ListaFuncionario()
        {
            dll_BS_GestaoSalao.FuncionarioBLL bll = new dll_BS_GestaoSalao.FuncionarioBLL();
            return bll.ListaFuncionarioSemID();
        }

        private void configuraDataGridView()
        {
           
            gridLista.AutoGenerateColumns = false;
            gridLista.ColumnCount = 5;

            gridLista.Columns[0].HeaderText = "Código";
            gridLista.Columns[1].HeaderText = "Descrição";
            gridLista.Columns[2].HeaderText = "Valor";
            gridLista.Columns[3].HeaderText = "Data";
            gridLista.Columns[4].HeaderText = "Funcionário";

            //Reverenciando as colunas do grid com as colunas vinda da tabela
            gridLista.Columns[0].DataPropertyName = "codigoVALE";
            gridLista.Columns[1].DataPropertyName = "descricaoVALE";
            gridLista.Columns[2].DataPropertyName = "valorVALE";
            gridLista.Columns[3].DataPropertyName = "dataVALE";
            gridLista.Columns[4].DataPropertyName = "nomefuncionario";
          

            //visible 
            // gridLista.Columns[1].Visible = false;

            //Redimenciona cada coluna
            gridLista.Columns[0].Width = 50;
            gridLista.Columns[1].Width = 250;
            gridLista.Columns[2].Width = 80;
            gridLista.Columns[3].Width = 80;
            gridLista.Columns[4].Width = 220;

            //Trata o campo valor
            gridLista.Columns[2].DefaultCellStyle.Format = "C2";

        }


        public string Somar(List<Vale> List)

        {
            decimal TotalServivo = 0;

            //Cria as coluanas conforme a quantidade e nome dos funcionarios
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].valorVale != 0)
                {
                    TotalServivo = TotalServivo + List[i].valorVale;
                    gridLista.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

            }

            return TotalServivo.ToString();
        }
        public decimal ValorTotal()
        {

            decimal TotalServivo = 0;

            if (gridLista.Rows.Count > 0)

            //Cria as coluanas conforme a quantidade e nome dos funcionarios
            for (int i = 0; i < gridLista.Rows.Count; i++)
            { 
                TotalServivo = TotalServivo + Convert.ToDecimal(gridLista.Rows[i].Cells[2].Value); ;
                gridLista.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            return TotalServivo;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {



            if (MessageBox.Show("Deseja excluir o vale !!!", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (gridLista.SelectedRows.Count > 0)
                {

                    ValeBLL bll = new ValeBLL();
                    bool mensagem = bll.ExcluirVale(Convert.ToInt32(gridLista.CurrentRow.Cells[0].Value.ToString()));
                    CarregarVales();

                }

            }


        }

        private void frmControleVale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void btn_relatorio_Click(object sender, EventArgs e)
        {

            CarregaRel();

            //var dataPesquisaInicio = dtpData.Value.ToString();
            //var dataPesquisaFim = dtpDataFim.Value.ToString();
            //int filtroFunc = 0;

            //if (chkFiltroFuncionario.Checked == true)
            //{
            //    filtroFunc = 1;
            //}
            //else
            //{
            //    filtroFunc = 0;
            //}

            //var atendente = Convert.ToInt32(cbo_Profissional.SelectedValue);

            //RelatorioVale vale = new RelatorioVale();
            //vale.CarregaRelatorio(atendente, Convert.ToDateTime(dataPesquisaInicio), Convert.ToDateTime(dataPesquisaFim), filtroFunc);
            //vale.ShowDialog();


        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {

        }

        private void txtTotalGeral_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarregaRel()
        {
            var dataPesquisaInicio = dtpData.Value.ToString();
            var dataPesquisaFim = dtpDataFim.Value.ToString();
            int filtroFunc = 0;

            if (chkFiltroFuncionario.Checked == true)
            {
                filtroFunc = 1;
            }
            else
            {
                filtroFunc = 0;
            }

            var atendente = Convert.ToInt32(cbo_Profissional.SelectedValue);

            RelatorioVale vale = new RelatorioVale();
            vale.CarregaRelatorio(atendente, Convert.ToDateTime(dataPesquisaInicio), Convert.ToDateTime(dataPesquisaFim), filtroFunc,0);
            vale.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!chkFiltroFuncionario.Checked)
            {
                MessageBox.Show("Por favor selecione o filtro, e pesquise o funcionário !!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (CodigoVale <= 0)
            {
                MessageBox.Show("Por favor selecione um Vale !!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var dataPesquisaInicio = dtpData.Value.ToString();
            var dataPesquisaFim = dtpDataFim.Value.ToString();
            int filtroFunc = 0;

            if (chkFiltroFuncionario.Checked == true)
            {
                filtroFunc = 1;
            }
            else
            {
                filtroFunc = 0;
            }

            var atendente = Convert.ToInt32(cbo_Profissional.SelectedValue);

                RelatorioRecibo vale = new RelatorioRecibo();
                vale.CarregaRelatorio(atendente, Convert.ToDateTime(dataPesquisaInicio), Convert.ToDateTime(dataPesquisaFim), filtroFunc, CodigoVale);
                vale.ShowDialog();

        }

        private void gridLista_Click(object sender, EventArgs e)
        {
            if (gridLista.SelectedRows.Count > 0)
            {
                CodigoVale = Convert.ToInt32(gridLista.CurrentRow.Cells[0].Value);
            }
        }

        private void gridLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
