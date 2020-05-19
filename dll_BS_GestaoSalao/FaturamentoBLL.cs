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
   public class FaturamentoBLL
    {
        public long GeraFaturamento(int funcionario, int cliente, List<Servico> ListaServico, DateTime DtMovimentacao, int TipoPgto, int sistema = 0)
        {
            DAO.FaturamentoCRUD GerarFaturamento = new DAO.FaturamentoCRUD();
            return GerarFaturamento.GerarFaturamento(funcionario, cliente, ListaServico, DtMovimentacao, TipoPgto,0);
        }

        public DataTable CarregaPedidos(int atendente,DateTime data, DateTime datafim,int filtroFun)
        {
            DAO.FaturamentoCRUD Pedidos = new DAO.FaturamentoCRUD();
            return Pedidos.ListaFaturamento(atendente, data, datafim, filtroFun);

        }

    }
}
