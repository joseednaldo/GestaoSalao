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
    public class FaturamentoCRUD
    {
        public long GerarFaturamento(int funcionario, int cliente, List<Servico> ListaServico, DateTime dataMov,int tipopgto ,int sistema =0)
        {
            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                try
                {

                    acessoDados.ComandoSQl = "INSERT INTO tb_faturamento (funcionarioFATURAMENTO,clienteFATURAMENTO,movimentacaoFATURAMENTO,sistemaFATURAMENTO,tipopgtoFATURAMENTO) VALUES  (@funcionarioFATURAMENTO,@clienteFATURAMENTO,@DtaMovimentacao,@sistemaFATURAMENTO,@tipopgtoFATURAMENTO)";
                    acessoDados.Conexao();
                    var cmdFaturamento = acessoDados.ExecutaComando();
                    cmdFaturamento.Parameters.AddWithValue("@funcionarioFATURAMENTO", funcionario);
                    cmdFaturamento.Parameters.AddWithValue("@clienteFATURAMENTO", cliente);
                    cmdFaturamento.Parameters.AddWithValue("@DtaMovimentacao", dataMov);
                    cmdFaturamento.Parameters.AddWithValue("@sistemaFATURAMENTO", sistema);
                    cmdFaturamento.Parameters.AddWithValue("@tipopgtoFATURAMENTO", tipopgto);
                    //cmdFaturamento.Parameters.AddWithValue("@statusFATURAMENTO", 1);// ativo;
                    acessoDados.Open();
                    cmdFaturamento.ExecuteNonQuery();
                    long id_faturamentp = cmdFaturamento.LastInsertedId;
                    acessoDados.Close();


                    // --- Inserindo itens do pedido --- //
                    for (int i = 0; i < ListaServico.Count; i++)
                    {
                        acessoDados.ComandoSQl = "INSERT INTO tb_itens_faturamento (faturamentoITEMFATURAMENTO,servicoITEMFATURAMENTO,valorITEMFATURAMENTO) VALUES  (@idFaturamento,@servicoITEMFATURAMENTO,@valorITEMFATURAMENTO)";
                        acessoDados.Conexao();
                        var cmdItem = acessoDados.ExecutaComando();

                        cmdItem.Parameters.AddWithValue("@idFaturamento", id_faturamentp);
                        cmdItem.Parameters.AddWithValue("@servicoITEMFATURAMENTO", ListaServico[i].Id);
                        cmdItem.Parameters.AddWithValue("@valorITEMFATURAMENTO", ListaServico[i].PrecoSERVICO);
                        acessoDados.Open();
                        cmdItem.ExecuteNonQuery();

                        cmdItem = null;
                    }
                    acessoDados.Close();
                    return id_faturamentp;

                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }
        public DataTable ListaFaturamento(int id_atendente, DateTime dataAtendimento, DateTime dataAtendimentoFim, int filtroFuncionario)
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
                    strSql = "SELECT codigoFATURAMENTO,servicoITEMFATURAMENTO,descricaoSERVICO,(CASE valorITEMFATURAMENTO  WHEN 0 THEN precoSERVICO ELSE valorITEMFATURAMENTO  END) AS valorITEMFATURAMENTO ,nomeFUNCIONARIO ";
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
