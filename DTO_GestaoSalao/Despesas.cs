using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_GestaoSalao
{
    public class Despesas
    {

        public int codigoDESPESA { get; set; }
        public DateTime dataDESPESA { get; set; }
        public string descricaoDESPESA { get; set; }
        public string observacaoDESPESA { get; set; }
        public string documentoDESPESA { get; set; }
       // public Fornecedore fornecedorDESPESA { get; set; }
        public Funcionario favorecido { get; set; }
        public TipoDespesa tipoDESPESA { get; set; }
      
        public decimal valorDESPESA { get; set; }
        public int situacaoDESPESA { get; set; }


    }

    public class RelatorioDespesas
    {
        public int codigoDESPESA { get; set; }
        public DateTime dataDESPESA { get; set; }
        public string descricaoDESPESA { get; set; }
        public string observacaoDESPESA { get; set; }
        public string documentoDESPESA { get; set; }

        // outros
        public decimal valorDESPESA { get; set; }
        public string situacaoDESPESA { get; set; }
        public string Funcionario { get; set; }
        public string Observacao { get; set; }
        public string Despesa { get; set; }




    }


}
