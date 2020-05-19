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
    public  class TipoDespesaCRUD
    {
        public TipoDespesaCRUD()
        {
        }
        public List<TipoDespesa> ListaTipoDespesa()
        {
            try
            {
                using (AcessoBancoDados acessoDados = new AcessoBancoDados())
                {
                    List<TipoDespesa> ObjTipoDespesa = new List<TipoDespesa>();

                    acessoDados.Conexao();
                    acessoDados.Open();

                    //Estrutura de tabela 
                    DataTable objDataTable = new DataTable();


                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT codigoTIPODESPESA,descricaoTIPODESPESA FROM tb_tipo_depesas", acessoDados.con);

                    da.Fill(objDataTable);
                    foreach (DataRow dataRow in objDataTable.Rows)
                    {

                        ObjTipoDespesa.Add(new TipoDespesa()
                        {
                            codigoTIPODESPESA = Convert.ToInt32(dataRow["codigoTIPODESPESA"].ToString()),
                            descricaoTIPODESPESA = dataRow["descricaoTIPODESPESA"].ToString(),
                        });
                    }
                    return ObjTipoDespesa;

                }

            }
            catch (Exception)
            {
                throw;

            }

        }

        public TipoDespesa FindTipoDespesa(int id)
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
                    strSql = "SELECT codigoTIPODESPESA,descricaoTIPODESPESA FROM tb_tipo_depesas ";
                    strSql = strSql + "  WHERE codigoTIPODESPESA = " + id;

                    MySqlDataAdapter da = new MySqlDataAdapter(strSql, acessoDados.con);
                    TipoDespesa _TipoDespesa = new TipoDespesa();

                    da.Fill(objDataTable);

                    foreach (DataRow dr in objDataTable.Rows)
                    {
                        _TipoDespesa.codigoTIPODESPESA = Convert.ToInt32(dr["codigoTIPODESPESA"]);
                        _TipoDespesa.descricaoTIPODESPESA = dr["descricaoTIPODESPESA"].ToString();

                    };
                    acessoDados.Close();
                    return _TipoDespesa;

                }

            }
            catch (Exception)
            {
                throw;

            }

        }
    }
}
