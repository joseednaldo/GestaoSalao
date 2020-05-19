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
    public partial class frmFuncionario :  MaterialForm
    {

        public frmFuncionario()
        {
            
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
        private void btIncuir_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico();
            servico.DescricaoSERVICO = txtNomeFuncionario .Text;
            servico.PrecoSERVICO = Convert.ToDecimal(txtNomeFuncionario.Text);

            ServicoBLL bll = new ServicoBLL();
            string mensagem = bll.CadastrarServico(servico);
            MessageBox.Show(mensagem, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            DesabiltarBotoes();

            CarregarServico(bll.ListaServico());
        }
        private void btNovo_Click(object sender, EventArgs e)
        {
            HabilitarBotoes();
        }
        private void btExcluir_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text != "")
            {

                ServicoBLL bll = new ServicoBLL();
                bool mensagem = bll.ExcluirCadastro(Convert.ToInt32(txtCodigo.Text.ToString()));
                //  DesabiltarBotoes();
                CarregarServico(ListaServico());
            }

        }
        private void CarregarServico(List<Servico> List)
        {
            //dll_BS_GestaoSalao.ServicoBLL bll = new dll_BS_GestaoSalao.ServicoBLL();
            dgvFuncionarios.DataSource = List;
            configuraDataGridView();
        }
        private void configuraDataGridView()
        {

            dgvFuncionarios.AutoGenerateColumns = false;

            dgvFuncionarios.Columns[0].HeaderText = "Código";
            dgvFuncionarios.Columns[1].HeaderText = "Serviço";
            dgvFuncionarios.Columns[2].HeaderText = "Preço";

            //Reverenciando as colunas do grid com as colunas vinda da tabela
            dgvFuncionarios.Columns[0].DataPropertyName = "Id";
            dgvFuncionarios.Columns[1].DataPropertyName = "descricaoservico";
            dgvFuncionarios.Columns[2].DataPropertyName = "precoservico";

            //Redimenciona cada coluna
            dgvFuncionarios.Columns[0].Width = 60;
            dgvFuncionarios.Columns[1].Width = 250;
            dgvFuncionarios.Columns[2].Width = 60;


        }
        private void btEditar_Click(object sender, EventArgs e)
        {

            if (dgvFuncionarios.SelectedRows.Count > 0)
            {
                var id = Convert.ToInt32(dgvFuncionarios.CurrentRow.Cells[0].Value.ToString());

                Servico servico = new Servico();
                servico.Id = id;
                servico.DescricaoSERVICO = dgvFuncionarios.Text;
                servico.PrecoSERVICO = Convert.ToDecimal(dgvFuncionarios.Text.ToString());

                ServicoBLL bll = new ServicoBLL();
                bool mensagem = bll.AlterarServico(servico);

                DesabiltarBotoes();
                CarregarServico(ListaServico());
            }


        }
        private void dgvServico_Click(object sender, EventArgs e)
        {
            if (dgvFuncionarios.SelectedRows.Count > 0)
            {

                btEditar.Enabled = true;
                btExcluir.Enabled = true;
                txtCodigo.Text = dgvFuncionarios.CurrentRow.Cells[0].Value.ToString();
                dgvFuncionarios.Text = dgvFuncionarios.CurrentRow.Cells[1].Value.ToString();
                dgvFuncionarios.Text = dgvFuncionarios.CurrentRow.Cells[2].Value.ToString();
            }



        }
        private List<Servico> ListaServico()
        {
            dll_BS_GestaoSalao.ServicoBLL bll = new dll_BS_GestaoSalao.ServicoBLL();
            return bll.ListaServico();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btIncuir_Click_1(object sender, EventArgs e)
        {
            //criar rotina de 
        }

        private void frmFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
    }
}
