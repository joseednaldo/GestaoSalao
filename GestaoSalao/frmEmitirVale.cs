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
    public partial class frmEmitirVale : MaterialForm
    {
        public frmEmitirVale()
        {
            InitializeComponent();
        }

        private void frmEmitirVale_Load(object sender, EventArgs e)
        {
            CarregarFuncionario(ListaFuncionario());
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpaCampos()
        {

            txtObservacao.Text = "";
            txtValorVale.Text = "";
            cbo_funcionario.SelectedIndex = 0;
            cbo_funcionario.Focus();
            dtVale.Value = DateTime.Now;
        }

        private void btIncuir_Click(object sender, EventArgs e)
        {

            if (txtValorVale.Text.Trim() == "")
            {
                MessageBox.Show("Campo valor é obrigatório !!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValorVale.Focus() ;
                return;
            }

            Vale vale = new Vale();
            vale.descricaoVale = txtObservacao.Text;
            vale.valorVale = Convert.ToDecimal(txtValorVale.Text);
            vale.dataVale = Convert.ToDateTime(dtVale.Text);

            //criando funcionario
            Funcionario fun = new Funcionario();
            fun.Id = Convert.ToInt32(cbo_funcionario.SelectedValue);
            vale.funcionarioVale = fun;

            ValeBLL bll = new ValeBLL();
            string mensagem = bll.EmitirVale(vale);
            MessageBox.Show(mensagem, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            fun = null;
            bll = null;

            limpaCampos();

           


        }

        private void CarregarFuncionario(List<Funcionario> List)
        {
            cbo_funcionario.DataSource = List;
            cbo_funcionario.DisplayMember = "nomeFUNCIONARIO";
            cbo_funcionario.ValueMember = "Id";
        }

        private List<Funcionario> ListaFuncionario()
        {
            dll_BS_GestaoSalao.FuncionarioBLL bll = new dll_BS_GestaoSalao.FuncionarioBLL();
            return bll.ListaFuncionarioSemID();
        }

        private void frmEmitirVale_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void frmEmitirVale_Leave(object sender, EventArgs e)
        {

        }

        private void txtValorVale_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorVale_KeyPress(object sender, KeyPressEventArgs e)
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
                    if (!txtValorVale.Text.Contains(','))
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

        private void txtValorVale_Leave(object sender, EventArgs e)
        {


            if (txtValorVale.Text.Trim() != "")
            {
                txtValorVale.Text = Convert.ToDouble(txtValorVale.Text).ToString("F");
            }

        }

        private void frmEmitirVale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void cbo_funcionario_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
