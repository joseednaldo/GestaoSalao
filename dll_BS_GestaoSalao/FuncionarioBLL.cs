using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_GestaoSalao;
using System.Data;


namespace dll_BS_GestaoSalao
{
    public class FuncionarioBLL
    {
        public string CadastrarFuncionario(Funcionario funcionario)
        {
            DAO.FuncionarioCRUD CadastrarFuncionario = new DAO.FuncionarioCRUD();
            string mensagem = CadastrarFuncionario.Cadastrar(funcionario);
            return mensagem;

        }
        public string AlterarFuncionario(Funcionario funcionario)
        {
            DAO.FuncionarioCRUD AlterarFuncionario = new DAO.FuncionarioCRUD();
            string mensagem = AlterarFuncionario.AlterarCadastro(funcionario);
            return mensagem;

        }
        public List<Funcionario> ListaFuncionario()
        {
            DAO.FuncionarioCRUD CONSULTA = new DAO.FuncionarioCRUD();
            return CONSULTA.Listafuncionario();
        }


        public List<Funcionario> ListaFuncionarioSemID()
        {
            DAO.FuncionarioCRUD CONSULTA = new DAO.FuncionarioCRUD();
            return CONSULTA.ListafuncionarioSemID();
        }




        public List<Funcionario> ConsultaServico(int id)
        {
            DAO.FuncionarioCRUD CONSULTA = new DAO.FuncionarioCRUD();
            return CONSULTA.Consulta(id);
        }
        public bool ExcluirCadastro(int id)
        {
            DAO.FuncionarioCRUD funcionario = new DAO.FuncionarioCRUD();
            bool booExclusao = funcionario.ExcluirCadastro(id);
            return booExclusao;

        }
    }
}
