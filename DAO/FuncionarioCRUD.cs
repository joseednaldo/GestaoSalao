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
    public class  FuncionarioCRUD 
    {

        public  string Cadastrar(Funcionario funcionario)
        {
            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                try
                {
                    acessoDados.ComandoSQl = "INSERT INTO tb_funcionarios (nomeFUNCIONARIO,fone1FUNCIONARIO,fone2FUNCIONARIO,ativoFUNCIONARIO,cpfFUNCIONARIO) VALUES (@NomeFuncionario,@fone1,@fone2,@Ativo,@Cpf)";
                    acessoDados.Conexao();
                    var cmd = acessoDados.ExecutaComando();
                    cmd.Parameters.AddWithValue("@NomeFuncionario", funcionario.nomeFuncionario);
                    cmd.Parameters.AddWithValue("@fone1", funcionario.fone1);
                    cmd.Parameters.AddWithValue("@fone2", funcionario.fone2);
                    cmd.Parameters.AddWithValue("@Ativo", funcionario.ativo == true ? 1 :  0 );
                    cmd.Parameters.AddWithValue("@Cpf", funcionario.cpf);
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
        public  List<Funcionario> Consulta(int id)
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    List<Funcionario> _Funcionario = new List<Funcionario>();
                    acessoDados.Conexao();

                    var cmd = acessoDados.ExecutaComando();
                    cmd.CommandText = "SELECT * FROM tb_funcionarios WHERE codigoFUNCIONARIO = @CODIGO ";
                    cmd.Parameters.AddWithValue("@CODIGO", id);
                    acessoDados.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        _Funcionario.Add(new Funcionario()
                        {
                            Id = Convert.ToInt32(dr["codigoFUNCIONARIO"]),
                            nomeFuncionario= dr["nomeFUNCIONARIO"].ToString(),
                            fone1 =dr["fone1FUNCIONARIO"].ToString(),
                            fone2 = dr["fone2FUNCIONARIO"].ToString(),
                            ativo = Convert.ToBoolean( dr["ativoFUNCIONARIO"])
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
        public  List<Funcionario> Listafuncionario()
        {
            try
            {
                //aqui
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    List<Funcionario> ObjFuncionario = new List<Funcionario>();

                    acessoDados.Conexao();
                    acessoDados.Open();
                  

                    //Estrutura de tabela 
                    DataTable objDataTable = new DataTable();


                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT codigoFUNCIONARIO,nomeFUNCIONARIO,cpfFUNCIONARIO,fone1FUNCIONARIO,fone2FUNCIONARIO,ativoFUNCIONARIO FROM tb_funcionarios where nomeFUNCIONARIO not in ('Atendente padrão')", acessoDados.con);

                    da.Fill(objDataTable);
                    foreach (DataRow dataRow in objDataTable.Rows)
                    {
                        // List<Servico> ObjServico = new List<Servico>();

                        ObjFuncionario.Add(new Funcionario()
                        {
                            Id = Convert.ToInt32(dataRow["codigoFUNCIONARIO"]),
                            nomeFuncionario = Convert.ToInt32(dataRow["codigoFUNCIONARIO"].ToString()) + "-" + dataRow["nomeFUNCIONARIO"].ToString(),//dataRow["nomeFUNCIONARIO"].ToString(),
                            cpf = dataRow["cpfFUNCIONARIO"].ToString(),
                            fone1 = dataRow["fone1FUNCIONARIO"].ToString(),
                            fone2 = dataRow["fone2FUNCIONARIO"].ToString(),
                           ativo = Convert.ToBoolean(dataRow["ativoFUNCIONARIO"])

                        });

                    }


                    return ObjFuncionario;

                }

            }
            catch (Exception )
            {
                throw;

            }

        }
        public string AlterarCadastro(Funcionario funcionario)
        {
            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                try
                {
                    acessoDados.ComandoSQl = "UPDATE tb_funcionarios  SET nomeFUNCIONARIO= @nomeFuncionario, fone1FUNCIONARIO = @fone1FUNCIONARIO, fone2FUNCIONARIO = @fone2FUNCIONARIO, ativoFUNCIONARIO = @ativoFUNCIONARIO,cpfFUNCIONARIO = @cpfFUNCIONARIO  WHERE codigoFUNCIONARIO = @CODIGO ";
                    acessoDados.Conexao();
                    var cmd = acessoDados.ExecutaComando();
                    cmd.Parameters.AddWithValue("@nomeFuncionario", funcionario.nomeFuncionario);
                    cmd.Parameters.AddWithValue("@fone1FUNCIONARIO", funcionario.fone1 );
                    cmd.Parameters.AddWithValue("@fone2FUNCIONARIO", funcionario.fone2);
                    cmd.Parameters.AddWithValue("@cpfFUNCIONARIO", funcionario.cpf);
                    cmd.Parameters.AddWithValue("@ativoFUNCIONARIO", funcionario.ativo==true ? 1 : 0 );
                    cmd.Parameters.AddWithValue("@CODIGO", funcionario.Id);
                    acessoDados.Open();
                    cmd.ExecuteNonQuery();
                    acessoDados.Close();
                    return "OK";
                }
                catch (Exception ex )
                {
                    
                    return "erro";
                }

            }
        }
        public  bool ExcluirCadastro(int id)
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
        public  List<Funcionario> ListafuncionarioSemID()
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    List<Funcionario> ObjFuncionario = new List<Funcionario>();

                    acessoDados.Conexao();
                    acessoDados.Open();

                    //Estrutura de tabela 
                    DataTable objDataTable = new DataTable();


                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT codigoFUNCIONARIO,nomeFUNCIONARIO,cpfFUNCIONARIO,fone1FUNCIONARIO,fone2FUNCIONARIO,ativoFUNCIONARIO FROM tb_funcionarios where ativoFUNCIONARIO  = 1 order by nomeFUNCIONARIO asc", acessoDados.con);

                    da.Fill(objDataTable);
                    foreach (DataRow dataRow in objDataTable.Rows)
                    {
                        // List<Servico> ObjServico = new List<Servico>();

                        ObjFuncionario.Add(new Funcionario()
                        {
                            Id = Convert.ToInt32(dataRow["codigoFUNCIONARIO"]),
                            nomeFuncionario =  dataRow["nomeFUNCIONARIO"].ToString(),//dataRow["nomeFUNCIONARIO"].ToString(),
                            cpf = dataRow["cpfFUNCIONARIO"].ToString(),
                            fone1 = dataRow["fone1FUNCIONARIO"].ToString(),
                            fone2 = dataRow["fone2FUNCIONARIO"].ToString(),
                           ativo = Convert.ToBoolean(dataRow["ativoFUNCIONARIO"])

                        });

                    }


                    return ObjFuncionario;

                }

            }
            catch (Exception )
            {
                throw;

            }

        }

        public Funcionario FindFuncionario(int id)
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
                    strSql = "SELECT * FROM tb_funcionarios ";
                    strSql = strSql + "  WHERE codigoFUNCIONARIO = " + id;

                    MySqlDataAdapter da = new MySqlDataAdapter(strSql, acessoDados.con);
                    Funcionario _Funcionario = new Funcionario();

                    da.Fill(objDataTable);

                    foreach (DataRow dr in objDataTable.Rows)
                    {
                        _Funcionario.Id = Convert.ToInt32(dr["codigoFUNCIONARIO"]);
                        _Funcionario.nomeFuncionario = dr["nomeFUNCIONARIO"].ToString();
                        _Funcionario.fone1 = dr["fone1FUNCIONARIO"].ToString();
                        _Funcionario.fone2 = dr["fone2FUNCIONARIO"].ToString();
                        _Funcionario.ativo = Convert.ToBoolean(dr["ativoFUNCIONARIO"]);

                    };
                    acessoDados.Close();
                    return _Funcionario;

                }

            }
            catch (Exception)
            {
                throw;

            }

        }
    }
}
