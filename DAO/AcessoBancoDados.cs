using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DTO_GestaoSalao;
using System.Data;
using System.Xml;
using System.Collections;
using System.Xml.Linq ;
using System.Xml.Serialization;
using System.IO;
using System.Configuration;
using System.Configuration.Assemblies;

namespace DAO
{
    public class AcessoBancoDados : IDisposable

    {

        public MySqlConnection con = new MySqlConnection();
        private MySqlCommand cmd = new MySqlCommand();
        private String sql = "";


        ////Informe aqui os dados de acesso ao banco [IMPORTANTE]
        //private string strCaminhoArquivo = (@"\SalaoBeleza\salaobeleza.config");
        //private string HOST_PRODUTO = "salaobeleza.mysql.dbaas.com.br";
        //private string HOST_TESTE = "localhost";



        //Informe aqui os dados de acesso ao banco [IMPORTANTE]
        private string strCaminhoArquivo = (@"\SalaoBeleza\salaobeleza.config");
        public String _conexaoMySQL;
        private string SERVIDOR = "";

        private string USUARIO = "";
        private string SENHA = "";
        private string BANCO = "";
        private string PORTA = "";
        private String POOLING = "";
        private String AMBIENTE = "";

        //public String _conexaoMySQL = "";
        //private string USUARIO = "salaobeleza";
        //private string SENHA = "M01102011";
        //private string BANCO = "salaobeleza";

   
        // PRODUCAO
        //public String _conexaoMySQL = "Database=salaobeleza" + ";Data Source=" + "salaobeleza.mysql.dbaas.com.br" + "; User Id=" + "salaobeleza" + "; Password=" + "M01102011d" + "; pooling=false";

        public void conexaoMySQL()
        {
            //arrayConexao = fnLeConfig();

            // _conexaoMySQL = "Database=salaobeleza";
            ;
        }
        public string ComandoSQl
        {
            set
            {
                sql = value;
            }
        }
        public void Dispose()
        {
            this.con.Dispose();

        }
        public void Open()
        {
            if (this.con.State == ConnectionState.Closed)
            {
                this.con.Open();
            }
        }
        public void Close()
        {
            if (con.State != ConnectionState.Closed)
            {
                this.con.Close();
            }
        }
        private string StringConnection()
        {

            return LerConfiguracao("Conn") ;
            // return "Database=salaobeleza" + ";Data Source=" + "salaobeleza.mysql.dbaas.com.br" + "; User Id=" + "salaobeleza" + "; Password=" + "M01102011" + "; pooling=false";

        }
        public MySqlCommand ExecutaComando()
        {
            return cmd = new MySqlCommand(sql, this.con);
        }
        public void Conexao()
        {
            //Ao instanciar a classe que já atribui a "this.connection" todos os dados do BD
            this.con = new MySqlConnection(this.StringConnection());

        }
        private void ConfigurarCnexao()
        {

            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configFile.AppSettings.Settings.Add("ConexaoApp1", "teste"); configFile.Save(ConfigurationSaveMode.Modified);

        }
        public void fnLeConfig()
        {
          //  var teste = LerConfiguracao("Conn");

            XDocument doc = XDocument.Load(System.Environment.GetEnvironmentVariable("APPDATA") + strCaminhoArquivo);

            foreach (XElement x in doc.Element("SalaoBeleza").Elements())
            {

                AMBIENTE = x.Element("AMBIENTE").Value;
                SERVIDOR = x.Element("SERVIDOR").Value;
                BANCO = x.Element("BANCO").Value;
                USUARIO = x.Element("UserID").Value;
                SENHA = x.Element("Password").Value;
                POOLING = x.Element("POOLING").Value;
                PORTA = x.Element("PORTA").Value;

                if (AMBIENTE == "PRODUCAO")
                {
                     // PRODUCAO
                     //_conexaoMySQL = "Database=salaobeleza" + ";Data Source=" + "salaobeleza.mysql.dbaas.com.br" + "; User Id=" + "salaobeleza" + "; Password=" + "M01102011" + "; pooling=false";
                    _conexaoMySQL = "Database=" + BANCO + ";Data Source=" + SERVIDOR  + "; User Id=" + USUARIO  + "; Password=" + SENHA  + ";pooling=" + POOLING;
                    //GravarConfiguracao("Conn", _conexaoMySQL);
                }
                else
                 {

                    //HOMOLOGACAO  MINHA MAQUINA
                    _conexaoMySQL = "Database=" + BANCO + ";Data Source=" + SERVIDOR + "; User Id=" + USUARIO + "; Password=" + SENHA + ";pooling=" + POOLING;

                    //HOMOLOGAÇÃO -LOCALWEB
                    // _conexaoMySQL = "Database=" + BANCO + ";Data Source=" + SERVIDOR + "; User Id=" + USUARIO + "; Password=" + SENHA + ";pooling=" + POOLING;  
                    // GravarConfiguracao("Conn", _conexaoMySQL);

                }
                GravarConfiguracao("Conn", _conexaoMySQL);
            }
        }
        public static void GravarConfiguracao(string chave, string valor)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove(chave);
            config.Save();
            config.AppSettings.Settings.Add(chave, valor);
            config.Save();
        }
        public static string LerConfiguracao(string chave)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            return config.AppSettings.Settings[chave].Value;
        }
    }

}


