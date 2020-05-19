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
    public partial class frmCadastroUsuario : MaterialForm
    {
        bool acao;

        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            ConfigTela();

        }

        private void  ConfigTela()
        {
            CarregarFuncionario(ListaFunc());
            cbo_funcionario.SelectedValue = "";

            ListaPerfil(ListaPerfil());
            cbo_pefil.SelectedValue = "";

            ListaSituacao(ListaSituacao());
            cbo_situacao.SelectedValue = "";

            ListaUsuario();
        }

        private List<Situacao> ListaSituacao()
        {
            dll_BS_GestaoSalao.Listas bll = new dll_BS_GestaoSalao.Listas();
            return bll.ListaSituacao();
        }

        private List<Funcionario> ListaFunc()
        {
            dll_BS_GestaoSalao.Listas bll = new dll_BS_GestaoSalao.Listas();
            return bll.ListaFuncionario();
        }

        private void CarregarFuncionario(List<Funcionario> List)
        {
            cbo_funcionario.DataSource = List;
            cbo_funcionario.DisplayMember = "nomeFuncionario";
            cbo_funcionario.ValueMember = "Id";
        }

        private void ListaPerfil(List<Pefil> List)
        {
            cbo_pefil.DataSource = List;
            cbo_pefil.DisplayMember = "nomepefil";
            cbo_pefil.ValueMember = "codigopefil";
        }

        private void ListaSituacao(List<Situacao> List)
        {
            cbo_situacao.DataSource = List;
            cbo_situacao.DisplayMember = "nomeSTATUS";
            cbo_situacao.ValueMember = "codigoSTATUS";
        }

        private List<Pefil> ListaPerfil()
        {
            dll_BS_GestaoSalao.Listas bll = new dll_BS_GestaoSalao.Listas();
            return bll.ListaPerfil();
        }

        private void btIncuir_Click(object sender, EventArgs e)
        {
            GerenciarUsuario(acao);
            btNovo.Enabled = true;
        }

        public void GerenciarUsuario(bool acao)
        {

            //Inclusão
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Campo login é obrigatório !!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogin.Focus();
                return;
            }
            if (txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Campo senha é obrigatório !!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogin.Focus();
                return;
            }

            if (txtRedefinirSenha.Text.Trim() == "")
            {
                MessageBox.Show("Campo redefinir senha é obrigatório !!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRedefinirSenha.Focus();
                return;
            }

            //Valida se senha é igual a redefinirsenha
            if (txtRedefinirSenha.Text.Trim() != txtSenha.Text.Trim())
            {
                MessageBox.Show("Senhas não conferem !!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRedefinirSenha.Focus();
                return;
            }


            if (cbo_funcionario.SelectedValue == null)
            {
                MessageBox.Show("Nome é obrigatório !!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_funcionario.Focus();
                return;
            }

            if (cbo_pefil.SelectedValue == null)
            {
                MessageBox.Show("Pefil é obrigatório !!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_pefil.Focus();
                return;
            }

            if (cbo_situacao.SelectedValue == null)
            {
                MessageBox.Show("Situação é obrigatório !!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_situacao.Focus();
                return;
            }


            Usuario usuario = new Usuario();

            Funcionario funcionario = new Funcionario();
            funcionario.Id = Convert.ToInt32(cbo_funcionario.SelectedValue);

            Situacao situacao = new Situacao();
            situacao.codigoSTATUS = Convert.ToInt32(cbo_situacao.SelectedValue);

            Pefil pefil = new Pefil();
            pefil.codigopefil = Convert.ToInt32(cbo_pefil.SelectedValue);

            if (txtcodUsuario.Text != ""){
                usuario.codigoUSUARIO = Convert.ToInt32(txtcodUsuario.Text);
            }
          
            usuario.funcionarioUSUARIO = funcionario;
            usuario.loginUSUARIO = txtLogin.Text;
            usuario.senhaUSUARIO = txtSenha.Text;
            usuario.redigitarUSUARIO = txtRedefinirSenha.Text;
            usuario.pefilUSUARIO = pefil;
            usuario.situacaoUSUARIO = situacao;


            if (acao == true)
            {
              

                UsuarioBLL bll = new UsuarioBLL();
                string mensagem = bll.CadastrarUsuario(usuario);
                MessageBox.Show(mensagem, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaCampos();
                ConfigTela();

            }
            else
            {
                UsuarioBLL bll = new UsuarioBLL();
                string mensagem = bll.AlterarUsuario(usuario);
                MessageBox.Show(mensagem, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaCampos();
                ConfigTela();

            }
        }

        private void ListaUsuario()
        {
            dll_BS_GestaoSalao.UsuarioBLL bll = new dll_BS_GestaoSalao.UsuarioBLL();
            CarregarUsuario(bll.ListaUsuario());
        }

        private void CarregarUsuario(DataTable dtUsuario)
        {

            dgUsuarios.DataSource = null; //Remover a datasource
            dgUsuarios.Columns.Clear(); //Remover as colunas
            dgUsuarios.Rows.Clear(); //Remover as linhas
            dgUsuarios.Refresh(); //Para a grid se actualizar

            configGridUsuario();
            dgUsuarios.DataSource = dtUsuario;
           
        }

        private void configGridUsuario()
        {

            dgUsuarios.AutoGenerateColumns = false;
            dgUsuarios.ColumnCount = 5;

            dgUsuarios.Columns[0].HeaderText = "codigoUSUARIO";
            dgUsuarios.Columns[1].HeaderText = "Login";
            dgUsuarios.Columns[2].HeaderText = "Nome";
            dgUsuarios.Columns[3].HeaderText = "Situação";
            dgUsuarios.Columns[4].HeaderText = "Pefil";

            //Reverenciando as colunas do grid com as colunas vinda da tabela
            dgUsuarios.Columns[0].DataPropertyName = "codigoUSUARIO";
            dgUsuarios.Columns[1].DataPropertyName = "loginUSUARIO";
            dgUsuarios.Columns[2].DataPropertyName = "nomeFUNCIONARIO";
            dgUsuarios.Columns[3].DataPropertyName = "nomeSTATUS";
            dgUsuarios.Columns[4].DataPropertyName = "descricao_perfil";

            dgUsuarios.Columns[0].Visible = false;

            //Redimenciona cada coluna
            dgUsuarios.Columns[0].Width = 0;
            dgUsuarios.Columns[1].Width = 100;
            dgUsuarios.Columns[2].Width = 120;
            dgUsuarios.Columns[3].Width = 60;
            dgUsuarios.Columns[4].Width = 200;

        }

        private void dgUsuarios_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count > 0)
            {

                try
                {

                    txtcodUsuario.Text = dgUsuarios.CurrentRow.Cells[0].Value.ToString();
                    txtLogin.Text = dgUsuarios.CurrentRow.Cells[1].Value.ToString();
                    txtRedefinirSenha.Text = "******";
                    txtSenha.Text = "******";
                    cbo_funcionario.SelectedIndex= cbo_funcionario.FindString(dgUsuarios.CurrentRow.Cells[2].Value.ToString());
                    cbo_pefil.SelectedIndex = cbo_pefil.FindString(dgUsuarios.CurrentRow.Cells[4].Value.ToString());
                    cbo_situacao.SelectedIndex = cbo_situacao.FindString(dgUsuarios.CurrentRow.Cells[3].Value.ToString());

                    //alteração
                    acao = false;


                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            btNovo.Enabled = false;
            LimpaCampos();
            acao = true;
        }


        private void LimpaCampos()
        {
            txtLogin.Text = "";
            txtcodUsuario.Text = "";
            txtRedefinirSenha.Text = "";
            txtSenha.Text = "";
            cbo_funcionario.SelectedIndex = 0;
            cbo_pefil.SelectedIndex = 0;
            cbo_situacao.SelectedIndex = 0;
            txtLogin.Focus();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (txtcodUsuario.Text != "")
            {

                UsuarioBLL bll = new UsuarioBLL();
                bool mensagem = bll.ExcluirUsuario(Convert.ToInt32(txtcodUsuario.Text.ToString()));
                if (mensagem == true)
                {
                    LimpaCampos();
                    ConfigTela();
                }
                {

                }
               
            }
        }

        private void dgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCadastroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
    }
}
