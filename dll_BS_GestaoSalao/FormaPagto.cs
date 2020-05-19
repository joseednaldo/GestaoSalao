using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dll_Uteis_GestaoSalao;


namespace dll_BS_GestaoSalao
{
    public class FormaPagto
    {
        public Enum RetornaFormaPgto(Enum tipo )
        {

             return Uteis.TipoPagto.DINHEIRO;
        }
    }
}
