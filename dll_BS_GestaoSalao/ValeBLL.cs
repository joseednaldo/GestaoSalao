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
    public class ValeBLL
    {
        public ValeBLL()
        {

        }
        public string EmitirVale(Vale vale)
        {
            DAO.ValeCRUD EmitirVale= new DAO.ValeCRUD();
            string mensagem = EmitirVale.Cadastrar(vale);
            return mensagem;

        }

        public bool ExcluirVale(int id)
        {
            DAO.ValeCRUD ExcluirVale = new DAO.ValeCRUD();
            bool booExclusao = ExcluirVale.ExcluirCadastro(id);
            return booExclusao;

        }
        public List<Vale> CarregaVale(int atendente, DateTime data, DateTime datafim, int filtroFun,int id_vale)
        {
            DAO.ValeCRUD vale = new DAO.ValeCRUD();
            return vale.ListaVale(atendente, data, datafim, filtroFun, id_vale);

        }

        public List<Vale> FindVale(int funcionario)
        {
            DAO.ValeCRUD vale = new DAO.ValeCRUD();
            return vale.ListaVale(funcionario);

        }

        public DataTable ListaVale(int atendente, DateTime data, DateTime datafim, int filtroFun)
        {
            DAO.ValeCRUD vale = new DAO.ValeCRUD();
            return vale.Vale(atendente, data, datafim, filtroFun);

        }
    }
}
