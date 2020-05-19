using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using DTO_GestaoSalao;
using dll_BS_GestaoSalao;

namespace GestaoSalao
{
    public partial class frmListaPedidos : MaterialForm
    {
        public frmListaPedidos()
        {
            InitializeComponent();
        }
        private void frmListaPedidos_Load(object sender, EventArgs e)
        {
            CarregarFuncionario(ListaFuncionario());
        }
        private void button1_Click(object sender, EventArgs e)
        {

            CarregarPedidos();

        }

        private void CarregarPedidos()
        {
            var dataPesquisaInicio = dtpData.Value.ToString();
            var dataPesquisaFim = dtpDataFim.Value.ToString();
            int filtroFunc = 0;

            if (chkFiltroFuncionario.Checked == true)
            {
                filtroFunc = 1;
            }
            else
            {
                filtroFunc = 0;
            }

            var atendente = Convert.ToInt32(cbo_Profissional.SelectedValue);

            //dll_BS_GestaoSalao.FaturamentoBLL.(atendente, Convert.ToDateTime(dataPesquisaInicio), Convert.ToDateTime(dataPesquisaFim), filtroFunc));


            dll_BS_GestaoSalao.FaturamentoBLL bll = new dll_BS_GestaoSalao.FaturamentoBLL();
            CarregarServico(bll.CarregaPedidos(atendente, Convert.ToDateTime(dataPesquisaInicio), Convert.ToDateTime(dataPesquisaFim), filtroFunc));


        }

        private void CarregarServico(DataTable dtDespsa)
        {



            gridLista.DataSource = null; //Remover a datasource
            gridLista.Columns.Clear(); //Remover as colunas
            gridLista.Rows.Clear(); //Remover as linhas
            gridLista.Refresh(); //Para a grid se actualizar

            configuraDataGridView();
            gridLista.DataSource = dtDespsa;
            txtTotalGeral.Text = "";
            
            txtTotalGeral.Text  = Somar(dtDespsa).ToString("c");
        }

        private void CarregarFuncionario(List<Funcionario> List)
        {
            cbo_Profissional.DataSource = List;
            cbo_Profissional.DisplayMember = "nomeFUNCIONARIO";
            cbo_Profissional.ValueMember = "Id";
        }

        private List<Funcionario> ListaFuncionario()
        {
            dll_BS_GestaoSalao.FuncionarioBLL bll = new dll_BS_GestaoSalao.FuncionarioBLL();
            return bll.ListaFuncionarioSemID();
        }

        private void configuraDataGridView()
        {

            gridLista.AutoGenerateColumns = false;
            gridLista.ColumnCount =5;

            gridLista.Columns[0].HeaderText = "Pedido";
            gridLista.Columns[1].HeaderText = "servicoPEDIDO";
            gridLista.Columns[2].HeaderText = "Serviço";
            gridLista.Columns[3].HeaderText = "Funcionário";
            gridLista.Columns[4].HeaderText = "Valor";
          

            //Reverenciando as colunas do grid com as colunas vinda da tabela
            gridLista.Columns[0].DataPropertyName = "codigoFATURAMENTO";
            gridLista.Columns[1].DataPropertyName = "servicoITEMFATURAMENTO";
            gridLista.Columns[2].DataPropertyName = "descricaoSERVICO";
            gridLista.Columns[3].DataPropertyName = "nomeFUNCIONARIO";
            gridLista.Columns[4].DataPropertyName = "valorITEMFATURAMENTO";


            // strSql = "SELECT codigoFATURAMENTO,servicoITEMFATURAMENTO,
            //descricaoSERVICO,(CASE valorITEMPEDIDO WHEN 0 THEN precoSERVICO ELSE valorITEMFATURAMENTO END) AS valorITEMPEDIDO,nomeFUNCIONARIO ";
            //visible 
            gridLista.Columns[1].Visible = false;

            ////Redimenciona cada coluna
            gridLista.Columns[0].Width = 50;
            gridLista.Columns[1].Width = 0;
            gridLista.Columns[2].Width = 250;
            gridLista.Columns[3].Width = 250;
            gridLista.Columns[4].Width = 100;

            //Trata o campo valor
            gridLista.Columns[4].DefaultCellStyle.Format = "C2";


        }


        public decimal Somar(DataTable  List)

        {
            decimal TotalServivo = 0;

            //Cria as coluanas conforme a quantidade e nome dos funcionarios
            for (int i = 0; i < List.Rows.Count; i++)
            {

                if (List.Rows[i]["valorITEMFATURAMENTO"] != "0")
                {
                    TotalServivo = TotalServivo + Convert.ToDecimal(List.Rows[i]["valorITEMFATURAMENTO"]);
                    gridLista.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

            }
            return TotalServivo;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
        private void gridLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        

           int codigoFaturamento = Convert.ToInt32( gridLista.Rows[e.RowIndex].Cells[0].Value);
            if (codigoFaturamento != 0)
            {
             

                if (MessageBox.Show("Deseja excluir o Faturamento !!!", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //ExcluirPedido

                    Listas bll = new Listas();
                    bll.Cancelar(codigoFaturamento);
                    //gridLista.Rows.RemoveAt(gridLista.Rows[e.RowIndex].Index);
                    //  gridLista.Rows.RemoveAt(gridLista.CurrentRow.Index);
                    // MessageBox.Show("oi");
                    // gridLista.Rows.Remove(gridLista.CurrentRow);
                    CarregarPedidos();

                }

                else

                {

                    //rotina negativa

                }

            }

        }

        private void gridLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListaPedidos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void btnExportaExcel_Click(object sender, EventArgs e)
        {
            try
            {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CustomerDetail";

            for (int i = 0; i < gridLista.Columns.Count + 1; i++)
            {
                worksheet.Cells[1,i] = gridLista.Columns[i-1].HeaderText;
            }

            for (int i = 0; i < gridLista.Rows.Count + 1; i++)
            {
                for (int j = 0; j < gridLista.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = gridLista.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFile = new SaveFileDialog();
            saveFile.FileName = "output";
            saveFile.DefaultExt = ".xlsx";

            if(saveFile.ShowDialog()==DialogResult.OK)
            {
                workbook.SaveAs(saveFile.FileName,Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
            }

        }

        private void cbo_Profissional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
