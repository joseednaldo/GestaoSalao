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
   public class ServicoCRUD : CRUD<Servico>
    {
        public ServicoCRUD()
            {
            }
     
        public override string  Cadastrar(Servico servico)
        {
           using(AcessoBancoDados acessoDados = new AcessoBancoDados() )
            {
                try
                {
                    acessoDados.ComandoSQl = "INSERT INTO tb_servico (descricaoSERVICO,precoSERVICO) VALUES (@descricao,@preco)";
                    acessoDados.Conexao();
                    var cmd = acessoDados.ExecutaComando();
                    cmd.Parameters.AddWithValue("@descricao", servico.DescricaoSERVICO);
                    cmd.Parameters.AddWithValue("@preco", servico.PrecoSERVICO);
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
        public override List<Servico> Consulta(int id)
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    List<Servico> _Servico = new List<Servico>();
                    acessoDados.Conexao();

                    var cmd = acessoDados.ExecutaComando();
                    cmd.CommandText = "SELECT * FROM tb_servico WHERE codigoSERVICO = @CODIGO ";
                    cmd.Parameters.AddWithValue("@CODIGO", id);
                    acessoDados.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();

                    
                    while (dr.Read())
                    {
                        _Servico.Add(new Servico()
                        {
                            Id = Convert.ToInt32(dr["codigoSERVICO"]),
                            DescricaoSERVICO = dr["descricaoSERVICO"].ToString(),
                            PrecoSERVICO       = Convert.ToDecimal(dr["precoSERVICO"])

                        });
                    }
                    acessoDados.Close();
                    dr.Close();
                    return _Servico;

                }

            }
            catch (Exception )
            {
                throw;

            }
        
        }
        public override List<Servico>ListaServico()
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    List<Servico> ObjServico = new List<Servico>();
                   
                    acessoDados.Conexao();
                    acessoDados.Open();

                    //Estrutura de tabela 
                    DataTable objDataTable = new DataTable();


                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT codigoSERVICO,descricaoSERVICO,precoSERVICO FROM tb_servico", acessoDados.con);
                    
                    da.Fill(objDataTable);
                    foreach (DataRow  dataRow in objDataTable.Rows)
                    {
                       // List<Servico> ObjServico = new List<Servico>();

                        ObjServico.Add(new Servico()
                        {
                            Id = Convert.ToInt32(dataRow["codigoSERVICO"].ToString()),
                            DescricaoSERVICO = dataRow["descricaoSERVICO"].ToString(),
                            PrecoSERVICO = Convert.ToDecimal(dataRow["precoSERVICO"])
                        });

                    }

                    
                    return ObjServico;

                }

            }
            catch (Exception )
            {
                throw;

            }

        }
        public override bool AlterarCadastro(Servico servico)
        {
            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                try
                {
                    acessoDados.ComandoSQl = "UPDATE tb_servico  SET descricaoSERVICO= @descricao,  precoSERVICO = @Preco WHERE codigoSERVICO = @CODIGO ";
                    acessoDados.Conexao();
                    var cmd = acessoDados.ExecutaComando();
                    cmd.Parameters.AddWithValue("@descricao", servico.DescricaoSERVICO);
                    cmd.Parameters.AddWithValue("@Preco", servico.PrecoSERVICO );
                    cmd.Parameters.AddWithValue("@CODIGO", servico.Id);
                    acessoDados.Open();
                    cmd.ExecuteNonQuery();
                    acessoDados.Close();
                    return true;
                }
                catch (Exception )
                {

                    return false;
                }

            }
        }
        public override bool ExcluirCadastro(int id)
        {
            using (AcessoBancoDados acessoDados = new AcessoBancoDados())
            {
                try
                {
                    acessoDados.ComandoSQl = "DELETE FROM tb_servico WHERE codigoSERVICO = @CODIGO ";
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
