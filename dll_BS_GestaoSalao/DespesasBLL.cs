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
    public class DespesasBLL
    {
        public DespesasBLL()
        {
        }
        public string CadastrarDespesa(Despesas despesa)
        {
            DAO.DespesaCRUD CadastrarDespesa = new DAO.DespesaCRUD();
            string mensagem = CadastrarDespesa.Cadastrar(despesa);
            return mensagem;
        }
        public bool AlterarDespesas(Despesas despesa)
        {
            DAO.DespesaCRUD AlteraDespesa = new DAO.DespesaCRUD();
            bool mensagem = AlteraDespesa.AlterarCadastro(despesa);
            return mensagem;
        }
        public bool ExcluirCadastro(int id)
        {
            DAO.DespesaCRUD ExcluirDespesa = new DAO.DespesaCRUD();
            bool booExclusao = ExcluirDespesa.ExcluirCadastro(id);
            return booExclusao;
        }
        public DataTable ListaDespesa(DateTime data, DateTime datafim, int situacao, int tipodespesa,int filtroFun=0, int atendente=0)
        {
            DAO.DespesaCRUD despesa = new DAO.DespesaCRUD();
            return despesa.Despesa( data, datafim, situacao, tipodespesa,filtroFun, atendente);

        }
        public List<RelatorioDespesas> Lista(DateTime data, DateTime datafim, int situacao, int tipodespesa, int filtroFun = 0, int atendente = 0)
        {
            DAO.DespesaCRUD despesa = new DAO.DespesaCRUD();
            return despesa.ListaDespesa(data, datafim, situacao, tipodespesa, filtroFun, atendente);

        }
        public Despesas BuscaDespesa(int despesa)
        {
            DAO.DespesaCRUD buscaEmpresa = new DAO.DespesaCRUD();
            return buscaEmpresa.FindDespesa(despesa);

        }
    }
}
