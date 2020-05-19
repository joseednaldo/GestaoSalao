using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_GestaoSalao
{
    public class Servico : IEntidade
    {
        private int id;
        private string descricaoSERVICO;
        private decimal precoSERVICO;

      
      
        public decimal PrecoSERVICO
        {
            get
            {
                return precoSERVICO;
            }
            set
            {
                precoSERVICO = value;
            }
        }
        public string DescricaoSERVICO
        {
            get
            {
                return descricaoSERVICO;
            }
            set
            {
                descricaoSERVICO = value;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
    }
}