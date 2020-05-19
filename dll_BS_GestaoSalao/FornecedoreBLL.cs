using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_GestaoSalao;
using System.Data;


namespace dll_BS_GestaoSalao
{
   public class FornecedoreBLL
    {
        public List<Fornecedore> ListaFornecedore()
        {
            DAO.FornecedoresCRUD CONSULTA = new DAO.FornecedoresCRUD();
            return CONSULTA.ListaFornecedore();
        }
    }
}
