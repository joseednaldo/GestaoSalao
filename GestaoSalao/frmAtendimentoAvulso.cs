using System;
using System.Collections.Generic;
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
using dll_Uteis_GestaoSalao;
using dll_BS_GestaoSalao;


namespace GestaoSalao
{
    public partial class frmAtendimentoAvulso : MaterialForm
    {
        public frmAtendimentoAvulso()
        {
            InitializeComponent();
        }

        //int Operacao=0;
        //string strFuncionario="";
        string strdiaAgendamento;
        List<String> ListaAgendamento = new List<String>();

        private void frmAtendimentoAvulso_Load(object sender, EventArgs e)
        {
            // CarregarCliente(ListaCliente());

            CarregarServico(ListaServico());
            CarregarFuncionario(ListaFuncionario());
            configGrid();
            txtPrecoServico.Text = "0,00";
            txtPrecoServico.Focus();

            if (Session.Instance.Administrador == 10)
            {
                //10  =  Admnistrador
                DtMovimentacao.Enabled = true;
            }
            else
            {
                DtMovimentacao.Enabled = false;
            }


        }

        private void btIncuir_Click(object sender, EventArgs e)
        {
           
        }

        private void CarregarCliente(List<Cliente> List)
        {
            ////dll_BS_GestaoSalao.ServicoBLL bll = new dll_BS_GestaoSalao.ServicoBLL();
            //cbo_Cliente.DataSource = List;
            //cbo_Cliente.DisplayMember = "nomeCLIENTE";
            //cbo_Cliente.ValueMember = "codigoCLIENTE";

            //cbo_Cliente.SelectedValue = 4;

        }
        private List<Cliente> ListaCliente()
        {
            dll_BS_GestaoSalao.ClienteBLL bll = new dll_BS_GestaoSalao.ClienteBLL();
            return bll.ListaCliente();
        }
        private void CarregarServico(List<Servico> List)
        {
            cbo_servico.DataSource = List;
            cbo_servico.DisplayMember = "descricaoSERVICO";
            cbo_servico.ValueMember = "Id";
        }
        private List<Servico> ListaServico()
        {
            dll_BS_GestaoSalao.ServicoBLL bll = new dll_BS_GestaoSalao.ServicoBLL();
            return bll.ListaServico();
        }

        private List<Funcionario> ListaFuncionario()
        {
            dll_BS_GestaoSalao.FuncionarioBLL bll = new dll_BS_GestaoSalao.FuncionarioBLL();
            return bll.ListaFuncionarioSemID();
        }

        private void CarregarFuncionario(List<Funcionario> List)
        {
            cbo_Profissional.DataSource = List;
            cbo_Profissional.DisplayMember = "nomeFUNCIONARIO";
            cbo_Profissional.ValueMember = "Id";
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvServico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btIncluir_Click(object sender, EventArgs e)
        {

        }

        private void addLInha(string codi, string srrvico, string valor)
        {

            string[] arr1 = new string[] { codi, srrvico, valor.ToString() };

            dgvServico.Rows.Add(arr1);

        }
        private void configGrid()
        {
            dgvServico.ColumnCount = 3;
            dgvServico.Columns[0].Name = "codigo";
            dgvServico.Columns[1].Name = "Descricao";
            dgvServico.Columns[2].Name = "Preço";

            dgvServico.Columns[0].Visible = false;
            dgvServico.Columns[0].Width = 50;
            dgvServico.Columns[1].Width = 220;
            dgvServico.Columns[2].Width = 100;


        }

        private void txtPrecoServico_Leave(object sender, EventArgs e)
        {
            if (txtPrecoServico.Text != string.Empty || txtPrecoServico.Text != "")
            {
                txtPrecoServico.Text = Convert.ToDouble(txtPrecoServico.Text).ToString("F");
            }

        }


        private void dgvServico_DoubleClick(object sender, EventArgs e)
        {
            dgvServico.Rows.RemoveAt(dgvServico.CurrentRow.Index);

        }

        private void btIncuir_Click_1(object sender, EventArgs e)
        {
            try
            {

                int TipoPagamento=0;

                if (dgvServico.RowCount == 0)
                {
                    MessageBox.Show("Por favor incluir o serviço prestado !!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                // Tela de forma de pgto
                frmPagto frmPagto = new frmPagto();
                frmPagto.ShowDialog();


                // Verificar se foi cancelado em tela de ptgo
                int cancelado = frmPagto.Canceldo;

                if (cancelado == 1)
                {
                    return;
                }


                //Retorna a forma de pgto
                Enum  TipoPgto = frmPagto.RetornaTipoPagto();


                if (TipoPgto.ToString() == "" || TipoPgto.ToString()==null)
                {
                    MessageBox.Show("Por favor escolha forma de pagamento !!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                switch (TipoPgto.ToString())
                {
                    case "DINHERO":
                        TipoPagamento = 0;
                        break;
                    case "DEBITO":
                        TipoPagamento = 1;
                        break;
                    default:
                        TipoPagamento = 0;
                        break;
                }


  
                //Data de movimentacao
                var DataMovimentacao = DtMovimentacao.Value.ToString();

                FaturamentoBLL faturamento = new FaturamentoBLL();

                // - Criando lista de serviço
                List<Servico> lista = new List<Servico>();
                if (dgvServico.RowCount > 0)
                {
                    for (int i = 0; i < dgvServico.RowCount; i++)
                    {
                        lista.Add(new Servico()
                        {
                            Id = Convert.ToInt32(dgvServico.Rows[i].Cells[0].Value.ToString()),
                            PrecoSERVICO = Convert.ToDecimal(dgvServico.Rows[i].Cells[2].Value.ToString()),
                        });
                    }
                }


                //Incluindo faturamento
                long id_fat = faturamento.GeraFaturamento(Convert.ToInt32(cbo_Profissional.SelectedValue), 0, lista, Convert.ToDateTime(DataMovimentacao),TipoPagamento,0);
                faturamento = null;
                if (id_fat > 0)
                {
                    MessageBox.Show("Atendimento realizado com sucesso !!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();
                    faturamento = null;
                    AtualizaTela();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    
        private void AtualizaTela()
        {

            // li
            dgvServico.Rows.Clear(); //Remover as linhas
            dgvServico.Refresh(); //Para a grid se actualizar
            txtPrecoServico.Text = "0,00";

        }

        private void btExcluir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btSalvarItem_Click(object sender, EventArgs e)
        //{
        //    if (txtPrecoServico.Text == string.Empty || txtPrecoServico.Text == "0" || txtPrecoServico.Text == "")
        //    {
        //        MessageBox.Show("Campo preço do serviço não esta vázio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtPrecoServico.BackColor = Color.Yellow;
        //        txtPrecoServico.Focus();
        //        return;
        //    }
        //    else
        //    {
        //        txtPrecoServico.BackColor = Color.White;
        //    }

        //    addLInha(cbo_servico.SelectedValue.ToString(), cbo_servico.Text, txtPrecoServico.Text);
        //}

        private void btSalvarItem_Click_1(object sender, EventArgs e)
        {
            if (txtPrecoServico.Text == string.Empty || txtPrecoServico.Text == "0" || txtPrecoServico.Text == "")
            {
                MessageBox.Show("Campo preço do serviço não esta vázio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecoServico.BackColor = Color.Yellow;
                txtPrecoServico.Focus();
                return;
            }
            else
            {
                txtPrecoServico.BackColor = Color.White;
            }

            addLInha(cbo_servico.SelectedValue.ToString(), cbo_servico.Text, txtPrecoServico.Text);

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

        private void txtPrecoServico_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecoServico_Leave_1(object sender, EventArgs e)
        {
            if (txtPrecoServico.Text != string.Empty || txtPrecoServico.Text != "")
            {
                txtPrecoServico.Text = Convert.ToDouble(txtPrecoServico.Text).ToString("F");
                //txtPrecoServico.Text = Convert.ToDouble(txtPrecoServico.Text).ToString("C");
            }
        }

        private void dgvServico_DoubleClick_1(object sender, EventArgs e)
        {

            dgvServico.Rows.RemoveAt(dgvServico.CurrentRow.Index);

        }

        private void dgvServico_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAtendimentoAvulso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

    }

}
