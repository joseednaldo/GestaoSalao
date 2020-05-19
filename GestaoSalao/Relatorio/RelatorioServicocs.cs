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
    public partial class RelatorioServicocs : Form
    {
        public RelatorioServicocs()
        {
            InitializeComponent();
        }

        private void RelatorioServicocs_Load(object sender, EventArgs e)
        {

            dll_BS_GestaoSalao.ServicoBLL bllSerevico = new dll_BS_GestaoSalao.ServicoBLL();
            var listaServico = bllSerevico.ListaServico();
            var servicos = from s in listaServico
                        orderby s.Id
                        select new
                        {
                            s.Id,
                            s.DescricaoSERVICO,
                            s.PrecoSERVICO,
                        };

            var dataSourde = new Microsoft.Reporting.WinForms.ReportDataSource("dsServico", servicos);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSourde);
            this.reportViewer1.RefreshReport();
 
        }
    }
}
