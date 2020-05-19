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

namespace GestaoSalao
{
    public partial class frmListaVale : MaterialForm
    {
        public frmListaVale()
        {
            InitializeComponent();
        }

        private void frmListaVale_Load(object sender, EventArgs e)
        {

        }

        public void ListaVales(int funcionario)
        {

            dll_BS_GestaoSalao.ValeBLL vale = new dll_BS_GestaoSalao.ValeBLL();
            var vales = vale.FindVale(funcionario);


            gridLista.DataSource = null; //Remover a datasource
            gridLista.Columns.Clear(); //Remover as colunas
            gridLista.Rows.Clear(); //Remover as linhas
            gridLista.Refresh(); //Para a grid se actualizar

            configuraDataGridView();
            gridLista.DataSource = vales;

        }

        private void configuraDataGridView()
        {

            gridLista.AutoGenerateColumns = false;
            gridLista.ColumnCount = 4;

            gridLista.Columns[0].HeaderText = "Código";
            gridLista.Columns[1].HeaderText = "Descrição";
            gridLista.Columns[2].HeaderText = "Valor";
            gridLista.Columns[3].HeaderText = "Data";
            //gridLista.Columns[4].HeaderText = "Funcionário";

            //Reverenciando as colunas do grid com as colunas vinda da tabela
            gridLista.Columns[0].DataPropertyName = "codigoVALE";
            gridLista.Columns[1].DataPropertyName = "descricaoVALE";
            gridLista.Columns[2].DataPropertyName = "valorVALE";
            gridLista.Columns[3].DataPropertyName = "dataVALE";
            //gridLista.Columns[4].DataPropertyName = "nomefuncionario";


            //visible 
            // gridLista.Columns[1].Visible = false;

            //Redimenciona cada coluna
            gridLista.Columns[0].Width = 50;
            gridLista.Columns[1].Width = 250;
            gridLista.Columns[2].Width = 80;
            gridLista.Columns[3].Width = 80;
            //gridLista.Columns[4].Width = 220;

            //Trata o campo valor
            gridLista.Columns[2].DefaultCellStyle.Format = "C2";

        }
    }
}
