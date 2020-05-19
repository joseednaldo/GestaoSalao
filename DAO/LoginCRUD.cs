using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_GestaoSalao;
using MySql.Data.MySqlClient;
using System.Data;
using dll_Uteis_GestaoSalao;

namespace DAO
{
   public class LoginCRUD
    {
        public void RecuperaConexao()
        {
            try
            {

            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                acessoDados.fnLeConfig();
               // acessoDados.con = "";
            }


            }
            catch (Exception)
            {

                throw;
            }

        }
        //public bool ValidarUsuario(string _Login,string _Senha)
        //{
        //    try
        //    {
        //        using (AcessoBancoDados acessoDados = new AcessoBancoDados())
        //        {

        //            acessoDados.Conexao();
                    
        //            var cmd = acessoDados.ExecutaComando();
        //            cmd.CommandText = "SELECT * FROM tb_usuarios WHERE loginUSUARIO = @Login AND senhaUSUARIO = @senha";
        //            cmd.Parameters.AddWithValue("@Login", _Login);
        //            cmd.Parameters.AddWithValue("@senha", _Senha);
        //            acessoDados.Open();

        //            var result = cmd.ExecuteScalar();
        //            if (result != null)
        //            {
        //                return true;
        //            }else
        //            {
        //                return false;
        //            }

        //        }

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        public int RecuperaPefil(int usuario)
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {

                    acessoDados.Conexao();

                    var cmd = acessoDados.ExecutaComando();
                    var sql = "SELECT tipo_perfil FROM tb_usuarios inner join tb_perfil on tb_perfil.codigo_perfil = tb_usuarios.perfilUSUARIO";
                    sql = sql + " WHERE codigoUSUARIO = @usuario ";
                    cmd.CommandText = sql;
                    //cmd.CommandText = "SELECT perfilUSUARIO FROM tb_usuarios WHERE codigoUSUARIO = @usuario ";

                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    acessoDados.Open();

                    var result = cmd.ExecuteScalar();

                    if (result == null)
                        result = 0;

                    if ((int)result != 0)
                    {
                        return (int)result;
                    }
                    else
                    {
                        return 0;
                    }

                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public int od_ValidarUsuario(string _Login, string _Senha)
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {

                    acessoDados.Conexao();

                    var cmd = acessoDados.ExecutaComando();
                    cmd.CommandText = "SELECT * FROM tb_usuarios WHERE UPPER(loginUSUARIO) = @Login AND senhaUSUARIO = @senha";
                    cmd.Parameters.AddWithValue("@Login",_Login.ToUpper());
                    cmd.Parameters.AddWithValue("@senha", _Senha.ToUpper());
                    acessoDados.Open();

                    var result = cmd.ExecuteScalar();

                    if (result == null)
                        result = 0;

                    if ((int)result != 0)
                    {
                        return (int)result;
                    }
                    else
                    {
                        return 0;
                    }

                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public int ValidarUsuario(int perfilUsuario)
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {

                    acessoDados.Conexao();

                    var cmd = acessoDados.ExecutaComando();
                    cmd.CommandText = "SELECT * FROM tb_usuarios WHERE perfilUSUARIO = @perfilUsuario and grupoUSUARIO=1";
                    cmd.Parameters.AddWithValue("@perfilUsuario", perfilUsuario);
                    acessoDados.Open();

                    var result = cmd.ExecuteScalar();

                    if (result == null)
                        result = 0;

                    if ((int)result != 0)
                    {
                        return (int)result;
                    }
                    else
                    {
                        return 0;
                    }

                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Usuario ValidarUsuario(string _Login, string _Senha)
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {

                    DTO_GestaoSalao.Usuario usuario = new DTO_GestaoSalao.Usuario();
                    acessoDados.Conexao();

                    var cmd = acessoDados.ExecutaComando();
                    cmd.CommandText = "SELECT * FROM tb_usuarios WHERE UPPER(loginUSUARIO) = @Login AND senhaUSUARIO = @senha";
                    cmd.Parameters.AddWithValue("@Login", _Login.ToUpper());
                    cmd.Parameters.AddWithValue("@senha", _Senha.ToUpper());
                    acessoDados.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {

                        usuario.codigoUSUARIO = Convert.ToInt32(dr["codigoUSUARIO"]);
                        usuario.loginUSUARIO = dr["loginUSUARIO"].ToString();
                        //usuario.senhaUSUARIO = dr["senhaUSUARIO"].ToString();
                       // usuario.funcionarioUSUARIO.Id = Convert.ToInt32(dr["funcionarioUSUARIO"]);
                        usuario.IdpefilUSUARIO = Convert.ToInt32(dr["perfilUSUARIO"]);
                    }
                    acessoDados.Close();
                    dr.Close();
                    return usuario;


                }

            }
            catch (Exception ex)
            {
                var teste = ex.Message.ToString();
                throw ex;
            }
        }
    }
}
