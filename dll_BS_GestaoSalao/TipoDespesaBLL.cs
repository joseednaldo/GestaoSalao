using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_GestaoSalao;
using System.Data;

namespace dll_BS_GestaoSalao
{
    public class TipoDespesaBLL
    {
        public List<TipoDespesa> ListaTipoDespesa()
        {
            DAO.TipoDespesaCRUD CONSULTA = new DAO.TipoDespesaCRUD();
            return CONSULTA.ListaTipoDespesa();
        }
    }
}
