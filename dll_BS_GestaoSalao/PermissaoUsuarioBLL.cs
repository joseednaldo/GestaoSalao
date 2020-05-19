using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_BS_GestaoSalao
{
    public class PermissaoUsuarioBLL
    {
        public List<DTO_GestaoSalao.AcessoUsuario> RecuperaPermissao(int usuario)
        {
            DAO.AcessoUsuario ListaPermissao = new DAO.AcessoUsuario();
            return ListaPermissao.ListaPermissao(usuario);

        }
    }
}
