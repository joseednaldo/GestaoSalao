using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO_GestaoSalao;
using System.Data;

namespace dll_BS_GestaoSalao
{
    public  class UsuarioBLL
    {
        public UsuarioBLL()
        {
        }
        public string CadastrarUsuario(Usuario usuario)
        {
            DAO.UsuarioCRUD CadastraUsuario = new DAO.UsuarioCRUD();
            string mensagem = CadastraUsuario.Cadastrar(usuario);
            return mensagem;
        }
        public bool ExcluirUsuario(int id)
        {
            DAO.UsuarioCRUD ExcluirUsuario = new DAO.UsuarioCRUD();
            bool booExclusao = ExcluirUsuario.ExcluirCadastro(id);
            return booExclusao;

        }
        public DataTable ListaUsuario()
        {
            DAO.UsuarioCRUD usuario = new DAO.UsuarioCRUD();
            return usuario.ListaUsuarios();

        }
        public List<Usuario> ListA()
        {
            DAO.UsuarioCRUD usuario = new DAO.UsuarioCRUD();
            return usuario.Lista();

        }
        public string AlterarUsuario(Usuario usuario)
        {
            DAO.UsuarioCRUD AlterarUsuario = new DAO.UsuarioCRUD();
            string mensagem = AlterarUsuario.AlterarCadastro(usuario);
            return mensagem;

        }

    }
}
