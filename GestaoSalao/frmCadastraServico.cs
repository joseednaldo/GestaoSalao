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
    public partial class frmCadastraServico : MaterialForm
    {

      

        public frmCadastraServico()
        {
            InitializeComponent();
        }
        private void frmCadastraServico_Load(object sender, EventArgs e)
        {
            txtDescricao.TabIndex = 0;
            DesabiltarBotoes();

            CarregarServico(ListaServico());
        }
        private void DesabiltarBotoes()
        {
            btNovo.Enabled = true;
            btExcluir.Enabled = false;
            btIncuir.Enabled = false;
            btEditar.Enabled = false;
            txtDescricao.Focus();
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

            if (txtDescricao.Text == "")
            {
                MessageBox.Show("Por favor escreva o nome do serviço !!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricao.BackColor = Color.Yellow;
                txtDescricao.Focus();
                return;
            }
            else
            {
                servico.DescricaoSERVICO = txtDescricao.Text;
                txtPrecoServico.BackColor = Color.White;
            }

            if (txtPrecoServico.Text == string.Empty || txtPrecoServico.Text == "0" || txtPrecoServico.Text == "")
            {
                MessageBox.Show("Campo preço do serviço esta vázio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecoServico.BackColor = Color.Yellow;
                txtPrecoServico.Focus();
                return;
            }
            else
            {
                txtPrecoServico.BackColor = Color.White;
                servico.PrecoSERVICO = Convert.ToDecimal(txtPrecoServico.Text);
            }

            ServicoBLL bll = new ServicoBLL();
            string mensagem = bll.CadastrarServico(servico);
            MessageBox.Show(mensagem, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            DesabiltarBotoes();

            CarregarServico(bll.ListaServico());
            LimpaCampos();
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
                LimpaCampos();
            }

        }

        private void LimpaCampos()
        {
            txtDescricao.Text = "";
            txtDescricao.Focus();
            txtPrecoServico.Text = "0,00";
        }
        private void CarregarServico(List<Servico> List)
        {
            //dll_BS_GestaoSalao.ServicoBLL bll = new dll_BS_GestaoSalao.ServicoBLL();
            dgvServico.DataSource = List;
            configuraDataGridView();
        }
        private void configuraDataGridView()
        {

             dgvServico.AutoGenerateColumns = false;

            dgvServico.Columns[0].HeaderText = "Código";
            dgvServico.Columns[1].HeaderText = "Serviço";
            dgvServico.Columns[2].HeaderText = "Preço";

            //Reverenciando as colunas do grid com as colunas vinda da tabela
            dgvServico.Columns[0].DataPropertyName = "Id";
            dgvServico.Columns[1].DataPropertyName = "descricaoservico";
            dgvServico.Columns[2].DataPropertyName = "precoservico";

            //Redimenciona cada coluna
            dgvServico.Columns[0].Width = 60;
            dgvServico.Columns[1].Width = 250;
            dgvServico.Columns[2].Width = 60;
            

        }
        private void btEditar_Click(object sender, EventArgs e)
        {
          
                if ( dgvServico.SelectedRows.Count>0)
                {
                    var id = Convert.ToInt32(dgvServico.CurrentRow.Cells[0].Value.ToString());

                    if (txtDescricao.Text == "")
                    {
                        MessageBox.Show("Por favor escreva o nome do serviço !!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDescricao.BackColor = Color.Yellow;
                        txtDescricao.Focus();
                        return;
                    }

                    if (txtPrecoServico.Text == string.Empty || txtPrecoServico.Text == "0" || txtPrecoServico.Text == "")
                    {
                        MessageBox.Show("Campo preço do serviço esta vázio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPrecoServico.BackColor = Color.Yellow;
                        txtPrecoServico.Focus();
                        return;
                    }

                    Servico servico = new Servico();
                    servico.Id = id;
                    servico.DescricaoSERVICO = txtDescricao.Text;
                    servico.PrecoSERVICO = Convert.ToDecimal(txtPrecoServico.Text.ToString());

                    ServicoBLL bll = new ServicoBLL();
                    bool mensagem = bll.AlterarServico(servico);
                
                    DesabiltarBotoes();
                    LimpaCampos();
                    CarregarServico(ListaServico());


            }
                
          
        }
        private void dgvServico_Click(object sender, EventArgs e)
        {
            if (dgvServico.SelectedRows.Count > 0)
            {

                btEditar.Enabled = true;
                btExcluir.Enabled = true;
                txtCodigo.Text= dgvServico.CurrentRow.Cells[0].Value.ToString();
                txtDescricao.Text = dgvServico.CurrentRow.Cells[1].Value.ToString();
                txtPrecoServico.Text =dgvServico.CurrentRow.Cells[2].Value.ToString();
            }



        }
        private List<Servico> ListaServico()
        {
            dll_BS_GestaoSalao.ServicoBLL bll = new dll_BS_GestaoSalao.ServicoBLL();
            return bll.ListaServico();
        }

        private void dgvServico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPrecoServico_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecoServico_KeyPress(object sender, KeyPressEventArgs e)
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
                    if (!txtPrecoServico.Text.Contains(','))
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

        private void txtPrecoServico_Leave(object sender, EventArgs e)
        {
            if (txtPrecoServico.Text !="")
            txtPrecoServico.Text = Convert.ToDouble(txtPrecoServico.Text).ToString("F");
        }

        private void frmCadastraServico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
    }
}
