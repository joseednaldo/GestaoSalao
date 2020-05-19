using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO_GestaoSalao;
using System.Data;

namespace dll_BS_GestaoSalao
{
   public class Listas
    {
        public List<ListaPedidos> CarregaPedidos(int atendente,DateTime data, DateTime datafim,int filtroFun)
        {
            DAO.Listas Pedidos = new DAO.Listas();
            return Pedidos.ListaPedidos(atendente, data, datafim, filtroFun);

        }
        public void Cancelar(int Pedido)
        {
            DAO.Listas Agendamento = new DAO.Listas();
            Agendamento.Cancelar(Pedido);

        }
        public List<Funcionario> ListaFuncionario()
        {
            DAO.Listas funcionario = new DAO.Listas();
            return funcionario.ListaFuncionario();
        }
        public List<Pefil> ListaPerfil()
        {
            DAO.Listas pefil = new DAO.Listas();
            return pefil.ListaPerfil();
        }

        public List<Situacao> ListaSituacao()
        {
            DAO.Listas situacao = new DAO.Listas();
            return situacao.ListaSituacao();
        }
    }
}
