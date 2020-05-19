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
  public   class ServicoBLL
    {
        public ServicoBLL()
        {
          
        }
        public string  CadastrarServico(Servico servico)
        {
            DAO.ServicoCRUD CadastrarServico = new DAO.ServicoCRUD();
            string mensagem = CadastrarServico.Cadastrar(servico);
            return mensagem;

        }
        public bool AlterarServico(Servico servico)
        {
            DAO.ServicoCRUD CadastrarServico = new DAO.ServicoCRUD();
            bool mensagem = CadastrarServico.AlterarCadastro(servico);
            return mensagem;

        }
        public List<Servico> ListaServico()
        {
            DAO.ServicoCRUD CONSULTA = new DAO.ServicoCRUD();
            return CONSULTA.ListaServico();
        }
        public List<Servico> ConsultaServico(int id)
        {
            DAO.ServicoCRUD CONSULTA = new DAO.ServicoCRUD();
            return CONSULTA.Consulta(id);
        }
        public bool ExcluirCadastro(int id)
        {
            DAO.ServicoCRUD CadastrarServico = new DAO.ServicoCRUD();
            bool booExclusao = CadastrarServico.ExcluirCadastro(id);
            return booExclusao;

        }

    }
}
