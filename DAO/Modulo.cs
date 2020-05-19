using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class Modulo
    {
        public DTO_GestaoSalao.Modulo Find(int id)
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    DTO_GestaoSalao.Modulo modulo = new DTO_GestaoSalao.Modulo();
                    acessoDados.Conexao();

                    var cmd = acessoDados.ExecutaComando();
                    cmd.CommandText = "SELECT * FROM tb_modulo WHERE codigoMODULO = @CODIGO ";
                    cmd.Parameters.AddWithValue("@CODIGO", id);
                    acessoDados.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        modulo.codigoMODULO = Convert.ToInt32(dr["codigoMODULO"]);
                        modulo.descricaoMODULO = dr["descricaoMODULO"].ToString();
                        modulo.nomeMODULO = dr["nomeMODULO"].ToString();

                        // retorna uma lista de componentes que fazem parte do modulo... ex:  modulo cadastro -> componentes (cad cliente,produto)...
                        //modulo.Componente = new DAO.Componente().ListaComponentes(Convert.ToInt32(dr["codigoMODULO"]));

                    }
                    acessoDados.Close();
                    dr.Close();
                    return modulo;
                }

            }
            catch (Exception)
            {
                throw;

            }

        }
    }
}
