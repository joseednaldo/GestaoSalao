using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_GestaoSalao
{
    [Serializable]
    public class Modulo :IDisposable    
    {
        public int codigoMODULO { get; set; }
        public string nomeMODULO { get; set; }
        public string descricaoMODULO { get; set; }

        public int ativaACESSOUSUARIO { get; set; }

        public  int usuarioACESSOUSUARIO { get; set; }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing) { }
                disposedValue = true;
            }
        }

        public void Dispose() { Dispose(true); }
        #endregion
        public Modulo()
        {

        }

        public List<DTO_GestaoSalao.Compoente>Componente { get; set; } = new List<DTO_GestaoSalao.Compoente>();
      
    }
}
