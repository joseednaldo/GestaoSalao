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
    public class ValeCRUD 
    {
        public ValeCRUD() { }

        public string Cadastrar(Vale vale)
        {
            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                try
                {
                    acessoDados.ComandoSQl = "INSERT INTO tb_vale (descricaoVale,valorVale,dataVale,funcionarioVale) VALUES (@descricao,@valor,@DataVale,@Funcionario)";
                    acessoDados.Conexao();
                    var cmd = acessoDados.ExecutaComando();
                    cmd.Parameters.AddWithValue("@descricao",vale.descricaoVale);
                    cmd.Parameters.AddWithValue("@valor", vale.valorVale);
                    cmd.Parameters.AddWithValue("@DataVale", vale.dataVale);
                    cmd.Parameters.AddWithValue("@Funcionario", vale.funcionarioVale.Id);
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
        public bool AlterarCadastro(Vale vale)
        {
            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                try
                {
                    acessoDados.ComandoSQl = "UPDATE tb_Vale  SET descricaoVale= @descricao,  valorVale = @valor dataVale = @DataVale  WHERE codigoVALE = @CODIGO ";
                    acessoDados.Conexao();
                    var cmd = acessoDados.ExecutaComando();
                    cmd.Parameters.AddWithValue("@descricao", vale.descricaoVale);
                    cmd.Parameters.AddWithValue("@valor", vale.valorVale);
                    cmd.Parameters.AddWithValue("@DataVale", vale.dataVale);
                    cmd.Parameters.AddWithValue("@CODIGO", vale.funcionarioVale);
                    acessoDados.Open();
                    cmd.ExecuteNonQuery();
                    acessoDados.Close();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }

            }
        }
        public bool ExcluirCadastro(int idVale)
        {
            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                try
                {
                    acessoDados.ComandoSQl = "DELETE FROM tb_vale WHERE codigoVALE = @CODIGO ";
                    acessoDados.Conexao();
                    var cmd = acessoDados.ExecutaComando();
                    cmd.Parameters.AddWithValue("@CODIGO", idVale);
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
        public List<Vale> ListaVale(int id_atendente, DateTime dataAtendimento, DateTime dataAtendimentoFim, int filtroFuncionario, int id_vale)
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    List<Vale> ObjVale = new List<Vale>();
                    
                    acessoDados.Conexao();
                    acessoDados.Open();

                    //Estrutura de tabela 
                    DataTable objDataTable = new DataTable();

                    string ano, dia, mes;
                    string anofim, diafim, mesfim;

                    //trata da inicioda pesquisa
                    ano = dataAtendimento.ToString().Substring(6, 4);
                    dia = dataAtendimento.ToString().Substring(0, 2);
                    mes = dataAtendimento.ToString().Substring(3, 2);

                    //trata da fim da pesquisa
                    anofim = dataAtendimentoFim.ToString().Substring(6, 4);
                    diafim = dataAtendimentoFim.ToString().Substring(0, 2);
                    mesfim = dataAtendimentoFim.ToString().Substring(3, 2);


                    string strSql = "";
                    strSql = "SELECT codigoVALE,descricaoVALE,valorVALE,dataVALE,funcionarioVALE,nomeFUNCIONARIO";
                    strSql = strSql + " FROM tb_vale  ";
                    strSql = strSql + " INNER JOIN  tb_funcionarios    on codigoFUNCIONARIO    = funcionarioVALE";
                  //  strSql = strSql + " AND  ativofuncionario = 0";
                    if (filtroFuncionario == 1)
                    {
                        strSql = strSql + " WHERE  funcionarioVALE = " + id_atendente;
                        strSql = strSql + " AND    cast(dataVALE as date) >= '" + ano + "/" + mes + "/" + dia + "'";
                        strSql = strSql + " AND    cast(dataVALE as date) <= '" + anofim + "/" + mesfim + "/" + diafim + "'";
                    }
                    else
                    {
                        strSql = strSql + " WHERE  cast(dataVALE as date) >= '" + ano + "/" + mes + "/" + dia + "'";
                        strSql = strSql + " AND    cast(dataVALE as date) <= '" + anofim + "/" + mesfim + "/" + diafim + "'";

                    }

                    if (id_vale != 0)
                    {
                        strSql = strSql + " AND  codigoVALE = " + id_vale;
                    }
                  

                    MySqlDataAdapter da = new MySqlDataAdapter(strSql, acessoDados.con);

                    da.Fill(objDataTable);
                    foreach (DataRow dataRow in objDataTable.Rows)
                    {

                        ObjVale.Add(new Vale()
                        {
                            codigoVALE = Convert.ToInt32(dataRow["codigoVALE"].ToString()),
                            descricaoVale = dataRow["descricaoVALE"].ToString(),
                            valorVale = Convert.ToDecimal(dataRow["valorVALE"]),
                            IdfuncionarioVale = Convert.ToInt32(dataRow["funcionarioVALE"]),
                            Nomefuncionario = dataRow["nomeFUNCIONARIO"].ToString(),
                            dataVale = Convert.ToDateTime(dataRow["dataVale"]),

                        });

                    }


                    return ObjVale;

                }

            }
            catch (Exception)
            {
                throw;

            }

        }

        public List<Vale> ListaVale(int funcionario)
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    List<Vale> ObjVale = new List<Vale>();

                    acessoDados.Conexao();
                    acessoDados.Open();

                    //Estrutura de tabela 
                    DataTable objDataTable = new DataTable();

                    string strSql = "";
                    strSql = "SELECT codigoVALE,descricaoVALE,valorVALE,dataVALE,funcionarioVALE,nomeFUNCIONARIO";
                    strSql = strSql + " FROM tb_vale  ";
                    strSql = strSql + " INNER JOIN  tb_funcionarios    on codigoFUNCIONARIO    = funcionarioVALE";          
                    strSql = strSql + " WHERE  funcionarioVALE = " + funcionario;
                    strSql = strSql + " order by dataVALE desc  limit 5";


                    MySqlDataAdapter da = new MySqlDataAdapter(strSql, acessoDados.con);

                    da.Fill(objDataTable);
                    foreach (DataRow dataRow in objDataTable.Rows)
                    {

                        ObjVale.Add(new Vale()
                        {
                            codigoVALE = Convert.ToInt32(dataRow["codigoVALE"].ToString()),
                            descricaoVale = dataRow["descricaoVALE"].ToString(),
                            valorVale = Convert.ToDecimal(dataRow["valorVALE"]),
                            IdfuncionarioVale = Convert.ToInt32(dataRow["funcionarioVALE"]),
                           // Nomefuncionario = dataRow["nomeFUNCIONARIO"].ToString(),
                            dataVale = Convert.ToDateTime(dataRow["dataVale"]),

                        });

                    }

                    return ObjVale;

                }

            }
            catch (Exception)
            {
                throw;

            }

        }

        public DataTable Vale(int id_atendente, DateTime dataAtendimento, DateTime dataAtendimentoFim, int filtroFuncionario)
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    List<Vale> ObjVale = new List<Vale>();

                    acessoDados.Conexao();
                    acessoDados.Open();

                    //Estrutura de tabela 
                    DataTable objDataTable = new DataTable();

                    string ano, dia, mes;
                    string anofim, diafim, mesfim;

                    //trata da inicioda pesquisa
                    ano = dataAtendimento.ToString().Substring(6, 4);
                    dia = dataAtendimento.ToString().Substring(0, 2);
                    mes = dataAtendimento.ToString().Substring(3, 2);

                    //trata da fim da pesquisa
                    anofim = dataAtendimentoFim.ToString().Substring(6, 4);
                    diafim = dataAtendimentoFim.ToString().Substring(0, 2);
                    mesfim = dataAtendimentoFim.ToString().Substring(3, 2);


                    string strSql = "";
                    strSql = "SELECT codigoVALE,descricaoVALE ,valorVALE,dataVALE,nomefuncionario,funcionarioVALE";
                    strSql = strSql + " FROM tb_vale  ";
                    strSql = strSql + " INNER JOIN  tb_funcionarios    on codigoFUNCIONARIO    = funcionarioVALE";
                    //  strSql = strSql + " AND  ativofuncionario = 0";
                    if (filtroFuncionario == 1)
                    {
                        strSql = strSql + " WHERE  funcionarioVALE = " + id_atendente;
                        strSql = strSql + " AND    cast(dataVALE as date) >= '" + ano + "/" + mes + "/" + dia + "'";
                        strSql = strSql + " AND    cast(dataVALE as date) <= '" + anofim + "/" + mesfim + "/" + diafim + "'";
                    }
                    else
                    {
                        strSql = strSql + " WHERE  cast(dataVALE as date) >= '" + ano + "/" + mes + "/" + dia + "'";
                        strSql = strSql + " AND    cast(dataVALE as date) <= '" + anofim + "/" + mesfim + "/" + diafim + "'";

                    }

                    MySqlDataAdapter da = new MySqlDataAdapter(strSql, acessoDados.con);

                    da.Fill(objDataTable);
                    return objDataTable;

                }

            }
            catch (Exception)
            {
                throw;

            }

        }


    }
}
