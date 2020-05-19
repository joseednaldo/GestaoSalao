using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_GestaoSalao
{
    public class Usuario
    {
        public int codigoUSUARIO { get; set; }
        public Funcionario funcionarioUSUARIO { get; set; }
        public string nomeUSUARIO { get; set; }
        public string loginUSUARIO { get; set; }
        public string senhaUSUARIO { get; set; }
        public string redigitarUSUARIO { get; set; }
        public int IdpefilUSUARIO { get; set; }
        public Pefil pefilUSUARIO { get; set; }
        public Situacao situacaoUSUARIO { get; set; }

    }
}
