using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_GestaoSalao;
using System.Threading.Tasks;

namespace dll_BS_GestaoSalao
{
   public class AgendamentoBLL
    {
        public List<Agendamento> RecuperaParametros()
        {
            DAO.AgendamentoCRUD CONSULTA = new DAO.AgendamentoCRUD();
            return CONSULTA.ListaParametro();

        }
        public List<Agendamento> RecuperaAgendamento(DateTime data)
        {
            DAO.AgendamentoCRUD Agendamento = new DAO.AgendamentoCRUD();
            return Agendamento.ListaAgendamento(data);

        }
        public List<Horario> RecuperaHorario()
        {
            DAO.AgendamentoCRUD Agendamento = new DAO.AgendamentoCRUD();
            return Agendamento.ListaHorario();

        }
        public List<Horario> RetornaCodigoServico(string Horariod)
        {
            DAO.AgendamentoCRUD RecuperarHorario = new DAO.AgendamentoCRUD();
            return RecuperarHorario.ListaHorarioPorCodigo(Horariod);
        }
        public string CadastrarAgendamento(Agendamento agendamento)
        {
            DAO.AgendamentoCRUD CadastrarAgendamento = new DAO.AgendamentoCRUD();
            string mensagem = CadastrarAgendamento.Cadastrar(agendamento);
            return mensagem;

        }
        public long GeraPedido(int funcionario, int cliente, List<Servico> ListaServico, DateTime DtMovimentacao)
        {
            DAO.AgendamentoCRUD CadastrarAgendamento = new DAO.AgendamentoCRUD();
            return  CadastrarAgendamento.CadastraPedidoServico( funcionario,  cliente, ListaServico, DtMovimentacao);
        }
        public long GeraPedido(int funcionario, int cliente, List<Servico> ListaServico)
        {
            DAO.AgendamentoCRUD CadastrarAgendamento = new DAO.AgendamentoCRUD();
            return CadastrarAgendamento.CadastraPedidoServico(funcionario, cliente, ListaServico);
        }
        public void Cancelar(int funcionario, int linha, int coluna, DateTime dataagenda)
        {
            DAO.AgendamentoCRUD Agendamento = new DAO.AgendamentoCRUD();
             Agendamento.Cancelar(funcionario, linha,coluna, dataagenda);

        }
        public bool ConfirmaAgendamento(int funcionario, int linha, int coluna, DateTime dataagenda,int TipoPagto)
        {
            DAO.AgendamentoCRUD Agendamento = new DAO.AgendamentoCRUD();
            return Agendamento.ConfirmaAgendamento(funcionario, linha, coluna, dataagenda, TipoPagto);

        }


    }
}
