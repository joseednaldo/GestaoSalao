using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_GestaoSalao
{
    [Serializable]
    public class Compoente : IDisposable
    {

        public int codigoCOMPONENTE { get; set; }
        public string nomeCOMPONENTE { get; set; }
        public string descricaCOMPONENTE { get; set; }

        private DTO_GestaoSalao.Modulo modulo;
        public int Mod_id { get; set; }
        public Modulo Modulo {
            get {return this.modulo; }
            set
            {
                this.modulo = value;
                this.Mod_id = value.codigoMODULO;
            }

        }

            
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
    }
}
