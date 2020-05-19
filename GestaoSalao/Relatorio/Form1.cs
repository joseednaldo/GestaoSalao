using DTO_GestaoSalao;
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
    public partial class frmRelatorio : MaterialForm
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CarregarFuncionario(ListaFuncionario());

            //dll_BS_GestaoSalao.UsuarioBLL bll = new dll_BS_GestaoSalao.UsuarioBLL();
            //var usuarios = bll.ListA();
            ////usando linq
            //var teste = from u in usuarios
            //           orderby u.loginUSUARIO
            //            select new
            //            {
            //                u.codigoUSUARIO,
            //                u.loginUSUARIO
            //            };

            //var dataSourde = new Microsoft.Reporting.WinForms.ReportDataSource("dsUsuario", teste);

            //this.reportViewer.LocalReport.DataSources.Clear();
            //this.reportViewer.LocalReport.DataSources.Add(dataSourde);
            //this.reportViewer.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dataPesquisaInicio = dtpData.Value.ToString();
            var dataPesquisaFim = dtpDataFim.Value.ToString();
            int filtroFunc = 0;

            if (chkFiltroFuncionario.Checked == true)
            {
                filtroFunc = 1;
            }else
            {
                filtroFunc = 0;
            }

            var atendente = Convert.ToInt32(cbo_Profissional.SelectedValue);

            dll_BS_GestaoSalao.Listas lista = new dll_BS_GestaoSalao.Listas();
           var listaFaturamento = lista.CarregaPedidos(atendente, Convert.ToDateTime(dataPesquisaInicio), Convert.ToDateTime(dataPesquisaFim), filtroFunc);

           var dataSourde = new Microsoft.Reporting.WinForms.ReportDataSource("dsFaturamento", listaFaturamento);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSourde);
            this.reportViewer1.RefreshReport();


        }

        private List<Funcionario> ListaFuncionario()
        {
            dll_BS_GestaoSalao.FuncionarioBLL bll = new dll_BS_GestaoSalao.FuncionarioBLL();
            return bll.ListaFuncionarioSemID();
        }

        private void CarregarFuncionario(List<Funcionario> List)
        {
            cbo_Profissional.DataSource = List;
            cbo_Profissional.DisplayMember = "nomeFUNCIONARIO";
            cbo_Profissional.ValueMember = "Id";
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
