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
   public class AgendamentoCRUD
    {
        public  List<Agendamento> ListaParametro()
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    List<Agendamento> ObjAgenda = new List<Agendamento>();

                    acessoDados.Conexao();
                    acessoDados.Open();

                    //Estrutura de tabela 
                    DataTable objDataTable = new DataTable();


                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT descricaoPARAMETRO,valorPARAMETRO from tb_parametros_agendamento", acessoDados.con);

                    da.Fill(objDataTable);
                    foreach (DataRow dataRow in objDataTable.Rows)
                    {

                        ObjAgenda.Add(new Agendamento()
                        {
                            descricaoPARAMETRO = dataRow["descricaoPARAMETRO"].ToString(),
                            valorPARAMETRO = dataRow["valorPARAMETRO"].ToString()

                        });

                    }


                    return ObjAgenda;

                }

            }
            catch (Exception)
            {
                throw;

            }

        }
        public List<Agendamento> ListaAgendamento(DateTime dataagenda)
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    List<Agendamento> ObjAgenda = new List<Agendamento>();

                    acessoDados.Conexao();
                    acessoDados.Open();

                    //Estrutura de tabela 
                    DataTable objDataTable = new DataTable();

                    string ano, dia, mes;

                    ano= dataagenda.ToString().Substring(6, 4);
                    dia = dataagenda.ToString().Substring(0,2);
                    mes = dataagenda.ToString().Substring(3, 2);


                    string strSql="";
                    strSql = "SELECT coalesce(codigoAGENDAMENTO,0)as codigoAGENDAMENTO,coalesce(horarioHORARIO,'Vaga')as horarioHORARIO,coalesce(nomeFUNCIONARIO,'')as nomeFUNCIONARIO,coalesce(nomeCLIENTE,'')as nomeCLIENTE,coalesce(descricaoSERVICO,'')as descricaoSERVICO,coalesce(codigoSERVICO,0)as codigoSERVICO,COALESCE(colunaAGENDAMENTO,0)AS colunaAGENDAMENTO,COALESCE(linhaAGENDAMENTO,0)AS linhaAGENDAMENTO,codigoFUNCIONARIO,canceladoAGENDAMENTO,nomeclienteAGENDAMENTO,ativofuncionario";
                    strSql = strSql + " FROM tb_funcionarios   ";
                    strSql = strSql + " left join  tb_agendamento on codigoFUNCIONARIO = funcionarioAGENDAMENTO";
                    strSql = strSql + " left join  tb_horarios on  codigoHORARIO = horaAGENDAMENTO";
                    strSql = strSql + " left join  tb_clientes on codigoCLIENTE = clienteAGENDAMENTO";
                    strSql = strSql + " left join  tb_servico on codigoSERVICO = servicoAGENDAMENTO";
                    strSql = strSql + "  WHERE  cast(diaAGENDAMENTO as date) = '" + ano+"/" + mes +  "/" + dia +"'" ;
                    strSql = strSql + " and ativofuncionario = 1 and faturadoAGENDAMENTO = 0";

                    MySqlDataAdapter da = new MySqlDataAdapter(strSql, acessoDados.con);

                    da.Fill(objDataTable);
                    foreach (DataRow dataRow in objDataTable.Rows)
                    {

                        ObjAgenda.Add(new Agendamento()
                        {

                        codigoSERVICO = Convert.ToInt32(dataRow["codigoSERVICO"].ToString()),
                        horarioHORARIO = dataRow["horarioHORARIO"].ToString(),
                        codigoAGENDAMENTO = Convert.ToInt32(dataRow["codigoAGENDAMENTO"]),
                        descricaoSERVICO = dataRow["descricaoSERVICO"].ToString(),
                        nomeFUNCIONARIO = Convert.ToInt32(dataRow["codigoFUNCIONARIO"].ToString()) + "-" + dataRow["nomeFUNCIONARIO"].ToString(),
                        nomeCLIENTE = dataRow["nomeCLIENTE"].ToString(),
                        canceladoAGENDAMENTO = Convert.ToInt32(dataRow["canceladoAGENDAMENTO"].ToString()),
                        linhaAGENDAMENTO = Convert.ToInt32(dataRow["linhaAGENDAMENTO"].ToString()),
                        colunaAGENDAMENTO = Convert.ToInt32(dataRow["colunaAGENDAMENTO"].ToString()),
                        //funcionarioAGENDAMENTO = Convert.nomeclienteAGENDAMENTO(dataRow["codigoFUNCIONARIO"].ToString())
                       nomeclienteAGENDAMENTO = dataRow["nomeclienteAGENDAMENTO"].ToString(),


                        });

                    }


                    return ObjAgenda;

                }

            }
            catch (Exception )
            {
                throw;

            }

        }
        public List<Horario> ListaHorario()
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    List<Horario> ObjAgenda = new List<Horario>();

                    acessoDados.Conexao();
                    acessoDados.Open();

                    //Estrutura de tabela 
                    DataTable objDataTable = new DataTable();


                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT codigoHORARIO,horarioHORARIO from tb_horarios", acessoDados.con);

                    da.Fill(objDataTable);
                    foreach (DataRow dataRow in objDataTable.Rows)
                    {

                        ObjAgenda.Add(new Horario()
                        {
                            codigoHORARIO = Convert.ToInt32(dataRow["codigoHORARIO"].ToString()),
                            horarioHORARIO = dataRow["horarioHORARIO"].ToString()

                        });

                    }

                    return ObjAgenda;

                }   

            }
            catch (Exception )
            {
                throw;

            }

        }
        public List<Horario> ListaHorarioPorCodigo(string horario)
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    List<Horario> ObjAgenda = new List<Horario>();

                    acessoDados.Conexao();

                    var cmd = acessoDados.ExecutaComando();
                    cmd.CommandText = "SELECT codigoHORARIO from tb_horarios WHERE horarioHORARIO = @horario ";
                    cmd.Parameters.AddWithValue("@horario", horario);
                    acessoDados.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();


                    while (dr.Read())
                    {
                        ObjAgenda.Add(new Horario()
                        {
                            codigoHORARIO = Convert.ToInt32(dr["codigoHORARIO"].ToString()),
                            //horarioHORARIO = dr["horarioHORARIO"].ToString()
                        });
                    }
                    acessoDados.Close();
                    dr.Close();
                    return ObjAgenda;
}

            }
            catch (Exception )
            {
                throw;

            }

        }
        public string Cadastrar(Agendamento agendamento)
        {
            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                try
                {

                 
                    //###########################################################################################
                    // GERANDO o agendamento com o codido do pedido
                    //###########################################################################################
                    acessoDados.ComandoSQl = "INSERT INTO tb_agendamento (funcionarioAGENDAMENTO,clienteAGENDAMENTO,diaAGENDAMENTO,horaAGENDAMENTO,servicoAGENDAMENTO,observacaoAGENDAMENTO,colunaAGENDAMENTO,linhaAGENDAMENTO,fone_celular,relacaoPEDIDO,nomeclienteAGENDAMENTO) VALUES  (@funcionarioAGENDAMENTO,@clienteAGENDAMENTO,@diaAGENDAMENTO,@horaAGENDAMENTO,@servicoAGENDAMENTO,@observacaoAGENDAMENTO,@colunaAGENDAMENTO,@linhaAGENDAMENTO,@fone_celular,@pedidoITEMPEDIDO,@nomeclienteAGENDAMENTO)";
                    acessoDados.Conexao();
                    var cmd = acessoDados.ExecutaComando();
                    cmd.Parameters.AddWithValue("@funcionarioAGENDAMENTO", agendamento.funcionarioAGENDAMENTO);
                    cmd.Parameters.AddWithValue("@clienteAGENDAMENTO", agendamento.codigoCliente);
                    cmd.Parameters.AddWithValue("@diaAGENDAMENTO", agendamento.diaAGENDAMENTO );
                    cmd.Parameters.AddWithValue("@horaAGENDAMENTO", agendamento.codigoHorario);
                    cmd.Parameters.AddWithValue("@servicoAGENDAMENTO", agendamento.codigoSERVICO);
                    cmd.Parameters.AddWithValue("@observacaoAGENDAMENTO", agendamento.observacaoAGENDAMENTO );
                    cmd.Parameters.AddWithValue("@colunaAGENDAMENTO", agendamento.colunaAGENDAMENTO);
                    cmd.Parameters.AddWithValue("@linhaAGENDAMENTO", agendamento.linhaAGENDAMENTO);
                    cmd.Parameters.AddWithValue("@fone_celular", agendamento.fone_celular);
                    cmd.Parameters.AddWithValue("@pedidoITEMPEDIDO", agendamento.relacaoPEDIDO);
                    cmd.Parameters.AddWithValue("@nomeclienteAGENDAMENTO", agendamento.nomeclienteAGENDAMENTO);

                    acessoDados.Open();
                    cmd.ExecuteNonQuery();
                    acessoDados.Close();
                    return Uteis.MensagemeOK;

                }
                catch (Exception ex)
                {
                    throw ex;
                    acessoDados.Close();
                    return Uteis.MensagemeError + ex.Message.ToString();
                }

            }
        }
        public void Cancelar(int funcionario, int linha, int coluna, DateTime dataagenda)
        {
            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                try
                {
                    string ano, dia, mes;

                    ano = dataagenda.ToString().Substring(6, 4);
                    dia = dataagenda.ToString().Substring(0, 2);
                    mes = dataagenda.ToString().Substring(3, 2);

                    string diagenda =  ano + "/" + mes + "/" + dia;
                    

                    acessoDados.ComandoSQl = "UPDATE tb_agendamento  SET canceladoAGENDAMENTO=@cancelar WHERE funcionarioAGENDAMENTO = @CODIGO AND linhaAGENDAMENTO = @linhaAGENDAMENTO AND  colunaAGENDAMENTO = @colunaAGENDAMENTO AND cast(diaAGENDAMENTO as date) =@diaagenda ";
                    acessoDados.Conexao();
                    var cmd = acessoDados.ExecutaComando();
                    cmd.Parameters.AddWithValue("@CODIGO", funcionario);
                    cmd.Parameters.AddWithValue("@cancelar", 1);
                    cmd.Parameters.AddWithValue("@linhaAGENDAMENTO", linha);
                    cmd.Parameters.AddWithValue("@colunaAGENDAMENTO", coluna);
                    cmd.Parameters.AddWithValue("@diaagenda", diagenda);
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
        public bool ConfirmaAgendamento(int funcionario, int linha, int coluna, DateTime dataagenda,int tipoPagamento)
        {
            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                try
                {


                    string ano, dia, mes;
                     
                    ano = dataagenda.ToString().Substring(6, 4);
                    dia = dataagenda.ToString().Substring(0, 2);
                    mes = dataagenda.ToString().Substring(3, 2);

                    string diagenda = ano + "/" + mes + "/" + dia;

                    acessoDados.Conexao();
 
                    MySqlCommand cmdFaturamento = new MySqlCommand("spsGerarFaturamento", acessoDados.con);
                    cmdFaturamento.CommandType = CommandType.StoredProcedure;

                    cmdFaturamento.Parameters.AddWithValue("@funcionario", funcionario);
                    cmdFaturamento.Parameters.AddWithValue("@linhaAGENDAMENTO", linha);
                    cmdFaturamento.Parameters.AddWithValue("@colunaAGENDAMENTO", coluna);
                    cmdFaturamento.Parameters.AddWithValue("@tipoPagamento", tipoPagamento);
                    cmdFaturamento.Parameters.AddWithValue("@diaAGENDAMENTO", dataagenda);
                       
                    acessoDados.Open();
                    cmdFaturamento.ExecuteNonQuery();
                    acessoDados.Close();

                    return true;
                    
                }
                  

                catch (Exception)
                {
                    acessoDados.Close();
                    throw;
                }

            }
        }
        public long CadastraPedidoServico(int funcionario , int cliente,List<Servico> ListaServico, DateTime dataMov)
        {
            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                try
                {

                    //###########################################################################################
                    // GERANDO O PEdido DE COMPRA
                    //###########################################################################################
                    acessoDados.ComandoSQl = "INSERT INTO tb_pedido (funcionarioPEDIDO,clientePEDIDO,datacricaoPEDIDO) VALUES  (@funcionarioPEDIDO,@clientePEDIDO,@DtaMovimentacao)";
                    acessoDados.Conexao();
                    var cmdPedido = acessoDados.ExecutaComando();
                    cmdPedido.Parameters.AddWithValue("@funcionarioPEDIDO", funcionario);
                    cmdPedido.Parameters.AddWithValue("@clientePEDIDO", cliente);
                    cmdPedido.Parameters.AddWithValue("@DtaMovimentacao", dataMov);
                    acessoDados.Open();
                    cmdPedido.ExecuteNonQuery();
                    long Pedido = cmdPedido.LastInsertedId;
                    acessoDados.Close();


                    // Inserindo itens do pedido
     

                    for (int i = 0; i < ListaServico.Count; i++)
                    {
                        acessoDados.ComandoSQl = "INSERT INTO tb_item_pedido (pedidoITEMPEDIDO,servicoITEMPEDIDO,valorITEMPEDIDO) VALUES  (@pedidoITEMPEDIDO,@servicoITEMPEDIDO,@valorITEMPEDIDO)";
                        acessoDados.Conexao();
                        var cmdItem = acessoDados.ExecutaComando();

                        cmdItem.Parameters.AddWithValue("@pedidoITEMPEDIDO", Pedido);
                        cmdItem.Parameters.AddWithValue("@servicoITEMPEDIDO", ListaServico[i].Id);
                        cmdItem.Parameters.AddWithValue("@valorITEMPEDIDO", ListaServico[i].PrecoSERVICO);
                        acessoDados.Open();
                        cmdItem.ExecuteNonQuery();
                        cmdItem = null;
                    }
                    acessoDados.Close();
                    return Pedido;

                }
                catch (Exception )
                {
                    acessoDados.Close();
                    return 0;
                }

            }
        }
        public long CadastraPedidoServico(int funcionario, int cliente, List<Servico> ListaServico)
        {
            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                try
                {

                    //###########################################################################################
                    // GERANDO O PEdido DE COMPRA - MUDAR AQUI PARA TABELA NOVA TB_PEDIDO_AGENDAMENTO 
                    //###########################################################################################
                    acessoDados.ComandoSQl = "INSERT INTO tb_pedido_agendamento (funcionarioPEDIDOAGENDAMENTO,clientePEDIDOAGENDAMENTO) VALUES  (@funcionarioPEDIDO,@clientePEDIDO)";
                    acessoDados.Conexao();
                    var cmdPedido = acessoDados.ExecutaComando();
                    cmdPedido.Parameters.AddWithValue("@funcionarioPEDIDO", funcionario);
                    cmdPedido.Parameters.AddWithValue("@clientePEDIDO", cliente);
                    acessoDados.Open();
                    cmdPedido.ExecuteNonQuery();
                    long Pedido = cmdPedido.LastInsertedId;
                    acessoDados.Close();


                    // Inserindo itens do pedido
                    for (int i = 0; i < ListaServico.Count; i++)
                    {
                       // MUDAR AQUI PARA TABELA NOVA TB_PEDIDO_AGENDAMENTO
                        acessoDados.ComandoSQl = "INSERT INTO tb_item_pedido_agend (pedidoITEMPEDIDOAGEND,servicoITEMPEDIDOAGEND,valorITEMPEDIDOAGEND) VALUES  (@pedidoITEMPEDIDO,@servicoITEMPEDIDO,@valorITEMPEDIDO)";
                        acessoDados.Conexao();
                        var cmdItem = acessoDados.ExecutaComando();

                        cmdItem.Parameters.AddWithValue("@pedidoITEMPEDIDO", Pedido);
                        cmdItem.Parameters.AddWithValue("@servicoITEMPEDIDO", ListaServico[i].Id);
                        cmdItem.Parameters.AddWithValue("@valorITEMPEDIDO", ListaServico[i].PrecoSERVICO);
                        acessoDados.Open();
                        cmdItem.ExecuteNonQuery();
                        cmdItem = null;
                    }
                    acessoDados.Close();
                    return Pedido;

                }
                catch (Exception)
                {
                    acessoDados.Close();
                    return 0;
                }

            }
        }

    }
}
