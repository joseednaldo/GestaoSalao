using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_GestaoSalao;
using System.Threading.Tasks;

namespace dll_BS_GestaoSalao
{
   public class LoginBLL
    {
        //public Boolean Acessar(string _Login, string _Senha)
        //{
        //    DAO.LoginCRUD login = new DAO.LoginCRUD();
        //    login.RecuperaConexao();
        //    return login.ValidarUsuario(_Login, _Senha);
        //}

        //public int Acessar(string _Login, string _Senha)

        //{
        //    DAO.LoginCRUD login = new DAO.LoginCRUD();
        //    login.RecuperaConexao();
        //    return login.ValidarUsuario(_Login, _Senha);
        //}

        public Usuario Acessar(string _Login, string _Senha)

        {
            DAO.LoginCRUD login = new DAO.LoginCRUD();
            login.RecuperaConexao();
            return login.ValidarUsuario(_Login, _Senha);
        }



    }
}
