using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_GestaoSalao
{
    public class AcessoUsuario : IDisposable
    {


        public int codigoACESSOUSUARIO { get; set; }
        public int usuarioACESSOUSUARIO { get; set; }
        public int statusACESSOUSUARIO { get; set; }

        public DTO_GestaoSalao.Modulo Modulo{ get; set; }
        public DTO_GestaoSalao.Compoente Componente { get; set; }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
