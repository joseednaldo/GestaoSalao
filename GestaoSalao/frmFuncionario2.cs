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
    public partial class frmFuncionario2 : MaterialForm
    {
        public int Operacao;
        public frmFuncionario2()
        {
            InitializeComponent();
        }
        private void DesabiltarBotoes()
        {
            btNovo.Enabled = true;
            btExcluir.Enabled = false;
            btIncuir.Enabled = false;
            btEditar.Enabled = false;
            txtNomeFuncionario.Focus();
        }
        private void HabilitarBotoes()
        {
            btNovo.Enabled = false;
            btExcluir.Enabled = false;
            btIncuir.Enabled = true;
            btEditar.Enabled = false;

        }
        private void limpaCampos()
        {
            txtNomeFuncionario.Text = "";
            txtNomeFuncionario.Focus() ;
            txtCpf.Text = "";
            txtFone1.Text = "";
            txtFone2.Text = "";
            chkAtivo.Checked = false;
           
        }
        private void frmFuncionario2_Load(object sender, EventArgs e)
        {

        }
        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btIncuir_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNomeFuncionario.Text))
            {
                MessageBox.Show("Campo nome do funcionário é obrigatório !!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                Funcionario funcionario = new Funcionario();
                funcionario.nomeFuncionario = txtNomeFuncionario.Text;
                funcionario.fone1 = txtFone1.Text;
                funcionario.fone2 = txtFone2.Text;
                funcionario.cpf = txtCpf.Text;
                funcionario.ativo = chkAtivo.Checked;

                FuncionarioBLL bll = new FuncionarioBLL();
                string mensagem = bll.CadastrarFuncionario(funcionario);
                MessageBox.Show(mensagem, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DesabiltarBotoes();
                limpaCampos();
                CarregarFuncionario(bll.ListaFuncionario());

            }

        }
        private void CarregarFuncionario(List<Funcionario> List)
        {
            //dll_BS_GestaoSalao.ServicoBLL bll = new dll_BS_GestaoSalao.ServicoBLL();
            dgvFuncionarios.DataSource = List;
            dgvFuncionarios.Refresh();
           configuraDataGridView();
        }
        private void configuraDataGridView()
        {
          

            dgvFuncionarios.AutoGenerateColumns = false;

            dgvFuncionarios.Columns[0].HeaderText = "Código";
            dgvFuncionarios.Columns[1].HeaderText = "Funcionário";
            dgvFuncionarios.Columns[2].HeaderText = "Celular";
            dgvFuncionarios.Columns[3].HeaderText = "Tel.Residêncial";
            dgvFuncionarios.Columns[4].HeaderText = "Ativo";
            dgvFuncionarios.Columns[5].HeaderText = "Cpf";

            //  Reverenciando as colunas do grid com as colunas vinda da tabela
            dgvFuncionarios.Columns[0].DataPropertyName = "Id";
            dgvFuncionarios.Columns[1].DataPropertyName = "nomeFuncionario";
            dgvFuncionarios.Columns[2].DataPropertyName = "fone1";
            dgvFuncionarios.Columns[3].DataPropertyName = "fone2";
            dgvFuncionarios.Columns[4].DataPropertyName = "Ativo";
            dgvFuncionarios.Columns[5].DataPropertyName = "Cpf";

            //Redimenciona cada coluna
            dgvFuncionarios.Columns[0].Width = 60;
            dgvFuncionarios.Columns[1].Width = 250;
            dgvFuncionarios.Columns[2].Width = 80;
            dgvFuncionarios.Columns[3].Width = 80;
            dgvFuncionarios.Columns[4].Width = 60;
            dgvFuncionarios.Columns[5].Width = 100;

        }
        private List<Funcionario> ListaFuncionario()
        {
            dll_BS_GestaoSalao.FuncionarioBLL bll = new dll_BS_GestaoSalao.FuncionarioBLL();
            return bll.ListaFuncionario();
        }

        private void frmFuncionario2_Load_1(object sender, EventArgs e)
        {
            CarregarFuncionario(ListaFuncionario());
            ConfigTela();
        }
        private void dgvFuncionarios_Click(object sender, EventArgs e)
        {
            if (dgvFuncionarios.SelectedRows.Count > 0)
            {

                try
                {
                    var funcionario = dgvFuncionarios.CurrentRow.Cells[1].Value.ToString().Split('-');

                    btEditar.Enabled = true;
                    btExcluir.Enabled = true;
                    btIncuir.Enabled = false;
                    btNovo.Enabled = true;
                    txtCodigo.Text = funcionario[0];
                    txtNomeFuncionario.Text = funcionario[1];//dgvFuncionarios.CurrentRow.Cells[1].Value.ToString();
                    txtCpf.Text = dgvFuncionarios.CurrentRow.Cells[5].Value.ToString();
                    txtFone1.Text = dgvFuncionarios.CurrentRow.Cells[2].Value.ToString();
                    txtFone2.Text = dgvFuncionarios.CurrentRow.Cells[3].Value.ToString();
                    chkAtivo.Checked = Convert.ToBoolean(dgvFuncionarios.CurrentRow.Cells[4].Value.ToString());
                }
                catch (Exception)
                {

                    throw;
                }

            }

        }
        private void btNovo_Click(object sender, EventArgs e)
        {
            HabilitarBotoes();
            limpaCampos();

            Operacao = 0;
        }

        private void ConfigTela()
        {
            if (dgvFuncionarios.SelectedRows.Count > 0)
            {
                dgvFuncionarios.Rows[0].Selected = true;
                btIncuir.Enabled = false;
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {

                FuncionarioBLL bll = new FuncionarioBLL();
                bool mensagem = bll.ExcluirCadastro(Convert.ToInt32(txtCodigo.Text.ToString()));
                //  DesabiltarBotoes();
                CarregarFuncionario(ListaFuncionario());
            }
        }

        private void frmFuncionario2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btEditar.Enabled = true;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeFuncionario.Text))
            {
                MessageBox.Show("Campo nome do funcionário é obrigatório !!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                Funcionario funcionario = new Funcionario();
                funcionario.nomeFuncionario = txtNomeFuncionario.Text;
                funcionario.fone1 = txtFone1.Text;
                funcionario.fone2 = txtFone2.Text;
                funcionario.cpf = txtCpf.Text;
                funcionario.ativo = chkAtivo.Checked;
                funcionario.Id = Convert.ToInt32(txtCodigo.Text);

                FuncionarioBLL bll = new FuncionarioBLL();
                string mensagem = bll.AlterarFuncionario(funcionario);
                if (mensagem == "OK")
                {
                    MessageBox.Show("Alteração realizada com sucesso!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DesabiltarBotoes();
                    limpaCampos();
                    CarregarFuncionario(bll.ListaFuncionario());
                }

            }
        }
    }

    
}
