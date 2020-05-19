using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_GestaoSalao;
using System.Data;

namespace dll_BS_GestaoSalao
{
   public class ClienteBLL
    {
        public List<Cliente> ListaCliente()
        {
            DAO.ClienteCRUD CONSULTA = new DAO.ClienteCRUD();
            return CONSULTA.ListaCliente();
        }
    }
}
