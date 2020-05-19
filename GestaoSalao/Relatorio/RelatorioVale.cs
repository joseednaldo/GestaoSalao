using MaterialSkin.Controls;
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
    public partial class RelatorioVale : Form
    {
        public RelatorioVale()
        {
            InitializeComponent();
        }

        private void RelatorioVale_Load(object sender, EventArgs e)
        {

            
        }
        public void CarregaRelatorio(int atendente,DateTime dataPesquisaInicio,DateTime dataPesquisaFim, int filtro,int id_Vale)
        {

            dll_BS_GestaoSalao.ValeBLL lista = new dll_BS_GestaoSalao.ValeBLL();
            var listaVale = lista.CarregaVale(atendente, Convert.ToDateTime(dataPesquisaInicio), Convert.ToDateTime(dataPesquisaFim), filtro, id_Vale);

            var dataVale = new Microsoft.Reporting.WinForms.ReportDataSource("dsVale", listaVale);

            this.reportVale.LocalReport.DataSources.Clear();
            this.reportVale.LocalReport.DataSources.Add(dataVale);
            this.reportVale.RefreshReport();

        }
    }
}
