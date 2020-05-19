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
    public partial class frmRelatorioDespesas : Form
    {
        public frmRelatorioDespesas()
        {
            InitializeComponent();
        }



        public void CarregaRelatorio(DateTime dataPesquisaInicio, DateTime dataPesquisaFim, int situacaoDespesa, int tipoDespesa)
        {

            dll_BS_GestaoSalao.DespesasBLL listaDes = new dll_BS_GestaoSalao.DespesasBLL();
            var listaDespesas = listaDes.Lista(dataPesquisaInicio, dataPesquisaFim, situacaoDespesa, tipoDespesa);

            var DsDespesas = new Microsoft.Reporting.WinForms.ReportDataSource("dsDespesas", listaDespesas);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(DsDespesas);
            this.reportViewer1.RefreshReport();

        }


    }
}
