using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_GestaoSalao;
using System.Collections;

namespace DAO
{
    public abstract class CRUD<T> where T : IEntidade
    {
        protected string tabela = null;
        protected object classe = null;

        public CRUD() { }
        public virtual string  Cadastrar(T objeto) {
            return "";
        }
        public virtual List<Servico>Consulta(int id){
            List<Servico> servico = new List<Servico>();
            return servico;
        }
        public virtual List<Servico>ListaServico()
        {
            List<Servico> servico = new List<Servico>();
            return servico;
        }
        public virtual bool  AlterarCadastro(T objeto) { return false; }
        public virtual bool ExcluirCadastro(int id) {return false; }


    }
}
