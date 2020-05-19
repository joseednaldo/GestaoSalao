using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_GestaoSalao
{
    public  class ListaPedidos

    {

        
        public int codigoPEDIDO { get; set; }
        public DateTime datacricaoPEDIDO { get; set; }
        public int funcionarioPEDIDO { get; set; }
        //public int clientePEDIDO { get; set; }
        //public int qtdPEDIDO { get; set; }
        public decimal valorPEDIDO { get; set; }
        public int servicoPEDIDO { get; set; }
        public string nomeFUNCIONARIO { get; set; }
       // public string nomeCLIENTE { get; set; }
        public string servicodescrPEDIDO { get; set; }

        /*
           strSql = "SELECT codigoFATURAMENTO,
            servicoITEMFATURAMENTO,descricaoSERVICO
           ,(CASE valorITEMFATURAMENTO  WHEN 0 THEN precoSERVICO ELSE valorITEMFATURAMENTO  END) AS valorITEMFATURAMENTO 
           ,nomeFUNCIONARIO ";
         */

    }
}
