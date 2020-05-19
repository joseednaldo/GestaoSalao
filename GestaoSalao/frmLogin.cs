using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using DTO_GestaoSalao;
using dll_BS_GestaoSalao;
using dll_Uteis_GestaoSalao;
using GestaoSalao.Relatorio;

namespace GestaoSalao
{
    public partial class frmLogin : MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, System.EventArgs e)
        {
            LoginBLL bll = new LoginBLL();
            DTO_GestaoSalao.Usuario usuario = new DTO_GestaoSalao.Usuario();
            usuario = bll.Acessar(txtLogin.Text, txtSenha.Text);
            
            Session.Instance.UserID = usuario.codigoUSUARIO;
            Session.Instance.Administrador = usuario.IdpefilUSUARIO;

            if (Session.Instance.UserID == 0)
            {
                MessageBox.Show("Login ou senha inválida !!!", "Acesso restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Text = "";
                txtSenha.Text = "";
                txtLogin.Focus();
            }else
            {
                try
                {
                    frmAgenda agenda = new frmAgenda();
             


                    agenda.ShowDialog();
                }
                catch (System.Exception ex)
                {

                    throw ex;
                }
            }


        }

        private void frmLogin_Load(object sender, System.EventArgs e)
        {
            


        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
    
}
