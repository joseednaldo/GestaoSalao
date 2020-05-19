using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoSalao.Relatorio
{
    public partial class RelatorioRecibo : Form
    {
        public RelatorioRecibo()
        {
            InitializeComponent();
        }

        private void RelatorioRecibo_Load(object sender, EventArgs e)
        {

            
        }

        public void CarregaRelatorio(int atendente, DateTime dataPesquisaInicio, DateTime dataPesquisaFim, int filtro, int cod_vale)
        {

            dll_BS_GestaoSalao.ValeBLL lista = new dll_BS_GestaoSalao.ValeBLL();
            var listaVale = lista.CarregaVale(atendente, Convert.ToDateTime(dataPesquisaInicio), Convert.ToDateTime(dataPesquisaFim), filtro, cod_vale);

            var dataVale = new Microsoft.Reporting.WinForms.ReportDataSource("dsRecibo", listaVale);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataVale);
            this.reportViewer1.RefreshReport();

        }

    }
}
