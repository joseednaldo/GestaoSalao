using System;
using System.Collections.Generic;
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
using dll_Uteis_GestaoSalao;

namespace GestaoSalao
{
    public partial class frmDespesas : MaterialForm
    {

        protected int Acao { get; set; }
        protected int CodigoDespesa { get; set; }
        public frmDespesas()
        {
            InitializeComponent();
        }

        private void frmDespesas_Load(object sender, EventArgs e)
        {

        }

        private void CarregaListas()
        {
            CarregarFuncionario(ListaFuncionario());
            // Carregarfornecedores(ListaFornecedore());
            CarregarTipoDespesa(ListaTipoDespesa());
            txtDescricao.Focus();
        }
        private void btExcluir_Click(object sender, EventArgs e)
        {

        }
        private void btExcluir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void limpaCampos()
        {

            txtDescricao.Text = "";
            txtDescricao.Focus();
            txtDocumento.Text = "";
            cbo_tipo_despesa.SelectedIndex = 0;
            dtpDespesa.Value = DateTime.Now;
            txtValorDespesa.Text = "";
            txtObserv.Text = "";
        }
        private void btIncuir_Click(object sender, EventArgs e)
        {

            if ((int)Uteis.AcaoTela.Editar == Acao) {


                Despesas despesa = new Despesas();

                despesa.codigoDESPESA = CodigoDespesa;
                despesa.descricaoDESPESA = txtDescricao.Text;
                despesa.documentoDESPESA = txtDocumento.Text;
                despesa.observacaoDESPESA = txtObserv.Text;
                despesa.valorDESPESA = Convert.ToDecimal(txtValorDespesa.Text);
                despesa.dataDESPESA = Convert.ToDateTime(dtpDespesa.Text);
                despesa.situacaoDESPESA = chkQuitarDespesa.Checked == true ? 2 : 1;


                //criando tipo despesa
                TipoDespesa tpDespesa = new TipoDespesa();
                tpDespesa.codigoTIPODESPESA = Convert.ToInt32(cbo_tipo_despesa.SelectedValue);
                despesa.tipoDESPESA = tpDespesa;

                //criando tipo funcioanrio
                Funcionario funcionario = new Funcionario();
                funcionario.Id = Convert.ToInt32(cbo_Profissional.SelectedValue);
                despesa.favorecido = funcionario;

                DespesasBLL bllDespesa = new DespesasBLL();
                bllDespesa.AlterarDespesas(despesa);
                MessageBox.Show("Alterado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if ((int)Uteis.AcaoTela.Incluir == Acao)
            {
                if (txtDescricao.Text.Trim() == "")
                {
                    MessageBox.Show("Campo descrição é obrigatório !!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescricao.Focus();
                    return;
                }

                if (txtValorDespesa.Text.Trim() == "")
                {
                    MessageBox.Show("Campo valor é obrigatório !!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtValorDespesa.Focus();
                    return;
                }

                Despesas despesa = new Despesas();

                //criando funcionario
                Funcionario fun = new Funcionario();

                if (cbo_Profissional.Text == "Atendente padrão")
                {
                    fun.Id = 0;
                }
                else
                {
                    fun.Id = Convert.ToInt32(cbo_Profissional.SelectedValue);
                }
                despesa.descricaoDESPESA = txtDescricao.Text;
                despesa.valorDESPESA = Convert.ToDecimal(txtValorDespesa.Text);
                despesa.dataDESPESA = Convert.ToDateTime(dtpDespesa.Text);
                despesa.documentoDESPESA = txtDocumento.Text;
                despesa.observacaoDESPESA = txtObserv.Text;
                despesa.favorecido = fun;

                //criando tipo despesa
                TipoDespesa tpDespesa = new TipoDespesa();
                tpDespesa.codigoTIPODESPESA = Convert.ToInt32(cbo_tipo_despesa.SelectedValue);
                despesa.tipoDESPESA = tpDespesa;

                DespesasBLL bll = new DespesasBLL();
                string mensagem = bll.CadastrarDespesa(despesa);
                MessageBox.Show(mensagem, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                tpDespesa = null;
                bll = null;
                limpaCampos();
            }

            this.Close();

        }
        private void CarregarTipoDespesa(List<TipoDespesa> List)
        {
            cbo_tipo_despesa.DataSource = List;
            cbo_tipo_despesa.DisplayMember = "descricaoTIPODESPESA";
            cbo_tipo_despesa.ValueMember = "codigoTIPODESPESA";
        }
        private List<TipoDespesa> ListaTipoDespesa()
        {
            dll_BS_GestaoSalao.TipoDespesaBLL bll = new dll_BS_GestaoSalao.TipoDespesaBLL();
            return bll.ListaTipoDespesa();
        }
        private void txtValorDespesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
         (e.KeyChar != ',' && e.KeyChar != '.' &&
          e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtValorDespesa.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }
        private void txtValorDespesa_Leave(object sender, EventArgs e)
        {
            if (txtValorDespesa.Text.Trim() != "")
            {
                txtValorDespesa.Text = Convert.ToDouble(txtValorDespesa.Text).ToString("F");
            }
        }
        private void frmDespesas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
        private void cbo_tipo_despesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbo_tipo_despesa.Text)
            {

                case "Honorários profissionais (Contador, outros)"  :
                    // FUNCIONARIO OU PRESTADOR DE SERVIÇO
                    lblTitulo.Visible = true;
                    lblTitulo.Text = "Favorecido";
                    cbo_fornecedores.Visible = false;
                    cbo_Profissional.Visible = true;
                    lblVale.Visible = true;

                    break;
                //case "Pró-labore":
                //    // FUNCIONARIO OU PRESTADOR DE SERVIÇO
                //    lblTitulo.Visible = true;
                //    lblTitulo.Text = "Favorecido";
                //    cbo_fornecedores.Visible = false;
                //    cbo_Profissional.Visible = true;
                //    break;
                case "Salário":
                    //FUNCIONARIO OU PRESTADOR DE SERVIÇO
                    lblTitulo.Visible = true;
                    lblTitulo.Text = "Favorecido";
                    cbo_fornecedores.Visible = false;
                    cbo_Profissional.Visible = true;
                    lblVale.Visible = true;
                    break;

                default:
                    lblTitulo.Visible = false;
                    lblTitulo.Text = "Fornecedores";
                    cbo_fornecedores.Visible = false;
                    cbo_Profissional.Visible = false;
                    break;
            }

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

        private void Carregarfornecedores(List<Fornecedore> List)
        {
            cbo_fornecedores.DataSource = List;
            cbo_fornecedores.DisplayMember = "nomeFORNECEDOR";
            cbo_fornecedores.ValueMember = "codigoFORNECEDOR";
        }

        private List<Fornecedore> ListaFornecedore()
        {
            dll_BS_GestaoSalao.FornecedoreBLL bll = new dll_BS_GestaoSalao.FornecedoreBLL();
            return bll.ListaFornecedore();
        }

        public void TelaAcao(int acao, int codigoDespesa = 0)
        {
            if ((int)Uteis.AcaoTela.Editar == acao)
            {
                Acao = (int)Uteis.AcaoTela.Editar;

                if (codigoDespesa != 0)
                {

                    CodigoDespesa = codigoDespesa;
                    chkQuitarDespesa.Visible = true;
                    CarregaListas();
                    DespesasBLL bllDespesa = new DespesasBLL();
                    var desp = bllDespesa.BuscaDespesa(codigoDespesa);

                    txtDescricao.Text = desp.descricaoDESPESA;
                    txtDocumento.Text = desp.documentoDESPESA;
                    txtObserv.Text = desp.observacaoDESPESA;
                    txtValorDespesa.Text = TirarMascara(desp.valorDESPESA.ToString("c"));
                    dtpDespesa.Value = desp.dataDESPESA;
                    cbo_tipo_despesa.SelectedIndex = cbo_tipo_despesa.FindStringExact(desp.tipoDESPESA.descricaoTIPODESPESA);
                    cbo_Profissional.SelectedIndex = cbo_Profissional.FindStringExact(desp.favorecido.nomeFuncionario);
                    chkQuitarDespesa.Checked = desp.situacaoDESPESA==1 ? false : true ;

                }

            } else if ((int)Uteis.AcaoTela.Incluir == acao)
            {
                CarregaListas();
                chkQuitarDespesa.Visible = false;
                Acao = (int)Uteis.AcaoTela.Incluir;
            }
        }

        private string TirarMascara(string valor)
        {

           return valor.Replace("R$", "").Trim();
        }

        private void lblVale_Click(object sender, EventArgs e)
        {
            // ideia aqui é trazer um lista dos ultimos 3 veles por data.
            frmListaVale vales = new frmListaVale();
            vales.ListaVales(Convert.ToInt32(cbo_Profissional.SelectedValue));
            vales.ShowDialog();

        }
    }
}
