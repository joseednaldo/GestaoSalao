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
   public class ClienteCRUD
    {

        public string Cadastrar(Cliente cliente)
        {
            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                try
                {
                    acessoDados.ComandoSQl = "INSERT INTO tb_funcionarios (nomeCLIENTE) VALUES (@NomeFuncionario)";
                    acessoDados.Conexao();
                    var cmd = acessoDados.ExecutaComando();
                    cmd.Parameters.AddWithValue("@NomeFuncionario", cliente.nomeCLIENTE);
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
        public List<Cliente> ListaCliente(int id)
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    List<Cliente> _Funcionario = new List<Cliente>();
                    acessoDados.Conexao();

                    var cmd = acessoDados.ExecutaComando();
                    cmd.CommandText = "SELECT * FROM tb_clientes WHERE codigoCLIENTE = @CODIGO ";
                    cmd.Parameters.AddWithValue("@CODIGO", id);
                    acessoDados.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        _Funcionario.Add(new Cliente()
                        {
                            codigoCLIENTE = Convert.ToInt32(dr["codigoCLIENTE"]),
                            nomeCLIENTE = dr["nomeCLIENTE"].ToString(),

                        });
                    }
                    acessoDados.Close();
                    dr.Close();
                    return _Funcionario;
                }

            }
            catch (Exception )
            {
                throw;

            }

        }
        public List<Cliente> ListaCliente()
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    List<Cliente> ObjFuncionario = new List<Cliente>();

                    acessoDados.Conexao();
                    acessoDados.Open();

                    //Estrutura de tabela 
                    DataTable objDataTable = new DataTable();


                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT codigoCLIENTE,nomeCLIENTE  FROM tb_clientes", acessoDados.con);

                    da.Fill(objDataTable);
                    foreach (DataRow dataRow in objDataTable.Rows)
                    {
                        // List<Servico> ObjServico = new List<Servico>();

                        ObjFuncionario.Add(new Cliente()
                        {
                            codigoCLIENTE = Convert.ToInt32(dataRow["codigoCLIENTE"]),
                            nomeCLIENTE = dataRow["nomeCLIENTE"].ToString(),


                        });

                    }


                    return ObjFuncionario;

                }

            }
            catch (Exception ex)
            {
                throw ex;

            }

        }
        public bool ExcluirCadastro(int id)
        {
            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                try
                {
                    acessoDados.ComandoSQl = "DELETE FROM tb_funcionarios WHERE codigoFUNCIONARIO = @CODIGO ";
                    acessoDados.Conexao();
                    var cmd = acessoDados.ExecutaComando();
                    cmd.Parameters.AddWithValue("@CODIGO", id);
                    acessoDados.Open();
                    cmd.ExecuteNonQuery();
                    acessoDados.Close();
                    return true;
                }
                catch (Exception )
                {
                    acessoDados.Close();
                    return false;
                }

            }
        }

    }
}
