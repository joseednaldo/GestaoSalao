using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Componente
    {
        private StringBuilder strQuery { get; set; }
        public Componente()
        {

        }

        public DTO_GestaoSalao.Compoente Find(int id)
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    DTO_GestaoSalao.Compoente compoente = new DTO_GestaoSalao.Compoente();
                    acessoDados.Conexao();

                    var cmd = acessoDados.ExecutaComando();
                    cmd.CommandText = "SELECT * FROM tb_componente WHERE codigoCOMPONENTE = @CODIGO ";
                    cmd.Parameters.AddWithValue("@CODIGO", id);
                    acessoDados.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        compoente.codigoCOMPONENTE = Convert.ToInt32(dr["codigoCOMPONENTE"]);
                        compoente.nomeCOMPONENTE = dr["nomeCOMPONENTE"].ToString();
                        compoente.descricaCOMPONENTE = dr["descricaCOMPONENTE"].ToString();
                        compoente.Modulo = new DTO_GestaoSalao.Modulo();
                    }
                    acessoDados.Close();
                    dr.Close();
                    return compoente;
                }

            }
            catch (Exception)
            {
                throw;

            }

        }

        public List<DTO_GestaoSalao.Compoente> ListaComponentes(int id)
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    List<DTO_GestaoSalao.Compoente> objCompoente = new List<DTO_GestaoSalao.Compoente>();

                    acessoDados.Conexao();
                    acessoDados.Open();

                    //Estrutura de tabela 
                    DataTable objDataTable = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * from tb_componente where moduloCOMPONENTE = " + id, acessoDados.con);

                    da.Fill(objDataTable);
                    foreach (DataRow dataRow in objDataTable.Rows)
                    {

                        objCompoente.Add(new DTO_GestaoSalao.Compoente()
                        {
                            codigoCOMPONENTE = Convert.ToInt32(dataRow["codigoCOMPONENTE"]),
                            nomeCOMPONENTE = dataRow["nomeCOMPONENTE"].ToString(),
                            descricaCOMPONENTE = dataRow["descricaCOMPONENTE"].ToString(),
                            Modulo = new DTO_GestaoSalao.Modulo(),
                        });

                    }


                    return objCompoente;

                }

            }
            catch (Exception ex)
            {
                throw;

            }

        }

    }
}