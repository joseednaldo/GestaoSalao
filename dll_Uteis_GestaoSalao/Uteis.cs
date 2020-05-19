using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_Uteis_GestaoSalao
{
    public static  class  Uteis
    {
        public const string MensagemeOK     = "Dados cadastrado com sucesso !!!";
        public const string MensagemeError  = "Erro ao efetuar cadastro ->";
        public const string PesquisaError  = "Erro ao efetuar pesquisa ->";
        public const string strSql = "";

        private static int CodigoCliente;
        
        public static int Cliente
        {
            get { return CodigoCliente; }
            set { CodigoCliente = value; }
        }
        public enum TipoPagto 
        {
            DINHEIRO = 1,
            DEBITO = 2,
            CREDITO = 3

        }
        public enum StatusUsuario
        {
            [Description("Ativo")]
            Ativo = 1,
            [Description("Inativo")]
            Inativo = 2,
        }

        //public enum AcaoTela
        //{
        //    Editar = 1,
        //    Incluir = 2,
        //}
        [Flags]
        public enum AcaoTela
        {
            [Description("Editar")]
            Editar = 1,
            [Description("Incluir")]
            Incluir = 2,
        }


        //[Flags]
        //public enum StatusAgendaAdvogados
        //{
        //    [Description("Atualização")]
        //    ATUALIZACAO = 1,
        //    [Description("Cumprido")]
        //    CUMPRIDO = 2,
        //    [Description("Nada a Fazer")]
        //    NADA_A_FAZER = 3,
        //    [Description("Cancelado")]
        //    CANCELADO = 4,
        //    [Description("Reagendado")]
        //    REAGENDADO = 5,
        //    [Description("Devolvido")]
        //    DEVOLVIDO = 6,

        //}

        //public enum CodigoBancoFEBRABAN
        //{
        //    [Description("Banco do Brasil")]
        //    BANCO_DO_BRASIL = 001,
        //    [Description("Banco Santander")]
        //    SANTANDER = 033,
        //    [Description("Caixa Econômica Federal")]
        //    CEF = 104,
        //    [Description("Banco Bradesco")]
        //    BRADESCO = 237,
        //    [Description("Banco Itaú")]
        //    ITAU_UNIBANCO = 341,
        //    [Description("HSBC Brasil")]
        //    HSBC = 399
        //}

    }

    public sealed class Session
    {

        private static volatile Session instance;
        private static object sync = new Object();

        private Session() { }

        public static Session Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (sync)
                    {
                        if (instance == null)
                        {
                            instance = new Session();
                        }
                    }
                }
                return instance;
            }

        }

        /// <summary>
        /// Propriedade para o ID do usuario
        /// </summary>
        public int UserID { get; set; }
        public int Administrador { get; set; }

    }

}
