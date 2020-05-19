using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using DTO_GestaoSalao;
using dll_BS_GestaoSalao;
using dll_Uteis_GestaoSalao;

namespace GestaoSalao
{
    public partial class frmPagto : MaterialForm
    {
        int BotaoCancelado = 0;

        public Enum TipoPagamento
        {
            get { return RetornaTipoPagto(); }
        }

        public int Canceldo
        {
            get { return BotaoCancelado ; }
        }


        public frmPagto()
        {
            InitializeComponent();
        }

        private void frmPagto_Load(object sender, EventArgs e)
        {
           
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            BotaoCancelado = 1;
            this.Close();
        }

        private void btIncuir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Enum  RetornaTipoPagto(){

            if (OptCartaoDebito.Checked)
            {
                return Uteis.TipoPagto.DEBITO;
            }
            else
            {
                return Uteis.TipoPagto.DINHEIRO;
            }
        }

        private void OptDinheiro_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
