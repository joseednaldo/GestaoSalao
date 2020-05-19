using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_GestaoSalao
{
    public class Vale
    {
        public int codigoVALE { get; set; }
        public string descricaoVale { get; set; }
        public decimal valorVale { get; set; }
        public DateTime dataVale { get; set; }
        public Funcionario funcionarioVale { get; set; }
        public int IdfuncionarioVale { get; set; }
        public string Nomefuncionario { get; set; }   // isso é zuado


    }
}
