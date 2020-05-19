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
   public  class Listas
    {
        public Listas()
        {
        }
        public List<ListaPedidos> ListaPedidos(int id_atendente,DateTime dataAtendimento, DateTime dataAtendimentoFim,int filtroFuncionario)
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    List<ListaPedidos> ObjPedido = new List<ListaPedidos>();

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
                    strSql = "SELECT codigoFATURAMENTO,servicoITEMFATURAMENTO,descricaoSERVICO,(CASE valorITEMFATURAMENTO  WHEN 0 THEN precoSERVICO ELSE valorITEMFATURAMENTO  END) AS valorITEMFATURAMENTO ,nomeFUNCIONARIO,datacricaoFATURAMENTO ";
                    strSql = strSql + " FROM tb_faturamento  ";
                    strSql = strSql + " INNER  JOIN  tb_itens_faturamento       on faturamentoITEMFATURAMENTO           = codigoFATURAMENTO";
                    strSql = strSql + " INNER  JOIN  tb_servico                 on codigoSERVICO                        = servicoITEMFATURAMENTO";
                    strSql = strSql + " LEFT   JOIN  tb_clientes                on codigoCLIENTE                        = clienteFATURAMENTO";
                    strSql = strSql + " LEFT   JOIN  tb_funcionarios            on codigoFUNCIONARIO                    = funcionarioFATURAMENTO";
                    strSql = strSql + " AND    ativofuncionario = 1";
                    if (filtroFuncionario == 1)
                    {
                        strSql = strSql + " WHERE  funcionarioFATURAMENTO = " + id_atendente;
                        strSql = strSql + " AND    cast(movimentacaoFATURAMENTO as date) >= '" + ano + "/" + mes + "/" + dia + "'";
                        strSql = strSql + " AND    cast(movimentacaoFATURAMENTO as date) <= '" + anofim + "/" + mesfim + "/" + diafim + "'";
                    }
                    else
                    {
                        strSql = strSql + " WHERE    cast(movimentacaoFATURAMENTO as date) >= '" + ano + "/" + mes + "/" + dia + "'";
                        strSql = strSql + " AND    cast(movimentacaoFATURAMENTO as date) <= '" + anofim + "/" + mesfim + "/" + diafim + "'";

                    }
                    strSql = strSql + " AND    canceladoFATURAMENTO = 0";

                    MySqlDataAdapter da = new MySqlDataAdapter(strSql, acessoDados.con);

                    da.Fill(objDataTable);

                    foreach (DataRow dataRow in objDataTable.Rows)
                    {

                        ObjPedido.Add(new ListaPedidos()
                        {

                            codigoPEDIDO= Convert.ToInt32(dataRow["codigoFATURAMENTO"].ToString()),
                            servicoPEDIDO = Convert.ToInt32(dataRow["servicoITEMFATURAMENTO"].ToString()),
                            servicodescrPEDIDO = dataRow["descricaoSERVICO"].ToString(),
                            valorPEDIDO       = Convert.ToDecimal(dataRow["valorITEMFATURAMENTO"]),
                            nomeFUNCIONARIO = dataRow["nomeFUNCIONARIO"].ToString(),
                            datacricaoPEDIDO = Convert.ToDateTime(dataRow["datacricaoFATURAMENTO"]),
                        });

                    }


                    return ObjPedido;

                }

            }
            catch (Exception ex)
            {
     
                throw;

            }

        }
        public void Cancelar(int CodFaturamento)
        {
            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                try
                {


                    acessoDados.ComandoSQl = "UPDATE tb_faturamento  SET canceladoFATURAMENTO=@cancelar WHERE codigoFATURAMENTO = @CODIGO  ";
                    acessoDados.Conexao();
                    var cmd = acessoDados.ExecutaComando();
                    cmd.Parameters.AddWithValue("@CODIGO", CodFaturamento);
                    cmd.Parameters.AddWithValue("@cancelar", 1);
                    acessoDados.Open();
                    cmd.ExecuteNonQuery();
                    acessoDados.Close();

                }
                catch (Exception)
                {

                    // return Uteis.MensagemeError + ex.Message.ToString();
                }

            }
        }
        public List<Pefil> ListaPerfil()
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    List<Pefil> ObjPerfil = new List<Pefil>();

                    acessoDados.Conexao();
                    acessoDados.Open();

                    //Estrutura de tabela 
                    DataTable objDataTable = new DataTable();


                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT codigo_perfil,descricao_perfil FROM tb_perfil", acessoDados.con);

                    da.Fill(objDataTable);
                    foreach (DataRow dataRow in objDataTable.Rows)
                    {

                        ObjPerfil.Add(new Pefil()
                        {
                            codigopefil = Convert.ToInt32(dataRow["codigo_perfil"].ToString()),
                            nomepefil = dataRow["descricao_perfil"].ToString(),
                        });
                    }
                    return ObjPerfil;

                }

            }
            catch (Exception)
            {
                throw;

            }

        }
        public List<Funcionario> ListaFuncionario()
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    List<Funcionario> ObjFunc = new List<Funcionario>();

                    acessoDados.Conexao();
                    acessoDados.Open();

                    //Estrutura de tabela 
                    DataTable objDataTable = new DataTable();

                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT codigoFUNCIONARIO,nomeFUNCIONARIO FROM tb_funcionarios", acessoDados.con);

                    da.Fill(objDataTable);
                    foreach (DataRow dataRow in objDataTable.Rows)
                    {

                        ObjFunc.Add(new Funcionario()
                        {
                            Id = Convert.ToInt32(dataRow["codigoFUNCIONARIO"].ToString()),
                            nomeFuncionario =dataRow["nomeFUNCIONARIO"].ToString(),
                        });
                    }
                    return ObjFunc;

                }

            }
            catch (Exception)
            {
                throw;

            }

        }
        public List<Situacao> ListaSituacao()
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    List<Situacao> ObjSituacao = new List<Situacao>();

                    acessoDados.Conexao();
                    acessoDados.Open();

                    //Estrutura de tabela 
                    DataTable objDataTable = new DataTable();


                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT codigoSTATUS,nomeSTATUS FROM tb_status", acessoDados.con);

                    da.Fill(objDataTable);
                    foreach (DataRow dataRow in objDataTable.Rows)
                    {

                        ObjSituacao.Add(new Situacao()
                        {
                            codigoSTATUS = Convert.ToInt32(dataRow["codigoSTATUS"].ToString()),
                            nomeSTATUS = dataRow["nomeSTATUS"].ToString(),
                        });
                    }
                    return ObjSituacao;

                }

            }
            catch (Exception)
            {
                throw;

            }

        }

    }
}
