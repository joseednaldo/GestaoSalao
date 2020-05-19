using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_GestaoSalao
{
    public class Funcionario 
    {
        public int Id { get; set; }
        public string nomeFuncionario { get; set; }
        public string fone1 { get; set; }
        public string fone2 { get; set; }
        public  DateTime DataNascimento;
        public bool ativo  { get; set; }
        public string cpf { get; set; }




    }
}
