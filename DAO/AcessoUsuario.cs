using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AcessoUsuario
    {
        private StringBuilder strQuery { get; set; }

        public List<DTO_GestaoSalao.AcessoUsuario> ListaPermissao(int codigoUsuario)
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    List<DTO_GestaoSalao.AcessoUsuario> objPermissaoUsuario = new List<DTO_GestaoSalao.AcessoUsuario>();


                    //Recupera o pefil do usuario logado
                    DAO.LoginCRUD login = new DAO.LoginCRUD();
                    var perfilUsuario = login.RecuperaPefil(codigoUsuario);

                    //Recupera o Id do pefil (do grupo)
                    var codUsuarioPefil = login.ValidarUsuario(perfilUsuario);


                    acessoDados.Conexao();
                    acessoDados.Open();

                    //Estrutura de tabela 
                    DataTable objDataTable = new DataTable();

                    string strSql = "SELECT * from tb_acesso_usuario where usuarioACESSOUSUARIO = " + codUsuarioPefil;
                    MySqlDataAdapter da = new MySqlDataAdapter(strSql, acessoDados.con);

                    da.Fill(objDataTable);
                    foreach (DataRow dataRow in objDataTable.Rows)
                    {

                        objPermissaoUsuario.Add(new DTO_GestaoSalao.AcessoUsuario()
                        {
                            
                            codigoACESSOUSUARIO = Convert.ToInt32(dataRow["codigoACESSOUSUARIO"]),
                            usuarioACESSOUSUARIO = Convert.ToInt32(dataRow["usuarioACESSOUSUARIO"]),
                            statusACESSOUSUARIO = Convert.ToInt32(dataRow["statusACESSOUSUARIO"]),
                            Componente  = new DAO.Componente().Find(Convert.ToInt32(dataRow["compACESSOUSUARIO"])),
                            Modulo = new DAO.Modulo().Find(Convert.ToInt32(dataRow["modACESSOUSUARIO"])),

                        });

                    }

                    //teste
                    return objPermissaoUsuario;

                }

            }
            catch (Exception)
            {
                throw;

            }

        }


    }


}
