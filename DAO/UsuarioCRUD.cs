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
    public class UsuarioCRUD
    {
        public string Cadastrar(Usuario usuario)
        {
            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                try
                {
                    acessoDados.ComandoSQl = "INSERT INTO tb_usuarios (loginUSUARIO,senhaUSUARIO,funcionarioUSUARIO,perfilUSUARIO,situacaoUSUARIO,redefinirSenha) VALUES (@loginUSUARIO,@senhaUSUARIO,@funcionarioUSUARIO,@perfilUSUARIO,@situacaoUSUARIO,@redigitarUSUARIO)";
                    acessoDados.Conexao();
                    var cmd = acessoDados.ExecutaComando();

                    cmd.Parameters.AddWithValue("@loginUSUARIO", usuario.loginUSUARIO);
                    cmd.Parameters.AddWithValue("@senhaUSUARIO", usuario.senhaUSUARIO);
                    cmd.Parameters.AddWithValue("@redigitarUSUARIO", usuario.redigitarUSUARIO);
                    cmd.Parameters.AddWithValue("@funcionarioUSUARIO", usuario.funcionarioUSUARIO.Id);
                    cmd.Parameters.AddWithValue("@perfilUSUARIO", usuario.pefilUSUARIO.codigopefil);
                    cmd.Parameters.AddWithValue("@situacaoUSUARIO", usuario.situacaoUSUARIO.codigoSTATUS);

                    acessoDados.Open();
                    cmd.ExecuteNonQuery();
                    acessoDados.Close();
                    return Uteis.MensagemeOK;
                }
                catch (Exception ex)
                {

                    return Uteis.MensagemeError + ex.Message.ToString();
                }

            }
        }
        public string AlterarCadastro(Usuario usuario)
        {
            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                try
                {
                    
                    acessoDados.ComandoSQl = "UPDATE tb_usuarios  SET loginUSUARIO= @loginUSUARIO,redefinirSenha= @redefinirSenha,senhaUSUARIO= @senhaUSUARIO,funcionarioUSUARIO= @funcionarioUSUARIO,perfilUSUARIO= @perfilUSUARIO,situacaoUSUARIO= @situacaoUSUARIO WHERE codigoUSUARIO = @CODIGO";
                    acessoDados.Conexao();
                    var cmd = acessoDados.ExecutaComando();

                    cmd.Parameters.AddWithValue("@loginUSUARIO", usuario.loginUSUARIO);
                    cmd.Parameters.AddWithValue("@senhaUSUARIO", usuario.senhaUSUARIO);
                    cmd.Parameters.AddWithValue("@redefinirSenha", usuario.redigitarUSUARIO);
                    cmd.Parameters.AddWithValue("@funcionarioUSUARIO", usuario.funcionarioUSUARIO.Id);
                    cmd.Parameters.AddWithValue("@perfilUSUARIO", usuario.pefilUSUARIO.codigopefil);
                    cmd.Parameters.AddWithValue("@situacaoUSUARIO", usuario.situacaoUSUARIO.codigoSTATUS);

                    cmd.Parameters.AddWithValue("@CODIGO", usuario.codigoUSUARIO);
                    acessoDados.Open();
                    cmd.ExecuteNonQuery();
                    acessoDados.Close();
                    return Uteis.MensagemeOK;
                }
                catch (Exception)
                {

                    return "";
                }

            }
        }
        public bool ExcluirCadastro(int idUsuario)
        {
            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                try
                {
                    acessoDados.ComandoSQl = "DELETE FROM tb_usuarios WHERE codigoUSUARIO = @CODIGO ";
                    acessoDados.Conexao();
                    var cmd = acessoDados.ExecutaComando();
                    cmd.Parameters.AddWithValue("@CODIGO", idUsuario);
                    acessoDados.Open();
                    cmd.ExecuteNonQuery();
                    acessoDados.Close();
                    return true;
                }
                catch (Exception)
                {
                    acessoDados.Close();
                    return false;
                }

            }
        }
        public DataTable ListaUsuarios()
        {

            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {


                    acessoDados.Conexao();
                    acessoDados.Open();

                    //Estrutura de tabela 
                    DataTable objDataTable = new DataTable();

                    string strSql = "";
                    strSql = "SELECT   codigoUSUARIO,loginUSUARIO,nomeFUNCIONARIO,";
                    strSql = strSql + "nomeSTATUS,descricao_perfil";
                    strSql = strSql + " FROM tb_usuarios  ";
                    strSql = strSql + " LEFT   JOIN  tb_perfil           on codigo_perfil                    = perfilUSUARIO";
                    strSql = strSql + " LEFT   JOIN  tb_status           on codigoSTATUS                     = situacaoUSUARIO";
                    strSql = strSql + " LEFT   JOIN  tb_funcionarios     on codigoFUNCIONARIO            = funcionarioUSUARIO";
                   strSql = strSql + "  WHERE     situacaoUSUARIO = 1 and grupoUSUARIO = 0";

                    MySqlDataAdapter da = new MySqlDataAdapter(strSql, acessoDados.con);

                    da.Fill(objDataTable);
                    return objDataTable;

                }

            }
            catch (Exception ex)
            {
                throw ex;

            }

        }
        public  List<Usuario> Lista()
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    List<Usuario> ObjUsuario = new List<Usuario>();

                    acessoDados.Conexao();
                    acessoDados.Open();

                    //Estrutura de tabela 
                    DataTable objDataTable = new DataTable();


                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT codigoUSUARIO,loginUSUARIO,senhaUSUARIO,funcionarioUSUARIO,perfilUSUARIO,situacaoUSUARIO,redefinirSenha FROM tb_usuarios", acessoDados.con);

                    da.Fill(objDataTable);
                    foreach (DataRow dataRow in objDataTable.Rows)
                    {

                        ObjUsuario.Add(new Usuario()
                        {

                            codigoUSUARIO = Convert.ToInt32(dataRow["codigoUSUARIO"].ToString()),
                            loginUSUARIO = dataRow["loginUSUARIO"].ToString(),

                        });

                    }


                    return ObjUsuario;

                }

            }
            catch (Exception)
            {
                throw;

            }

        }

    }
}
