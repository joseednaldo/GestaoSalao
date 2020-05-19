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
    public class DespesaCRUD
    {
        public string Cadastrar(Despesas despesa)
        {
            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                try
                {
                    acessoDados.ComandoSQl = "INSERT INTO tb_despesas (dataDESPESA,descricaoDESPESA,documentoDESPESA,favorecidoDESPESA,observacaoDESPESA,tipoDESPESA,valorDESPESA) VALUES (@dataDESPESA,@descricaoDESPESA,@documentoDESPESA,@favorecidoDESPESA,@observacaoDESPESA,@tipoDESPESA,@valorDESPESA)";
                    acessoDados.Conexao();
                    var cmd = acessoDados.ExecutaComando();

                    cmd.Parameters.AddWithValue("@dataDESPESA", despesa.dataDESPESA);
                    cmd.Parameters.AddWithValue("@descricaoDESPESA", despesa.descricaoDESPESA);
                    cmd.Parameters.AddWithValue("@documentoDESPESA", despesa.documentoDESPESA);
                    cmd.Parameters.AddWithValue("@favorecidoDESPESA", despesa.favorecido.Id);
                    cmd.Parameters.AddWithValue("@observacaoDESPESA", despesa.observacaoDESPESA);
                    cmd.Parameters.AddWithValue("@tipoDESPESA", despesa.tipoDESPESA.codigoTIPODESPESA);
                    cmd.Parameters.AddWithValue("@valorDESPESA", despesa.valorDESPESA);

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
        public bool AlterarCadastro(Despesas despesa)
        {
            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                try
                {
                    acessoDados.ComandoSQl = "UPDATE tb_despesas  SET dataDESPESA= @dataDESPESA,descricaoDESPESA= @descricaoDESPESA,documentoDESPESA= @documentoDESPESA,observacaoDESPESA= @observacaoDESPESA,tipoDESPESA= @tipoDESPESA,favorecidoDESPESA= @favorecidoDESPESA,situacaoDESPESA=@situacaoDESPESA,valorDESPESA= @valorDESPESA WHERE codigoDESPESA = @CODIGO";
                    acessoDados.Conexao();
                    var cmd = acessoDados.ExecutaComando();

                    cmd.Parameters.AddWithValue("@dataDESPESA", despesa.dataDESPESA);
                    cmd.Parameters.AddWithValue("@descricaoDESPESA", despesa.descricaoDESPESA);
                    cmd.Parameters.AddWithValue("@documentoDESPESA", despesa.documentoDESPESA);
                    cmd.Parameters.AddWithValue("@observacaoDESPESA", despesa.observacaoDESPESA);
                    cmd.Parameters.AddWithValue("@tipoDESPESA", despesa.tipoDESPESA.codigoTIPODESPESA);
                    cmd.Parameters.AddWithValue("@valorDESPESA", despesa.valorDESPESA);
                    cmd.Parameters.AddWithValue("@CODIGO", despesa.codigoDESPESA);
                    cmd.Parameters.AddWithValue("@favorecidoDESPESA", despesa.favorecido.Id);
                    cmd.Parameters.AddWithValue("@situacaoDESPESA", despesa.situacaoDESPESA);

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
        public bool ExcluirCadastro(int idDespesa)
        {
            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                try
                {
                    acessoDados.ComandoSQl = "DELETE FROM tb_despesas WHERE codigoDESPESA = @CODIGO ";
                    acessoDados.Conexao();
                    var cmd = acessoDados.ExecutaComando();
                    cmd.Parameters.AddWithValue("@CODIGO", idDespesa);
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
        public DataTable Despesa(DateTime dataAtendimento, DateTime dataAtendimentoFim, int situacao, int tipoDespesa,int filtroFuncionario=0, int id_atendente = 0)
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                  

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
                    strSql = "SELECT codigoDESPESA,descricaoDESPESA,tipoDESPESA,documentoDESPESA,valorDESPESA,dataDESPESA,observacaoDESPESA";
                    strSql = strSql + ",favorecidoDESPESA,nomeFUNCIONARIO,codigoTIPODESPESA,descricaoTIPODESPESA,(case situacaoDESPESA when 1 then 'Em aberto' when 2 then 'Quitada' end)as situacao,situacaoDESPESA as sitDespesa";
                    strSql = strSql + " FROM tb_despesas  ";
                    strSql = strSql + " LEFT JOIN  tb_funcionarios    on codigoFUNCIONARIO    = favorecidoDESPESA";
                    strSql = strSql + " INNER JOIN  tb_tipo_depesas    on codigoTIPODESPESA    = tipoDESPESA";


                    if (situacao > 0)
                    {
                        strSql = strSql + " AND  situacaoDESPESA = " + situacao;
                    }

                    if (tipoDespesa > 0)
                    {
                        strSql = strSql + " AND  tipoDESPESA = " + tipoDespesa;
                    }


                    if (filtroFuncionario == 1)
                    {
                        strSql = strSql + " WHERE  favorecidoDESPESA = " + id_atendente;
                        strSql = strSql + " AND    cast(dataDESPESA	 as date) >= '" + ano + "/" + mes + "/" + dia + "'";
                        strSql = strSql + " AND    cast(dataDESPESA	 as date) <= '" + anofim + "/" + mesfim + "/" + diafim + "'";
                    }
                    else
                    {
                        strSql = strSql + " WHERE  cast(dataDESPESA	 as date) >= '" + ano + "/" + mes + "/" + dia + "'";
                        strSql = strSql + " AND    cast(dataDESPESA	 as date) <= '" + anofim + "/" + mesfim + "/" + diafim + "'";

                    }

                    strSql = strSql + " order by descricaoTIPODESPESA ";

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
        public List<RelatorioDespesas> ListaDespesa(DateTime dataAtendimento, DateTime dataAtendimentoFim, int situacao, int tipoDespesa, int filtroFuncionario = 0, int id_atendente = 0)
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {


                    List<RelatorioDespesas> lstDespesas = new List<RelatorioDespesas>();

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
                    strSql = "SELECT codigoDESPESA,descricaoDESPESA,tipoDESPESA,documentoDESPESA,valorDESPESA,dataDESPESA,observacaoDESPESA";
                    strSql = strSql + ",favorecidoDESPESA,nomeFUNCIONARIO,codigoTIPODESPESA,descricaoTIPODESPESA,(case situacaoDESPESA when 1 then 'Em aberto' when 2 then 'Quitada' end)as situacao";
                    strSql = strSql + " FROM tb_despesas  ";
                    strSql = strSql + " LEFT JOIN  tb_funcionarios    on codigoFUNCIONARIO    = favorecidoDESPESA";
                    strSql = strSql + " INNER JOIN  tb_tipo_depesas    on codigoTIPODESPESA    = tipoDESPESA";


                    if (situacao > 0)
                    {
                        strSql = strSql + " AND  situacaoDESPESA = " + situacao;
                    }

                    if (tipoDespesa > 0)
                    {
                        strSql = strSql + " AND  tipoDESPESA = " + tipoDespesa;
                    }


                    if (filtroFuncionario == 1)
                    {
                        strSql = strSql + " WHERE  favorecidoDESPESA = " + id_atendente;
                        strSql = strSql + " AND    cast(dataDESPESA	 as date) >= '" + ano + "/" + mes + "/" + dia + "'";
                        strSql = strSql + " AND    cast(dataDESPESA	 as date) <= '" + anofim + "/" + mesfim + "/" + diafim + "'";
                    }
                    else
                    {
                        strSql = strSql + " WHERE  cast(dataDESPESA	 as date) >= '" + ano + "/" + mes + "/" + dia + "'";
                        strSql = strSql + " AND    cast(dataDESPESA	 as date) <= '" + anofim + "/" + mesfim + "/" + diafim + "'";

                    }

                    strSql = strSql + " order by descricaoTIPODESPESA ";

                    MySqlDataAdapter da = new MySqlDataAdapter(strSql, acessoDados.con);

                    da.Fill(objDataTable);



                    foreach (DataRow dataRow in objDataTable.Rows)
                    {

                        lstDespesas.Add(new RelatorioDespesas()
                        {

                            codigoDESPESA= Convert.ToInt32(dataRow["codigoDESPESA"].ToString()),
                            descricaoDESPESA = dataRow["descricaoDESPESA"].ToString(),
                            Despesa = dataRow["descricaoTIPODESPESA"].ToString(),
                            valorDESPESA = Convert.ToDecimal(dataRow["valorDESPESA"]),
                            dataDESPESA = Convert.ToDateTime(dataRow["dataDESPESA"]),
                            situacaoDESPESA=  dataRow["situacao"].ToString(),
                            documentoDESPESA= dataRow["documentoDESPESA"].ToString(),
                            Funcionario = dataRow["nomeFUNCIONARIO"].ToString(),
                            observacaoDESPESA= dataRow["observacaoDESPESA"].ToString(),
                        });

                    }

                    return lstDespesas;

                }

            }
            catch (Exception ex)
            {
                throw;

            }

        }

        public Despesas FindDespesa(int despesa)
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
                    strSql = "SELECT codigoDESPESA,descricaoDESPESA,tipoDESPESA,documentoDESPESA,valorDESPESA,dataDESPESA,observacaoDESPESA";
                    strSql = strSql + ",favorecidoDESPESA,nomeFUNCIONARIO,codigoTIPODESPESA,descricaoTIPODESPESA,situacaoDESPESA as situacao";
                    strSql = strSql + " FROM tb_despesas  ";
                    strSql = strSql + " LEFT JOIN  tb_funcionarios    on codigoFUNCIONARIO    = favorecidoDESPESA";
                    strSql = strSql + " INNER JOIN  tb_tipo_depesas    on codigoTIPODESPESA    = tipoDESPESA";
                    strSql = strSql + " WHERE  codigoDESPESA = " + despesa;

                    MySqlDataAdapter da = new MySqlDataAdapter(strSql, acessoDados.con);
                    Despesas objDespesa = new Despesas();

                    da.Fill(objDataTable);

                    foreach (DataRow dataRow in objDataTable.Rows)
                    {

                        objDespesa.codigoDESPESA = Convert.ToInt32(dataRow["codigoDESPESA"].ToString());
                        objDespesa.descricaoDESPESA = dataRow["descricaoDESPESA"].ToString();
                        objDespesa.documentoDESPESA = dataRow["documentoDESPESA"].ToString();
                        objDespesa.valorDESPESA = Convert.ToDecimal(dataRow["valorDESPESA"]);
                        objDespesa.dataDESPESA = Convert.ToDateTime(dataRow["dataDESPESA"]);
                        objDespesa.situacaoDESPESA = Convert.ToInt32(dataRow["situacao"]);
                        objDespesa.observacaoDESPESA = dataRow["observacaoDESPESA"].ToString();
                        objDespesa.favorecido = new DAO.FuncionarioCRUD().FindFuncionario((Convert.ToInt32(dataRow["favorecidoDESPESA"])));
                        objDespesa.tipoDESPESA = new DAO.TipoDespesaCRUD().FindTipoDespesa((Convert.ToInt32(dataRow["tipoDESPESA"])));

                    };

                    return objDespesa;

                }

            }
            catch (Exception ex)
            {
                throw;

            }


        }

        private Funcionario FincFuncionario()
        {
            throw new NotImplementedException();
        }
    }


}
