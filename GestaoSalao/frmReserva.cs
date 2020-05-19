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
    public partial class frmReserva : MaterialForm
    {
        //int Operacao=0;
        //string strFuncionario="";
        string strdiaAgendamento;
        List<String> ListaAgendamento = new List<String>();

        public frmReserva()
        {
            InitializeComponent();
        }

        public frmReserva(string profissional, List<String> ListaHorarios, string diaAgendamento)
        {
            InitializeComponent();
            txtProfissional.Text = profissional;
            ListaAgendamento = ListaHorarios;
            strdiaAgendamento = diaAgendamento;
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {


            //CarregarCliente(ListaCliente());
            CarregarServico(ListaServico());
            configGrid();
            txtPrecoServico.Text = "0,00";
            txtPrecoServico.Focus();
        }


        private void btIncuir_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtProfissional.Text == "")
                {
                    MessageBox.Show("Selecione o dia de cancelamento na Agenda !!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (dgvServico.RowCount == 0)
                {
                    MessageBox.Show("Por favor incluir o serviço prestado !!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                Agendamento agenda = new Agendamento();
                AgendamentoBLL bllPedido = new AgendamentoBLL();

                string funcioanario = txtProfissional.Text.Substring(0, 3);
                agenda.funcionarioAGENDAMENTO = Convert.ToInt32((funcioanario.Replace("-", "")));

                agenda.observacaoAGENDAMENTO = txtDetalhe.Text;
                agenda.codigoCliente = 4;//Convert.ToInt32(cbo_Cliente.SelectedValue); esta fixo com o cliente padrao por enquanto...
                agenda.nomeclienteAGENDAMENTO= txtCliente.Text;
                agenda.codigoSERVICO = Convert.ToInt32(cbo_servico.SelectedValue);
                agenda.diaAGENDAMENTO = Convert.ToDateTime(strdiaAgendamento);
                agenda.fone_celular = txtFone1.Text;


                
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

                // motivo: nao estou usando o cadastro de cliente, estou guardando o nome do cliente

                long Pedido = bllPedido.GeraPedido(Convert.ToInt32((funcioanario.Replace("-", ""))), 4, lista);
                bllPedido = null;
                if (Pedido == 0)
                    return;

                for (int i = 0; i < ListaAgendamento.Count; i++)
                {

                    String[] substrings = ListaAgendamento[i].Split('|');

                    agenda.linhaAGENDAMENTO = Convert.ToInt32(substrings[1]);
                    agenda.colunaAGENDAMENTO = Convert.ToInt32(substrings[2]);

                    AgendamentoBLL bll = new AgendamentoBLL();
                    var ObjHorario = bll.RetornaCodigoServico(substrings[0]);

                    //Retirando a duplicidade  dos horarios
                    var hora = ObjHorario;
                    var Horarios = from a in hora
                                   group a.codigoHORARIO by a.codigoHORARIO;

                    foreach (var horario in Horarios)
                    {
                        var codigo = horario.Key;
                        agenda.codigoHorario = codigo;
                    }

                    agenda.relacaoPEDIDO = Pedido;

                    string mensagem = bll.CadastrarAgendamento(agenda);
                    bll = null;
                    this.Close();
                    Dispose();

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void CarregarCliente(List<Cliente> List)
        {
        //    cbo_Cliente.DataSource = List;
        //    cbo_Cliente.DisplayMember = "nomeCLIENTE";
        //    cbo_Cliente.ValueMember = "codigoCLIENTE";
        //    cbo_Cliente.SelectedValue = 4;

        }
        //private List<Cliente> ListaCliente()
        //{
        //    //dll_BS_GestaoSalao.ClienteBLL bll = new dll_BS_GestaoSalao.ClienteBLL();
        //    //return bll.ListaCliente();
        //}
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
            return bll.ListaFuncionario();
        }

        private void CarregarFuncionario(List<Funcionario> List)
        {
            cbo_profissional.DataSource = List;
            cbo_profissional.DisplayMember = "nomeFUNCIONARIO";
            cbo_profissional.ValueMember = "Id";
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
                    if (!textBox1.Text.Contains(','))
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
            if (txtPrecoServico.Text != string.Empty  || txtPrecoServico.Text != "")
            {
                txtPrecoServico.Text = Convert.ToDouble(txtPrecoServico.Text).ToString("F");
                //txtPrecoServico.Text = Convert.ToDouble(txtPrecoServico.Text).ToString("C");
            }

        }

        private void txtPrecoServico_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvServico_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dgvServico_DoubleClick(object sender, EventArgs e)
        {
            dgvServico.Rows.RemoveAt(dgvServico.CurrentRow.Index);
          
        }

        private void cbo_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmReserva_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
    }

}
